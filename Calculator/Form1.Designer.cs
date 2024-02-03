namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button0 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F);
            button1.Location = new Point(12, 282);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numberclick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 25F);
            button2.Location = new Point(93, 282);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numberclick;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 25F);
            button0.Location = new Point(93, 363);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 3;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += numberclick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 25F);
            button3.Location = new Point(174, 282);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numberclick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 25F);
            button4.Location = new Point(174, 201);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 7;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += numberclick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 25F);
            button5.Location = new Point(93, 201);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numberclick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 25F);
            button6.Location = new Point(12, 201);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 5;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += numberclick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 25F);
            button7.Location = new Point(174, 120);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 10;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += numberclick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 25F);
            button8.Location = new Point(93, 120);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += numberclick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 25F);
            button9.Location = new Point(12, 120);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 8;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numberclick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 30F);
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 61);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button0);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button0;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
    }
}
