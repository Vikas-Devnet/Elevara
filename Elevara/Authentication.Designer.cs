namespace Elevara
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            authSignUp = new Label();
            label5 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            authRememberCredential = new RadioButton();
            authLoginBtn = new Button();
            authPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            authUsername = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(50, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 653);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(493, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(689, 653);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(authSignUp);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(242, 435);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 28);
            panel5.TabIndex = 4;
            // 
            // authSignUp
            // 
            authSignUp.AutoSize = true;
            authSignUp.Dock = DockStyle.Right;
            authSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            authSignUp.Location = new Point(172, 0);
            authSignUp.Name = "authSignUp";
            authSignUp.Size = new Size(63, 20);
            authSignUp.TabIndex = 1;
            authSignUp.Text = "Sign Up";
            authSignUp.Click += AuthSignUp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 0;
            label5.Text = "Don't have an account ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Unicode MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 78);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back !";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(authRememberCredential);
            panel4.Controls.Add(authLoginBtn);
            panel4.Controls.Add(authPassword);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(authUsername);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(106, 112);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(467, 317);
            panel4.TabIndex = 0;
            // 
            // authRememberCredential
            // 
            authRememberCredential.AutoSize = true;
            authRememberCredential.Location = new Point(250, 205);
            authRememberCredential.Name = "authRememberCredential";
            authRememberCredential.Size = new Size(181, 24);
            authRememberCredential.TabIndex = 6;
            authRememberCredential.TabStop = true;
            authRememberCredential.Text = "Remember Credentials";
            authRememberCredential.UseVisualStyleBackColor = true;
            authRememberCredential.CheckedChanged += AuthRememberCredential_CheckedChanged;
            // 
            // authLoginBtn
            // 
            authLoginBtn.BackColor = Color.MidnightBlue;
            authLoginBtn.Font = new Font("Arial Unicode MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            authLoginBtn.ForeColor = Color.Transparent;
            authLoginBtn.Location = new Point(28, 250);
            authLoginBtn.Name = "authLoginBtn";
            authLoginBtn.Padding = new Padding(5);
            authLoginBtn.Size = new Size(403, 42);
            authLoginBtn.TabIndex = 5;
            authLoginBtn.Text = "Log in";
            authLoginBtn.UseVisualStyleBackColor = false;
            authLoginBtn.Click += AuthLoginBtn_Click;
            // 
            // authPassword
            // 
            authPassword.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authPassword.Location = new Point(28, 165);
            authPassword.Name = "authPassword";
            authPassword.PlaceholderText = "Enter Password";
            authPassword.Size = new Size(403, 34);
            authPassword.TabIndex = 4;
            authPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Unicode MS", 10.2F, FontStyle.Bold);
            label4.Location = new Point(23, 139);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Unicode MS", 10.2F, FontStyle.Bold);
            label3.Location = new Point(25, 69);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // authUsername
            // 
            authUsername.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authUsername.Location = new Point(28, 95);
            authUsername.Name = "authUsername";
            authUsername.PlaceholderText = "Enter Your Username";
            authUsername.Size = new Size(403, 34);
            authUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Unicode MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 0;
            label2.Text = "Log in";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 100, 50, 100);
            panel2.Size = new Size(490, 653);
            panel2.TabIndex = 0;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1282, 853);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Authentication";
            Padding = new Padding(50, 100, 50, 100);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elevara";
            Load += Authentication_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private TextBox authUsername;
        private TextBox authPassword;
        private Label label4;
        private Label label3;
        private Button authLoginBtn;
        private Panel panel5;
        private RadioButton authRememberCredential;
        private Label label5;
        private Label authSignUp;
    }
}