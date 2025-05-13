namespace DATAExtractionUSINGADB
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            button6 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(42, 16);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 0;
            label1.Text = "CHOOSE THE ADB OPERATION TO PERFORM";
            // 
            // button1
            // 
            button1.Location = new Point(42, 59);
            button1.Name = "button1";
            button1.Size = new Size(217, 29);
            button1.TabIndex = 1;
            button1.Text = "EXTRACT CONTACT LIST";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 108);
            button2.Name = "button2";
            button2.Size = new Size(217, 29);
            button2.TabIndex = 2;
            button2.Text = "EXTRACT SMS INFO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 160);
            button3.Name = "button3";
            button3.Size = new Size(217, 29);
            button3.TabIndex = 3;
            button3.Text = "EXTRACT CALL LOGS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 212);
            button4.Name = "button4";
            button4.Size = new Size(217, 29);
            button4.TabIndex = 4;
            button4.Text = "EXTRACT CPU MEMORY INFO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(42, 265);
            button5.Name = "button5";
            button5.Size = new Size(217, 29);
            button5.TabIndex = 5;
            button5.Text = "EXTRACT LOGIN ACCOUNT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // button6
            // 
            button6.Location = new Point(42, 312);
            button6.Name = "button6";
            button6.Size = new Size(217, 29);
            button6.TabIndex = 6;
            button6.Text = "DEVICE INFORMATION";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gray;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(370, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(418, 377);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button6;
        private TextBox textBox1;
    }
}