namespace facultysystem
{
    partial class RegisterForm
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
            signup_btn = new Button();
            signup_showPass = new CheckBox();
            signup_password = new TextBox();
            signup_username = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            signup_loginBtn = new Button();
            Register = new Label();
            System = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.SlateBlue;
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(389, 415);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(128, 33);
            signup_btn.TabIndex = 15;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_showPass.Location = new Point(322, 358);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(112, 19);
            signup_showPass.TabIndex = 14;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.BackColor = SystemColors.HighlightText;
            signup_password.Location = new Point(322, 302);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(268, 23);
            signup_password.TabIndex = 13;
            // 
            // signup_username
            // 
            signup_username.BackColor = SystemColors.HighlightText;
            signup_username.Location = new Point(321, 196);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(269, 23);
            signup_username.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(317, 255);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 11;
            label5.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(317, 150);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 10;
            label4.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(317, 68);
            label3.Name = "label3";
            label3.Size = new Size(215, 30);
            label3.TabIndex = 9;
            label3.Text = "REGISTER ACCOUNT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(Register);
            panel1.Controls.Add(System);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 505);
            panel1.TabIndex = 8;
            // 
            // signup_loginBtn
            // 
            signup_loginBtn.BackColor = Color.SlateBlue;
            signup_loginBtn.Cursor = Cursors.Hand;
            signup_loginBtn.FlatStyle = FlatStyle.Flat;
            signup_loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_loginBtn.ForeColor = Color.White;
            signup_loginBtn.Location = new Point(71, 445);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(122, 31);
            signup_loginBtn.TabIndex = 8;
            signup_loginBtn.Text = "SIGN IN";
            signup_loginBtn.UseVisualStyleBackColor = false;
            signup_loginBtn.Click += signup_loginBtn_Click;
            // 
            // Register
            // 
            Register.AutoSize = true;
            Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(56, 402);
            Register.Name = "Register";
            Register.Size = new Size(159, 21);
            Register.TabIndex = 1;
            Register.Text = "Login Your Account";
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(491, 358);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 509);
            Controls.Add(linkLabel1);
            Controls.Add(signup_btn);
            Controls.Add(signup_showPass);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_btn;
        private CheckBox signup_showPass;
        private TextBox signup_password;
        private TextBox signup_username;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Button signup_loginBtn;
        private Label Register;
        private Label System;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}