namespace Elevara
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            panelNaigation = new Panel();
            panelAgentOperatives = new Panel();
            submenuAgentDetails = new Button();
            submenuAgentCurrentStatus = new Button();
            submenuAgentAccessControl = new Button();
            submenuAgentApproval = new Button();
            btnOperativesMenu = new Button();
            panelAdminOperatives = new Panel();
            submenuAdminDetails = new Button();
            submenuActionDetails = new Button();
            submenuAdminAccessControl = new Button();
            submenuAdminApproval = new Button();
            btnAdminOperatives = new Button();
            panelAppDetails = new Panel();
            label1 = new Label();
            labelAppName = new Label();
            panelActionBar = new Panel();
            panelContainer = new Panel();
            pictureBox1 = new PictureBox();
            panelNaigation.SuspendLayout();
            panelAgentOperatives.SuspendLayout();
            panelAdminOperatives.SuspendLayout();
            panelAppDetails.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNaigation
            // 
            panelNaigation.AutoScroll = true;
            panelNaigation.BackColor = Color.FromArgb(51, 51, 76);
            panelNaigation.Controls.Add(panelAgentOperatives);
            panelNaigation.Controls.Add(btnOperativesMenu);
            panelNaigation.Controls.Add(panelAdminOperatives);
            panelNaigation.Controls.Add(btnAdminOperatives);
            panelNaigation.Controls.Add(panelAppDetails);
            panelNaigation.Dock = DockStyle.Left;
            panelNaigation.Location = new Point(0, 0);
            panelNaigation.Name = "panelNaigation";
            panelNaigation.Size = new Size(330, 653);
            panelNaigation.TabIndex = 0;
            panelNaigation.Click += PanelNaigation_Click;
            // 
            // panelAgentOperatives
            // 
            panelAgentOperatives.Controls.Add(submenuAgentDetails);
            panelAgentOperatives.Controls.Add(submenuAgentCurrentStatus);
            panelAgentOperatives.Controls.Add(submenuAgentAccessControl);
            panelAgentOperatives.Controls.Add(submenuAgentApproval);
            panelAgentOperatives.Dock = DockStyle.Top;
            panelAgentOperatives.Location = new Point(0, 400);
            panelAgentOperatives.Name = "panelAgentOperatives";
            panelAgentOperatives.Padding = new Padding(5);
            panelAgentOperatives.Size = new Size(330, 180);
            panelAgentOperatives.TabIndex = 10;
            // 
            // submenuAgentDetails
            // 
            submenuAgentDetails.BackColor = Color.FromArgb(255, 224, 192);
            submenuAgentDetails.Dock = DockStyle.Top;
            submenuAgentDetails.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAgentDetails.Location = new Point(5, 125);
            submenuAgentDetails.Name = "submenuAgentDetails";
            submenuAgentDetails.Padding = new Padding(75, 0, 0, 0);
            submenuAgentDetails.Size = new Size(320, 40);
            submenuAgentDetails.TabIndex = 4;
            submenuAgentDetails.Text = "Agent Details";
            submenuAgentDetails.TextAlign = ContentAlignment.MiddleLeft;
            submenuAgentDetails.UseVisualStyleBackColor = false;
            submenuAgentDetails.Click += SubmenuAgentDetails_Click;
            // 
            // submenuAgentCurrentStatus
            // 
            submenuAgentCurrentStatus.BackColor = Color.FromArgb(255, 224, 192);
            submenuAgentCurrentStatus.Dock = DockStyle.Top;
            submenuAgentCurrentStatus.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAgentCurrentStatus.Location = new Point(5, 85);
            submenuAgentCurrentStatus.Name = "submenuAgentCurrentStatus";
            submenuAgentCurrentStatus.Padding = new Padding(75, 0, 0, 0);
            submenuAgentCurrentStatus.Size = new Size(320, 40);
            submenuAgentCurrentStatus.TabIndex = 3;
            submenuAgentCurrentStatus.Text = "Live Status";
            submenuAgentCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            submenuAgentCurrentStatus.UseVisualStyleBackColor = false;
            submenuAgentCurrentStatus.Click += SubmenuAgentCurrentStatus_Click;
            // 
            // submenuAgentAccessControl
            // 
            submenuAgentAccessControl.BackColor = Color.FromArgb(255, 224, 192);
            submenuAgentAccessControl.Dock = DockStyle.Top;
            submenuAgentAccessControl.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAgentAccessControl.Location = new Point(5, 45);
            submenuAgentAccessControl.Name = "submenuAgentAccessControl";
            submenuAgentAccessControl.Padding = new Padding(75, 0, 0, 0);
            submenuAgentAccessControl.Size = new Size(320, 40);
            submenuAgentAccessControl.TabIndex = 2;
            submenuAgentAccessControl.Text = "Agent Access";
            submenuAgentAccessControl.TextAlign = ContentAlignment.MiddleLeft;
            submenuAgentAccessControl.UseVisualStyleBackColor = false;
            submenuAgentAccessControl.Click += SubmenuAgentAccessControl_Click;
            // 
            // submenuAgentApproval
            // 
            submenuAgentApproval.BackColor = Color.FromArgb(255, 224, 192);
            submenuAgentApproval.Dock = DockStyle.Top;
            submenuAgentApproval.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAgentApproval.Location = new Point(5, 5);
            submenuAgentApproval.Name = "submenuAgentApproval";
            submenuAgentApproval.Padding = new Padding(75, 0, 0, 0);
            submenuAgentApproval.Size = new Size(320, 40);
            submenuAgentApproval.TabIndex = 1;
            submenuAgentApproval.Text = "Agent Approval";
            submenuAgentApproval.TextAlign = ContentAlignment.MiddleLeft;
            submenuAgentApproval.UseVisualStyleBackColor = false;
            submenuAgentApproval.Click += SubmenuAgentApproval_Click;
            // 
            // btnOperativesMenu
            // 
            btnOperativesMenu.BackColor = Color.FromArgb(51, 51, 76);
            btnOperativesMenu.Dock = DockStyle.Top;
            btnOperativesMenu.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            btnOperativesMenu.ForeColor = Color.White;
            btnOperativesMenu.Location = new Point(0, 340);
            btnOperativesMenu.Name = "btnOperativesMenu";
            btnOperativesMenu.Padding = new Padding(50, 0, 0, 0);
            btnOperativesMenu.Size = new Size(330, 60);
            btnOperativesMenu.TabIndex = 9;
            btnOperativesMenu.Text = "Agent Operatives";
            btnOperativesMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnOperativesMenu.UseVisualStyleBackColor = false;
            btnOperativesMenu.Click += BtnOperativesMenu_Click;
            // 
            // panelAdminOperatives
            // 
            panelAdminOperatives.Controls.Add(submenuAdminDetails);
            panelAdminOperatives.Controls.Add(submenuActionDetails);
            panelAdminOperatives.Controls.Add(submenuAdminAccessControl);
            panelAdminOperatives.Controls.Add(submenuAdminApproval);
            panelAdminOperatives.Dock = DockStyle.Top;
            panelAdminOperatives.Location = new Point(0, 160);
            panelAdminOperatives.Name = "panelAdminOperatives";
            panelAdminOperatives.Padding = new Padding(5);
            panelAdminOperatives.Size = new Size(330, 180);
            panelAdminOperatives.TabIndex = 8;
            // 
            // submenuAdminDetails
            // 
            submenuAdminDetails.BackColor = Color.FromArgb(255, 192, 192);
            submenuAdminDetails.Dock = DockStyle.Top;
            submenuAdminDetails.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAdminDetails.Location = new Point(5, 125);
            submenuAdminDetails.Name = "submenuAdminDetails";
            submenuAdminDetails.Padding = new Padding(75, 0, 0, 0);
            submenuAdminDetails.Size = new Size(320, 40);
            submenuAdminDetails.TabIndex = 4;
            submenuAdminDetails.Text = "Admin Details";
            submenuAdminDetails.TextAlign = ContentAlignment.MiddleLeft;
            submenuAdminDetails.UseVisualStyleBackColor = false;
            submenuAdminDetails.Click += SubmenuAdminDetails_Click;
            // 
            // submenuActionDetails
            // 
            submenuActionDetails.BackColor = Color.FromArgb(255, 192, 192);
            submenuActionDetails.Dock = DockStyle.Top;
            submenuActionDetails.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuActionDetails.Location = new Point(5, 85);
            submenuActionDetails.Name = "submenuActionDetails";
            submenuActionDetails.Padding = new Padding(75, 0, 0, 0);
            submenuActionDetails.Size = new Size(320, 40);
            submenuActionDetails.TabIndex = 3;
            submenuActionDetails.Text = "Actions Details";
            submenuActionDetails.TextAlign = ContentAlignment.MiddleLeft;
            submenuActionDetails.UseVisualStyleBackColor = false;
            submenuActionDetails.Click += SubmenuActionDetails_Click;
            // 
            // submenuAdminAccessControl
            // 
            submenuAdminAccessControl.BackColor = Color.FromArgb(255, 192, 192);
            submenuAdminAccessControl.Dock = DockStyle.Top;
            submenuAdminAccessControl.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAdminAccessControl.Location = new Point(5, 45);
            submenuAdminAccessControl.Name = "submenuAdminAccessControl";
            submenuAdminAccessControl.Padding = new Padding(75, 0, 0, 0);
            submenuAdminAccessControl.Size = new Size(320, 40);
            submenuAdminAccessControl.TabIndex = 2;
            submenuAdminAccessControl.Text = "Admin Access";
            submenuAdminAccessControl.TextAlign = ContentAlignment.MiddleLeft;
            submenuAdminAccessControl.UseVisualStyleBackColor = false;
            submenuAdminAccessControl.Click += SubmenuAdminAccessControl_Click;
            // 
            // submenuAdminApproval
            // 
            submenuAdminApproval.BackColor = Color.FromArgb(255, 192, 192);
            submenuAdminApproval.Dock = DockStyle.Top;
            submenuAdminApproval.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold);
            submenuAdminApproval.Location = new Point(5, 5);
            submenuAdminApproval.Name = "submenuAdminApproval";
            submenuAdminApproval.Padding = new Padding(75, 0, 0, 0);
            submenuAdminApproval.Size = new Size(320, 40);
            submenuAdminApproval.TabIndex = 1;
            submenuAdminApproval.Text = "Admin Approval";
            submenuAdminApproval.TextAlign = ContentAlignment.MiddleLeft;
            submenuAdminApproval.UseVisualStyleBackColor = false;
            submenuAdminApproval.Click += SubmenuAdminApproval_Click;
            // 
            // btnAdminOperatives
            // 
            btnAdminOperatives.BackColor = Color.FromArgb(51, 51, 76);
            btnAdminOperatives.Dock = DockStyle.Top;
            btnAdminOperatives.FlatAppearance.BorderSize = 3;
            btnAdminOperatives.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOperatives.ForeColor = Color.White;
            btnAdminOperatives.Location = new Point(0, 100);
            btnAdminOperatives.Name = "btnAdminOperatives";
            btnAdminOperatives.Padding = new Padding(50, 0, 0, 0);
            btnAdminOperatives.Size = new Size(330, 60);
            btnAdminOperatives.TabIndex = 4;
            btnAdminOperatives.Text = "Admin Operatives";
            btnAdminOperatives.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminOperatives.UseVisualStyleBackColor = false;
            btnAdminOperatives.Click += BtnAdminOperatives_Click;
            // 
            // panelAppDetails
            // 
            panelAppDetails.BackColor = Color.FromArgb(39, 39, 58);
            panelAppDetails.Controls.Add(label1);
            panelAppDetails.Controls.Add(labelAppName);
            panelAppDetails.Dock = DockStyle.Top;
            panelAppDetails.Location = new Point(0, 0);
            panelAppDetails.Name = "panelAppDetails";
            panelAppDetails.Size = new Size(330, 100);
            panelAppDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(0, 35);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Pwered By DevNet";
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Dock = DockStyle.Top;
            labelAppName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelAppName.ForeColor = Color.Cyan;
            labelAppName.Location = new Point(0, 0);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(99, 35);
            labelAppName.TabIndex = 0;
            labelAppName.Text = "Elevara";
            labelAppName.TextAlign = ContentAlignment.MiddleCenter;
            labelAppName.Click += Label_AppName_Click;
            // 
            // panelActionBar
            // 
            panelActionBar.BackColor = Color.FromArgb(51, 51, 76);
            panelActionBar.Dock = DockStyle.Top;
            panelActionBar.Location = new Point(330, 0);
            panelActionBar.Name = "panelActionBar";
            panelActionBar.Size = new Size(602, 80);
            panelActionBar.TabIndex = 1;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(330, 80);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(602, 573);
            panelContainer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 653);
            Controls.Add(panelContainer);
            Controls.Add(panelActionBar);
            Controls.Add(panelNaigation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Layout";
            Text = "Elevara";
            panelNaigation.ResumeLayout(false);
            panelAgentOperatives.ResumeLayout(false);
            panelAdminOperatives.ResumeLayout(false);
            panelAppDetails.ResumeLayout(false);
            panelAppDetails.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNaigation;
        private Panel panelAppDetails;
        private Panel panelAgentOperatives;
        private Button submenuAgentDetails;
        private Button submenuAgentCurrentStatus;
        private Button submenuAgentAccessControl;
        private Button submenuAgentApproval;
        private Button btnOperativesMenu;
        private Panel panelAdminOperatives;
        private Button submenuAdminDetails;
        private Button submenuActionDetails;
        private Button submenuAdminAccessControl;
        private Button submenuAdminApproval;
        private Button btnAdminOperatives;
        private Label labelAppName;
        private Panel panelActionBar;
        private Panel panelContainer;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
