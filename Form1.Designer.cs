namespace facultysystem
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
            panel1 = new Panel();
            login_signupBtn = new Button();
            Register = new Label();
            System = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            login_showPass = new CheckBox();
            login_btn = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(Register);
            panel1.Controls.Add(System);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 505);
            panel1.TabIndex = 0;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.SlateBlue;
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(71, 445);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(122, 31);
            login_signupBtn.TabIndex = 8;
            login_signupBtn.Text = "SIGNUP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // Register
            // 
            Register.AutoSize = true;
            Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(47, 412);
            Register.Name = "Register";
            Register.Size = new Size(178, 21);
            Register.TabIndex = 1;
            Register.Text = "Register Your Account";
            // 
            // System
            // 
            System.AutoSize = true;
            System.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            System.ForeColor = Color.White;
            System.Location = new Point(8, 241);
            System.Name = "System";
            System.Size = new Size(258, 42);
            System.TabIndex = 1;
            System.Text = "    FACULTY WORKLOAD AND \r\nRESOURCE ALLOCATION SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Screenshot__337__1;
            pictureBox1.Location = new Point(56, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 178);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 79);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 1;
            label3.Text = "LOGIN ACCOUNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(303, 149);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 2;
            label4.Text = "USERNAME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(308, 254);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 3;
            label5.Text = "PASSWORD";
            // 
            // login_username
            // 
            login_username.Location = new Point(307, 197);
            login_username.Name = "login_username";
            login_username.Size = new Size(269, 23);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Location = new Point(308, 301);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(268, 23);
            login_password.TabIndex = 5;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(308, 357);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(112, 19);
            login_showPass.TabIndex = 6;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.SlateBlue;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(375, 414);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(128, 33);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(491, 359);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 507);
            Controls.Add(linkLabel1);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Register;
        private Label System;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox login_username;
        private TextBox login_password;
        private CheckBox login_showPass;
        private Button login_btn;
        private Button login_signupBtn;
        private LinkLabel linkLabel1;
    }
}
