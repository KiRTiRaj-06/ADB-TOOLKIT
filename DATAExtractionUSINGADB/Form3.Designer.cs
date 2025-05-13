namespace DATAExtractionUSINGADB
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(330, 127);
            button1.TabIndex = 0;
            button1.Text = "EXTRACT DATA FROM DEVICE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Location = new Point(372, 3);
            button2.Name = "button2";
            button2.Size = new Size(332, 127);
            button2.TabIndex = 1;
            button2.Text = "DISPLAY THE DATA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(33, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(739, 328);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Location = new Point(3, 167);
            button3.Name = "button3";
            button3.Size = new Size(330, 127);
            button3.TabIndex = 2;
            button3.Text = "DELETE DATA FROM DATABASE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.Location = new Point(372, 167);
            button4.Name = "button4";
            button4.Size = new Size(332, 127);
            button4.TabIndex = 3;
            button4.Text = "GENERATE A REPORT";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(153, 37);
            label1.Name = "label1";
            label1.Size = new Size(340, 20);
            label1.TabIndex = 3;
            label1.Text = "SELECT THE OPERATION YOU WANT TO PERFORM";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form3";
            Text = "Form3";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}