using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   

namespace DATAExtractionUSINGADB
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        string connstring = "userId=root;password=0622#I;server=localhost;database=at;Charset=utf8mb4;";
        
        //private string Escape(string input, int maxLength = 255)
        //{
        //    if (string.IsNullOrEmpty(input)) return "";
        //    input = input.Replace("'", "''");
        //    return input.Length > maxLength ? input.Substring(0, maxLength) : input;
        //}

        private string Escape(string input, int maxLength = -1)
        {
            if (input == null) return "";

            // Truncate the string if maxLength is provided
            string safe = input.Replace("'", "''");
            return (maxLength > 0 && safe.Length > maxLength) ? safe.Substring(0, maxLength) : safe;
        }
        private void InsertToDB(string query)
        {
            using MySqlConnection conn = new MySqlConnection(connstring);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private string ExtractValue(string line, string key)
        {
            var match = Regex.Match(line, $"{Regex.Escape(key)}(.*?)((\\s\\w+=)|$)");
            if (match.Success)
                return match.Groups[1].Value.Trim().Replace("'", "");
            return "";
        }

        private string ExtractAccountName(string line)
        {
            int start = line.IndexOf("{") + 1;
            int end = line.IndexOf(",", start);
            return line.Substring(start, end - start).Trim();
        }

        private string RunADBCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = System.Text.Encoding.UTF8
            };
            Process? process = Process.Start(psi);
            if (process == null)
            {
                throw new InvalidOperationException("Failed to start the ADB process.");
            }
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = RunADBCommand("shell content query --uri content://contacts/phones/ --projection display_name:number:email ");
            MessageBox.Show(output, "Contacts");
            textBox1.Text = output;

               foreach (string line in output.Split('\n'))
                {
                    string name = ExtractValue(line, "display_name=");
                    string phone = ExtractValue(line, "number=");
                    string email = ExtractValue(line, "Email=");
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone))
                    {
                        InsertToDB($"INSERT INTO contactstable (Name, PhoneNumber, Email) VALUES ('{Escape(name,100)}', '{Escape(phone,20)}', '{Escape(email,50)}')");
                    }
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output = RunADBCommand("shell content query --uri content://sms/ --projection address:date:body ");
            textBox1.Text = output;
            foreach(string line in output.Split('\n'))
            {
                string senderAddr = ExtractValue(line, "address=");
                string body = ExtractValue(line, "body=");
                string date = ExtractValue(line, "date=");
              
                if (string.IsNullOrEmpty(senderAddr) || string.IsNullOrEmpty(body) || string.IsNullOrEmpty(date))
                    continue;
             

                if (decimal.TryParse(date, out decimal millis))
                {
                    long seconds = (long)(millis / 1000);
                    string query = $"INSERT INTO MessagesTable (Sender, Message, Timestamp) " +
                        $"VALUES ('{Escape(senderAddr, 100)}', '{Escape(body, 500)}', FROM_UNIXTIME({seconds}))";
                    InsertToDB(query);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string output = RunADBCommand("shell content query --uri content://call_log/calls/ --projection number:name:duration:date ");
            MessageBox.Show(output, "Call Logs");
            textBox1.Text = output;

            foreach (string line in output.Split('\n'))
            {
                string number = ExtractValue(line, "number=");
                string name = ExtractValue(line, "name=");
                string date = ExtractValue(line, "date=");
                string duration = ExtractValue(line, "duration=");

                
                if (!string.IsNullOrEmpty(number))
                {
                    
                    string query = $"INSERT INTO calllogstable (Number, Name, Duration) " +
                        $"VALUES ('{Escape(number, 20)}', '{Escape(name, 50)}', {duration ?? "0"})";
                    //MessageBox.Show("Query: " + query); // DEBUG
                    InsertToDB(query);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cpuInfo = RunADBCommand("shell cat /proc/cpuinfo ");
            string memInfo = RunADBCommand("shell cat /proc/meminfo  ");
            MessageBox.Show(cpuInfo + "\n\n" + memInfo, "CPU & Memory Info");
            textBox1.Text = cpuInfo + "\n\n" + memInfo;
            
            InsertToDB($"INSERT INTO cpuinfotable (CPUInfo, MemoryInfo) VALUES ('{Escape(cpuInfo)}', '{Escape(memInfo)}')");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string output = RunADBCommand("shell dumpsys account");
            MessageBox.Show(output, "Login Accounts");
            textBox1.Text = output;

            foreach (string line in output.Split('\n'))
            {
                if (line.Contains("Account {"))
                {
                    string account = ExtractAccountName(line);
                    string email = account.Contains("@") ? account : "";
                    InsertToDB($"INSERT INTO loginaccountstable (AccountName, EmailAddress) VALUES ('{Escape(account, 100)}', '{Escape(email, 100)}')");
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string model = RunADBCommand("shell getprop ro.product.model");
            string androidVersion = RunADBCommand("shell getprop ro.build.version.release");
            string serialNumber = RunADBCommand("shell getprop ro.serialno");
            string device = RunADBCommand("shell getprop ro.product.device");
            string result = $"Model: {model}\n" +
                           $"Android Version: {androidVersion}\n\n" +
                            $"Serial Number: {serialNumber}\n" +
                            $"Device: {device}";
            MessageBox.Show(result, "Device Info");
            textBox1.Text = result;

            InsertToDB($"INSERT INTO devicedetailsTable (Model, AndroidVersion, SerialNumber, Device) VALUES ('{Escape(model,100)}', '{Escape(androidVersion, 100)}', '{Escape(serialNumber)}', '{Escape(device)}')");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
