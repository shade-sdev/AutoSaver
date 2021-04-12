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
            this.btnSubmit.Location = new System.Drawing.Point(277, 215);
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
            this.btnBrowseSettingPath.Location = new System.Drawing.Point(204, 215);
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
            this.lblSettingPath.Location = new System.Drawing.Point(24, 129);
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
            this.txtSettingPath.Location = new System.Drawing.Point(25, 150);
            this.txtSettingPath.Name = "txtSettingPath";
            this.txtSettingPath.PasswordChar = '\0';
            this.txtSettingPath.Radius = 2;
            this.txtSettingPath.SelectedText = "";
            this.txtSettingPath.Size = new System.Drawing.Size(577, 30);
            this.txtSettingPath.TabIndex = 13;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(628, 324);
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
    }
}