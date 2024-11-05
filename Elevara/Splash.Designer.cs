namespace Elevara
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            splashLabel = new Label();
            poweredByText = new Label();
            spashVersionLabel = new Label();
            splashTimer = new System.Windows.Forms.Timer(components);
            splashProgressBar = new ProgressBar();
            splashProgressValue = new Label();
            SuspendLayout();
            // 
            // splashLabel
            // 
            splashLabel.AutoSize = true;
            splashLabel.BackColor = Color.Transparent;
            splashLabel.Font = new Font("Bell MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            splashLabel.ForeColor = Color.Transparent;
            splashLabel.Location = new Point(259, 167);
            splashLabel.Name = "splashLabel";
            splashLabel.Size = new Size(419, 92);
            splashLabel.TabIndex = 0;
            splashLabel.Text = "ELEVARA";
            // 
            // poweredByText
            // 
            poweredByText.AutoSize = true;
            poweredByText.BackColor = Color.Transparent;
            poweredByText.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poweredByText.ForeColor = Color.Transparent;
            poweredByText.Location = new Point(29, 431);
            poweredByText.Name = "poweredByText";
            poweredByText.Size = new Size(221, 31);
            poweredByText.TabIndex = 1;
            poweredByText.Text = "Powered By Devnet";
            // 
            // spashVersionLabel
            // 
            spashVersionLabel.AutoSize = true;
            spashVersionLabel.BackColor = Color.Transparent;
            spashVersionLabel.Location = new Point(577, 239);
            spashVersionLabel.Name = "spashVersionLabel";
            spashVersionLabel.Size = new Size(80, 20);
            spashVersionLabel.TabIndex = 2;
            spashVersionLabel.Text = "Version 1.0";
            // 
            // splashTimer
            // 
            splashTimer.Tick += SplashTimerTick;
            // 
            // splashProgressBar
            // 
            splashProgressBar.ForeColor = Color.Transparent;
            splashProgressBar.Location = new Point(29, 465);
            splashProgressBar.Margin = new Padding(20, 3, 20, 3);
            splashProgressBar.Name = "splashProgressBar";
            splashProgressBar.Size = new Size(873, 18);
            splashProgressBar.TabIndex = 3;
            // 
            // splashProgressValue
            // 
            splashProgressValue.AutoSize = true;
            splashProgressValue.BackColor = Color.Transparent;
            splashProgressValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            splashProgressValue.Location = new Point(860, 486);
            splashProgressValue.Name = "splashProgressValue";
            splashProgressValue.Size = new Size(31, 20);
            splashProgressValue.TabIndex = 4;
            splashProgressValue.Text = "0%";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(932, 533);
            Controls.Add(splashProgressValue);
            Controls.Add(splashProgressBar);
            Controls.Add(spashVersionLabel);
            Controls.Add(poweredByText);
            Controls.Add(splashLabel);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Splash";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = SystemColors.Desktop;
            Load += Splash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label splashLabel;
        private Label poweredByText;
        private Label spashVersionLabel;
        private System.Windows.Forms.Timer splashTimer;
        private ProgressBar splashProgressBar;
        private Label splashProgressValue;
    }
}