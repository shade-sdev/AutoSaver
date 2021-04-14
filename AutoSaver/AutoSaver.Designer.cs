namespace AutoSaver
{
    partial class AutoSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoSaver));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.savesPanel = new Guna.UI.WinForms.GunaPanel();
            this.flpSub = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSettings = new Guna.UI.WinForms.GunaButton();
            this.gamePanel = new Guna.UI.WinForms.GunaPanel();
            this.btnManualBackup = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.cbClose = new Guna.UI.WinForms.GunaControlBox();
            this.btnDel = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lblAllGames = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl4 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl5 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.saveNotifyer = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.savesPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // savesPanel
            // 
            this.savesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.savesPanel.Controls.Add(this.flpSub);
            this.savesPanel.Controls.Add(this.btnSettings);
            this.savesPanel.Location = new System.Drawing.Point(0, 0);
            this.savesPanel.Name = "savesPanel";
            this.savesPanel.Size = new System.Drawing.Size(396, 750);
            this.savesPanel.TabIndex = 0;
            // 
            // flpSub
            // 
            this.flpSub.AutoScroll = true;
            this.flpSub.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSub.Location = new System.Drawing.Point(-2, 122);
            this.flpSub.Margin = new System.Windows.Forms.Padding(0);
            this.flpSub.Name = "flpSub";
            this.flpSub.Size = new System.Drawing.Size(445, 570);
            this.flpSub.TabIndex = 1;
            this.flpSub.WrapContents = false;
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.btnSettings.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSettings.Location = new System.Drawing.Point(24, 706);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSettings.OnHoverImage = null;
            this.btnSettings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.btnSettings.Size = new System.Drawing.Size(350, 28);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.gamePanel.Controls.Add(this.btnManualBackup);
            this.gamePanel.Controls.Add(this.gunaControlBox1);
            this.gamePanel.Controls.Add(this.cbClose);
            this.gamePanel.Controls.Add(this.btnDel);
            this.gamePanel.Controls.Add(this.btnEdit);
            this.gamePanel.Controls.Add(this.btnAdd);
            this.gamePanel.Controls.Add(this.flpMain);
            this.gamePanel.Controls.Add(this.txtSearch);
            this.gamePanel.Controls.Add(this.lblAllGames);
            this.gamePanel.Location = new System.Drawing.Point(396, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(804, 750);
            this.gamePanel.TabIndex = 1;
            // 
            // btnManualBackup
            // 
            this.btnManualBackup.AnimationHoverSpeed = 0.07F;
            this.btnManualBackup.AnimationSpeed = 0.03F;
            this.btnManualBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnManualBackup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.btnManualBackup.BorderColor = System.Drawing.Color.Black;
            this.btnManualBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManualBackup.FocusedColor = System.Drawing.Color.Empty;
            this.btnManualBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManualBackup.ForeColor = System.Drawing.Color.White;
            this.btnManualBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnManualBackup.Image")));
            this.btnManualBackup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManualBackup.ImageSize = new System.Drawing.Size(25, 25);
            this.btnManualBackup.Location = new System.Drawing.Point(489, 63);
            this.btnManualBackup.Name = "btnManualBackup";
            this.btnManualBackup.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnManualBackup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManualBackup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnManualBackup.OnHoverImage = null;
            this.btnManualBackup.OnPressedColor = System.Drawing.Color.Black;
            this.btnManualBackup.Radius = 2;
            this.btnManualBackup.Size = new System.Drawing.Size(38, 30);
            this.btnManualBackup.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnManualBackup, "Manual save backup.");
            this.btnManualBackup.Click += new System.EventHandler(this.btnManualBackup_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(714, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 41);
            this.gunaControlBox1.TabIndex = 6;
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.AnimationHoverSpeed = 0.07F;
            this.cbClose.AnimationSpeed = 0.03F;
            this.cbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.IconSize = 15F;
            this.cbClose.Location = new System.Drawing.Point(759, 0);
            this.cbClose.Name = "cbClose";
            this.cbClose.OnHoverBackColor = System.Drawing.Color.Black;
            this.cbClose.OnHoverIconColor = System.Drawing.Color.DarkRed;
            this.cbClose.OnPressedColor = System.Drawing.Color.DarkRed;
            this.cbClose.Size = new System.Drawing.Size(45, 41);
            this.cbClose.TabIndex = 5;
            // 
            // btnDel
            // 
            this.btnDel.AnimationHoverSpeed = 0.07F;
            this.btnDel.AnimationSpeed = 0.03F;
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.btnDel.BorderColor = System.Drawing.Color.Black;
            this.btnDel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDel.FocusedColor = System.Drawing.Color.Empty;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDel.Location = new System.Drawing.Point(445, 63);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDel.OnHoverImage = null;
            this.btnDel.OnPressedColor = System.Drawing.Color.Black;
            this.btnDel.Radius = 2;
            this.btnDel.Size = new System.Drawing.Size(38, 30);
            this.btnDel.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnDel, "Delete game.");
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEdit.Location = new System.Drawing.Point(401, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 2;
            this.btnEdit.Size = new System.Drawing.Size(38, 30);
            this.btnEdit.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnEdit, "Edit game.");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(357, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 2;
            this.btnAdd.Size = new System.Drawing.Size(38, 30);
            this.btnAdd.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnAdd, "Add game.");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Location = new System.Drawing.Point(1, 107);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(827, 640);
            this.flpMain.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.txtSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearch.Location = new System.Drawing.Point(547, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 5;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(216, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search..";
            this.toolTip.SetToolTip(this.txtSearch, "Type to Search.");
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblAllGames
            // 
            this.lblAllGames.AutoSize = true;
            this.lblAllGames.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllGames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllGames.Location = new System.Drawing.Point(33, 63);
            this.lblAllGames.Name = "lblAllGames";
            this.lblAllGames.Size = new System.Drawing.Size(106, 30);
            this.lblAllGames.TabIndex = 0;
            this.lblAllGames.Text = "All Games";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gamePanel;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.savesPanel;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this;
            // 
            // gunaDragControl4
            // 
            this.gunaDragControl4.TargetControl = this.flpMain;
            // 
            // gunaDragControl5
            // 
            this.gunaDragControl5.TargetControl = this.flpSub;
            // 
            // saveNotifyer
            // 
            this.saveNotifyer.Icon = ((System.Drawing.Icon)(resources.GetObject("saveNotifyer.Icon")));
            this.saveNotifyer.Text = "AutoSaver";
            this.saveNotifyer.Visible = true;
            this.saveNotifyer.BalloonTipClicked += new System.EventHandler(this.saveNotifyer_BalloonTipClicked);
            this.saveNotifyer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.saveNotifyer_MouseDoubleClick);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "AutoSaver";
            // 
            // AutoSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.savesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoSaver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoSaver";
            this.Load += new System.EventHandler(this.AutoSaver_Load);
            this.Resize += new System.EventHandler(this.AutoSaver_Resize);
            this.savesPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel savesPanel;
        private Guna.UI.WinForms.GunaPanel gamePanel;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        public System.Windows.Forms.FlowLayoutPanel flpMain;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel lblAllGames;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnDel;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnSettings;
        private System.Windows.Forms.FlowLayoutPanel flpSub;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox cbClose;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl4;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl5;
        private System.Windows.Forms.NotifyIcon saveNotifyer;
        private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI.WinForms.GunaButton btnManualBackup;
    }
}

