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
            btnCE = new Button();
            btnMINUS = new Button();
            btnPLUS = new Button();
            btnDIVISION = new Button();
            btnMULT = new Button();
            btnC = new Button();
            label1 = new Label();
            btnEqual = new Button();
            btnDOT = new Button();
            btnBACKSPACE = new Button();
            btnSQR = new Button();
            btnSQRT = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F);
            button1.Location = new Point(12, 363);
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
            button2.Location = new Point(93, 363);
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
            button0.Location = new Point(93, 446);
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
            button3.Location = new Point(174, 363);
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
            button4.Location = new Point(174, 282);
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
            button5.Location = new Point(93, 282);
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
            button6.Location = new Point(12, 282);
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
            button7.Location = new Point(174, 201);
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
            button8.Location = new Point(93, 201);
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
            button9.Location = new Point(12, 201);
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
            textBox1.Size = new Size(399, 61);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 25F);
            btnCE.Location = new Point(174, 120);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(75, 75);
            btnCE.TabIndex = 12;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnMINUS
            // 
            btnMINUS.Font = new Font("Segoe UI", 25F);
            btnMINUS.Location = new Point(255, 201);
            btnMINUS.Name = "btnMINUS";
            btnMINUS.Size = new Size(75, 75);
            btnMINUS.TabIndex = 13;
            btnMINUS.Text = "-";
            btnMINUS.UseVisualStyleBackColor = true;
            btnMINUS.Click += btnMINUS_Click;
            // 
            // btnPLUS
            // 
            btnPLUS.Font = new Font("Segoe UI", 25F);
            btnPLUS.Location = new Point(336, 282);
            btnPLUS.Name = "btnPLUS";
            btnPLUS.Size = new Size(75, 75);
            btnPLUS.TabIndex = 14;
            btnPLUS.Text = "+";
            btnPLUS.UseVisualStyleBackColor = true;
            btnPLUS.Click += btnPLUS_Click;
            // 
            // btnDIVISION
            // 
            btnDIVISION.Font = new Font("Segoe UI", 25F);
            btnDIVISION.Location = new Point(336, 201);
            btnDIVISION.Name = "btnDIVISION";
            btnDIVISION.Size = new Size(75, 75);
            btnDIVISION.TabIndex = 15;
            btnDIVISION.Text = "÷";
            btnDIVISION.UseVisualStyleBackColor = true;
            btnDIVISION.Click += btnDIVISION_Click;
            // 
            // btnMULT
            // 
            btnMULT.Font = new Font("Segoe UI", 25F);
            btnMULT.Location = new Point(255, 282);
            btnMULT.Name = "btnMULT";
            btnMULT.Size = new Size(75, 75);
            btnMULT.TabIndex = 16;
            btnMULT.Text = "×";
            btnMULT.UseVisualStyleBackColor = true;
            btnMULT.Click += btnMULT_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 25F);
            btnC.Location = new Point(255, 120);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 75);
            btnC.TabIndex = 17;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(399, 23);
            label1.TabIndex = 18;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 25F);
            btnEqual.Location = new Point(336, 363);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 75);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDOT
            // 
            btnDOT.Font = new Font("Segoe UI", 25F);
            btnDOT.Location = new Point(255, 363);
            btnDOT.Name = "btnDOT";
            btnDOT.Size = new Size(75, 75);
            btnDOT.TabIndex = 20;
            btnDOT.Text = ".";
            btnDOT.UseVisualStyleBackColor = true;
            btnDOT.Click += btnDOT_Click;
            // 
            // btnBACKSPACE
            // 
            btnBACKSPACE.Font = new Font("Segoe UI", 25F);
            btnBACKSPACE.Location = new Point(336, 120);
            btnBACKSPACE.Name = "btnBACKSPACE";
            btnBACKSPACE.Size = new Size(75, 75);
            btnBACKSPACE.TabIndex = 21;
            btnBACKSPACE.Text = "⌫";
            btnBACKSPACE.UseVisualStyleBackColor = true;
            btnBACKSPACE.Click += btnBACKSPACE_Click;
            // 
            // btnSQR
            // 
            btnSQR.Font = new Font("Segoe UI", 25F);
            btnSQR.Location = new Point(93, 120);
            btnSQR.Name = "btnSQR";
            btnSQR.Size = new Size(75, 75);
            btnSQR.TabIndex = 22;
            btnSQR.Text = "x²";
            btnSQR.UseVisualStyleBackColor = true;
            btnSQR.Click += btnSQR_Click;
            // 
            // btnSQRT
            // 
            btnSQRT.Font = new Font("Segoe UI", 25F);
            btnSQRT.Location = new Point(12, 120);
            btnSQRT.Name = "btnSQRT";
            btnSQRT.Size = new Size(75, 75);
            btnSQRT.TabIndex = 23;
            btnSQRT.Text = "√x";
            btnSQRT.UseVisualStyleBackColor = true;
            btnSQRT.Click += btnSQRT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 533);
            Controls.Add(btnSQRT);
            Controls.Add(btnSQR);
            Controls.Add(btnBACKSPACE);
            Controls.Add(btnDOT);
            Controls.Add(btnEqual);
            Controls.Add(label1);
            Controls.Add(btnC);
            Controls.Add(btnMULT);
            Controls.Add(btnDIVISION);
            Controls.Add(btnPLUS);
            Controls.Add(btnMINUS);
            Controls.Add(btnCE);
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
        private Button btnCE;
        private Button btnMINUS;
        private Button btnPLUS;
        private Button btnDIVISION;
        private Button btnMULT;
        private Button btnC;
        private Label label1;
        private Button btnEqual;
        private Button btnDOT;
        private Button btnBACKSPACE;
        private Button btnSQR;
        private Button btnSQRT;
    }
}
