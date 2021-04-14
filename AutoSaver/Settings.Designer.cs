namespace AutoSaver
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.navbarPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.cbClose = new Guna.UI.WinForms.GunaControlBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnSubmit = new Guna.UI.WinForms.GunaButton();
            this.btnBrowseSettingPath = new Guna.UI.WinForms.GunaButton();
            this.lblSettingPath = new Guna.UI.WinForms.GunaLabel();
            this.txtSettingPath = new Guna.UI.WinForms.GunaTextBox();
            this.startupSwitch = new Guna.UI.WinForms.GunaWinSwitch();
            this.lblStartup = new Guna.UI.WinForms.GunaLabel();
            this.lblClientId = new Guna.UI.WinForms.GunaLabel();
            this.txtClientID = new Guna.UI.WinForms.GunaTextBox();
            this.lblSecret = new Guna.UI.WinForms.GunaLabel();
            this.txtSecret = new Guna.UI.WinForms.GunaTextBox();
            this.lblAccessToken = new Guna.UI.WinForms.GunaLabel();
            this.txtAccessToken = new Guna.UI.WinForms.GunaTextBox();
            this.btnGetAccessToken = new Guna.UI.WinForms.GunaButton();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.navbarPanel.Controls.Add(this.gunaControlBox1);
            this.navbarPanel.Controls.Add(this.cbClose);
            this.navbarPanel.Controls.Add(this.lblTitle);
            this.navbarPanel.Location = new System.Drawing.Point(0, 1);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(627, 41);
            this.navbarPanel.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(535, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 41);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.AnimationHoverSpeed = 0.07F;
            this.cbClose.AnimationSpeed = 0.03F;
            this.cbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.IconSize = 15F;
            this.cbClose.Location = new System.Drawing.Point(582, 0);
            this.cbClose.Name = "cbClose";
            this.cbClose.OnHoverBackColor = System.Drawing.Color.Black;
            this.cbClose.OnHoverIconColor = System.Drawing.Color.DarkRed;
            this.cbClose.OnPressedColor = System.Drawing.Color.DarkRed;
            this.cbClose.Size = new System.Drawing.Size(45, 41);
            this.cbClose.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(11, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AnimationHoverSpeed = 0.07F;
            this.btnSubmit.AnimationSpeed = 0.03F;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSubmit.Location = new System.Drawing.Point(237, 447);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Radius = 2;
            this.btnSubmit.Size = new System.Drawing.Size(139, 30);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBrowseSettingPath
            // 
            this.btnBrowseSettingPath.AnimationHoverSpeed = 0.07F;
            this.btnBrowseSettingPath.AnimationSpeed = 0.03F;
            this.btnBrowseSettingPath.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSettingPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnBrowseSettingPath.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseSettingPath.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowseSettingPath.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowseSettingPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseSettingPath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseSettingPath.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseSettingPath.Image")));
            this.btnBrowseSettingPath.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowseSettingPath.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBrowseSettingPath.Location = new System.Drawing.Point(540, 104);
            this.btnBrowseSettingPath.Name = "btnBrowseSettingPath";
            this.btnBrowseSettingPath.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnBrowseSettingPath.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowseSettingPath.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowseSettingPath.OnHoverImage = null;
            this.btnBrowseSettingPath.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowseSettingPath.Radius = 2;
            this.btnBrowseSettingPath.Size = new System.Drawing.Size(62, 30);
            this.btnBrowseSettingPath.TabIndex = 15;
            this.btnBrowseSettingPath.Click += new System.EventHandler(this.btnBrowseSettingPath_Click);
            // 
            // lblSettingPath
            // 
            this.lblSettingPath.AutoSize = true;
            this.lblSettingPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingPath.ForeColor = System.Drawing.Color.White;
            this.lblSettingPath.Location = new System.Drawing.Point(24, 83);
            this.lblSettingPath.Name = "lblSettingPath";
            this.lblSettingPath.Size = new System.Drawing.Size(72, 15);
            this.lblSettingPath.TabIndex = 14;
            this.lblSettingPath.Text = "Setting Path";
            // 
            // txtSettingPath
            // 
            this.txtSettingPath.BackColor = System.Drawing.Color.Transparent;
            this.txtSettingPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtSettingPath.BorderColor = System.Drawing.Color.Silver;
            this.txtSettingPath.BorderSize = 0;
            this.txtSettingPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSettingPath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSettingPath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSettingPath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSettingPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSettingPath.ForeColor = System.Drawing.Color.White;
            this.txtSettingPath.Location = new System.Drawing.Point(25, 104);
            this.txtSettingPath.Name = "txtSettingPath";
            this.txtSettingPath.PasswordChar = '\0';
            this.txtSettingPath.Radius = 2;
            this.txtSettingPath.SelectedText = "";
            this.txtSettingPath.Size = new System.Drawing.Size(504, 30);
            this.txtSettingPath.TabIndex = 13;
            // 
            // startupSwitch
            // 
            this.startupSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.startupSwitch.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.startupSwitch.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startupSwitch.FillColor = System.Drawing.Color.White;
            this.startupSwitch.Location = new System.Drawing.Point(153, 390);
            this.startupSwitch.Name = "startupSwitch";
            this.startupSwitch.Size = new System.Drawing.Size(40, 22);
            this.startupSwitch.TabIndex = 17;
            // 
            // lblStartup
            // 
            this.lblStartup.AutoSize = true;
            this.lblStartup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartup.ForeColor = System.Drawing.Color.White;
            this.lblStartup.Location = new System.Drawing.Point(26, 390);
            this.lblStartup.Name = "lblStartup";
            this.lblStartup.Size = new System.Drawing.Size(100, 17);
            this.lblStartup.TabIndex = 18;
            this.lblStartup.Text = "Run on startup";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.ForeColor = System.Drawing.Color.White;
            this.lblClientId.Location = new System.Drawing.Point(24, 157);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(53, 15);
            this.lblClientId.TabIndex = 20;
            this.lblClientId.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.Transparent;
            this.txtClientID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtClientID.BorderColor = System.Drawing.Color.Silver;
            this.txtClientID.BorderSize = 0;
            this.txtClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClientID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtClientID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClientID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClientID.ForeColor = System.Drawing.Color.White;
            this.txtClientID.Location = new System.Drawing.Point(25, 175);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.PasswordChar = '\0';
            this.txtClientID.Radius = 2;
            this.txtClientID.SelectedText = "";
            this.txtClientID.Size = new System.Drawing.Size(577, 30);
            this.txtClientID.TabIndex = 19;
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecret.ForeColor = System.Drawing.Color.White;
            this.lblSecret.Location = new System.Drawing.Point(24, 234);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(40, 15);
            this.lblSecret.TabIndex = 22;
            this.lblSecret.Text = "Secret";
            // 
            // txtSecret
            // 
            this.txtSecret.BackColor = System.Drawing.Color.Transparent;
            this.txtSecret.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtSecret.BorderColor = System.Drawing.Color.Silver;
            this.txtSecret.BorderSize = 0;
            this.txtSecret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecret.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSecret.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSecret.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSecret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecret.ForeColor = System.Drawing.Color.White;
            this.txtSecret.Location = new System.Drawing.Point(25, 252);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.PasswordChar = '\0';
            this.txtSecret.Radius = 2;
            this.txtSecret.SelectedText = "";
            this.txtSecret.Size = new System.Drawing.Size(504, 30);
            this.txtSecret.TabIndex = 21;
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.AutoSize = true;
            this.lblAccessToken.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessToken.ForeColor = System.Drawing.Color.White;
            this.lblAccessToken.Location = new System.Drawing.Point(24, 312);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(78, 15);
            this.lblAccessToken.TabIndex = 24;
            this.lblAccessToken.Text = "Access Token";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.BackColor = System.Drawing.Color.Transparent;
            this.txtAccessToken.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtAccessToken.BorderColor = System.Drawing.Color.Silver;
            this.txtAccessToken.BorderSize = 0;
            this.txtAccessToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccessToken.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAccessToken.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAccessToken.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccessToken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccessToken.ForeColor = System.Drawing.Color.White;
            this.txtAccessToken.Location = new System.Drawing.Point(25, 330);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.PasswordChar = '\0';
            this.txtAccessToken.Radius = 2;
            this.txtAccessToken.SelectedText = "";
            this.txtAccessToken.Size = new System.Drawing.Size(577, 30);
            this.txtAccessToken.TabIndex = 23;
            // 
            // btnGetAccessToken
            // 
            this.btnGetAccessToken.AnimationHoverSpeed = 0.07F;
            this.btnGetAccessToken.AnimationSpeed = 0.03F;
            this.btnGetAccessToken.BackColor = System.Drawing.Color.Transparent;
            this.btnGetAccessToken.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnGetAccessToken.BorderColor = System.Drawing.Color.Black;
            this.btnGetAccessToken.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGetAccessToken.FocusedColor = System.Drawing.Color.Empty;
            this.btnGetAccessToken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetAccessToken.ForeColor = System.Drawing.Color.White;
            this.btnGetAccessToken.Image = ((System.Drawing.Image)(resources.GetObject("btnGetAccessToken.Image")));
            this.btnGetAccessToken.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGetAccessToken.ImageSize = new System.Drawing.Size(15, 15);
            this.btnGetAccessToken.Location = new System.Drawing.Point(540, 252);
            this.btnGetAccessToken.Name = "btnGetAccessToken";
            this.btnGetAccessToken.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnGetAccessToken.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGetAccessToken.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGetAccessToken.OnHoverImage = null;
            this.btnGetAccessToken.OnPressedColor = System.Drawing.Color.Black;
            this.btnGetAccessToken.Radius = 2;
            this.btnGetAccessToken.Size = new System.Drawing.Size(62, 30);
            this.btnGetAccessToken.TabIndex = 25;
            this.btnGetAccessToken.Click += new System.EventHandler(this.btnGetAccessToken_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(628, 522);
            this.Controls.Add(this.btnGetAccessToken);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblStartup);
            this.Controls.Add(this.startupSwitch);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowseSettingPath);
            this.Controls.Add(this.lblSettingPath);
            this.Controls.Add(this.txtSettingPath);
            this.Controls.Add(this.navbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel navbarPanel;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox cbClose;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaButton btnSubmit;
        private Guna.UI.WinForms.GunaButton btnBrowseSettingPath;
        private Guna.UI.WinForms.GunaLabel lblSettingPath;
        private Guna.UI.WinForms.GunaTextBox txtSettingPath;
        private Guna.UI.WinForms.GunaWinSwitch startupSwitch;
        private Guna.UI.WinForms.GunaLabel lblStartup;
        private Guna.UI.WinForms.GunaLabel lblAccessToken;
        private Guna.UI.WinForms.GunaTextBox txtAccessToken;
        private Guna.UI.WinForms.GunaLabel lblSecret;
        private Guna.UI.WinForms.GunaTextBox txtSecret;
        private Guna.UI.WinForms.GunaLabel lblClientId;
        private Guna.UI.WinForms.GunaTextBox txtClientID;
        private Guna.UI.WinForms.GunaButton btnGetAccessToken;
    }
}