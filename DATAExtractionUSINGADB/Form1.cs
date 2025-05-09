using System.Data;
using MySql.Data.MySqlClient;
namespace DATAExtractionUSINGADB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String ConnectionString = "userId=root;password=*****;server=localhost;database=at";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            string query = "SELECT * FROM cpuinfotable";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.DataSource = null; // Clear previous data 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = "userId=root;password=0622#I;server=localhost;database=at";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            string query = "SELECT * FROM contactstable";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.DataSource = null; // Clear previous data 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ConnectionString = "userId=root;password=0622#I;server=localhost;database=at";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            string query = "SELECT * FROM messagestable";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.DataSource = null; // Clear previous data 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ConnectionString = "userId=root;password=0622#I;server=localhost;database=at";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            string query = "SELECT * FROM calllogstable";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.DataSource = null; // Clear previous data 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String ConnectionString = "userId=root;password=0622#I;server=localhost;database=at";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            string query = "SELECT * FROM loginaccountstable";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.DataSource = null; // Clear previous data 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String ConnectionString = "userId=root;password=0622#I;server=localhost;database=at";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            string query = "SELECT * FROM devicedetailstable";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.DataSource = null; // Clear previous data 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
