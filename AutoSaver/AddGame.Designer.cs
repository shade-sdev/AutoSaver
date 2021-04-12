namespace AutoSaver
{
    partial class AddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.navbarPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.cbClose = new Guna.UI.WinForms.GunaControlBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.txtGameName = new Guna.UI.WinForms.GunaTextBox();
            this.lblGameName = new Guna.UI.WinForms.GunaLabel();
            this.btnSearchGame = new Guna.UI.WinForms.GunaButton();
            this.btnBrowseGamePath = new Guna.UI.WinForms.GunaButton();
            this.lblGamePath = new Guna.UI.WinForms.GunaLabel();
            this.txtGamePath = new Guna.UI.WinForms.GunaTextBox();
            this.lblGameCover = new Guna.UI.WinForms.GunaLabel();
            this.txtGameCoverUrl = new Guna.UI.WinForms.GunaTextBox();
            this.btnBrowseSaveFolder = new Guna.UI.WinForms.GunaButton();
            this.lblSaveFileLocation = new Guna.UI.WinForms.GunaLabel();
            this.txtSaveFileLocation = new Guna.UI.WinForms.GunaTextBox();
            this.btnSubmit = new Guna.UI.WinForms.GunaButton();
            this.txtDocuments = new Guna.UI.WinForms.GunaButton();
            this.txtAppData = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(800, 41);
            this.navbarPanel.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(708, 0);
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
            this.cbClose.Location = new System.Drawing.Point(755, 0);
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
            this.lblTitle.Size = new System.Drawing.Size(89, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Game";
            // 
            // txtGameName
            // 
            this.txtGameName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGameName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGameName.BackColor = System.Drawing.Color.Transparent;
            this.txtGameName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtGameName.BorderColor = System.Drawing.Color.Silver;
            this.txtGameName.BorderSize = 0;
            this.txtGameName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGameName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGameName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGameName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGameName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGameName.ForeColor = System.Drawing.Color.White;
            this.txtGameName.Location = new System.Drawing.Point(48, 139);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.PasswordChar = '\0';
            this.txtGameName.Radius = 2;
            this.txtGameName.SelectedText = "";
            this.txtGameName.Size = new System.Drawing.Size(294, 30);
            this.txtGameName.TabIndex = 1;
            this.txtGameName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGameName_KeyDown);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(47, 118);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(73, 15);
            this.lblGameName.TabIndex = 2;
            this.lblGameName.Text = "Game Name";
            this.toolTip.SetToolTip(this.lblGameName, "Enter Game Name");
            // 
            // btnSearchGame
            // 
            this.btnSearchGame.AnimationHoverSpeed = 0.07F;
            this.btnSearchGame.AnimationSpeed = 0.03F;
            this.btnSearchGame.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchGame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnSearchGame.BorderColor = System.Drawing.Color.Black;
            this.btnSearchGame.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchGame.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearchGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchGame.ForeColor = System.Drawing.Color.White;
            this.btnSearchGame.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchGame.Image")));
            this.btnSearchGame.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchGame.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearchGame.Location = new System.Drawing.Point(351, 139);
            this.btnSearchGame.Name = "btnSearchGame";
            this.btnSearchGame.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnSearchGame.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearchGame.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearchGame.OnHoverImage = null;
            this.btnSearchGame.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearchGame.Radius = 2;
            this.btnSearchGame.Size = new System.Drawing.Size(33, 30);
            this.btnSearchGame.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnSearchGame, "When this button is clicked, suggestions will be added to the Game Name textbox, " +
        "then you will get a google search like suggestion appearing when typing on the t" +
        "ext box.");
            this.btnSearchGame.Click += new System.EventHandler(this.btnSearchGame_Click);
            // 
            // btnBrowseGamePath
            // 
            this.btnBrowseGamePath.AnimationHoverSpeed = 0.07F;
            this.btnBrowseGamePath.AnimationSpeed = 0.03F;
            this.btnBrowseGamePath.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseGamePath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnBrowseGamePath.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseGamePath.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowseGamePath.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowseGamePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseGamePath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseGamePath.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseGamePath.Image")));
            this.btnBrowseGamePath.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowseGamePath.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowseGamePath.Location = new System.Drawing.Point(720, 139);
            this.btnBrowseGamePath.Name = "btnBrowseGamePath";
            this.btnBrowseGamePath.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnBrowseGamePath.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowseGamePath.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowseGamePath.OnHoverImage = null;
            this.btnBrowseGamePath.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowseGamePath.Radius = 2;
            this.btnBrowseGamePath.Size = new System.Drawing.Size(33, 30);
            this.btnBrowseGamePath.TabIndex = 6;
            this.btnBrowseGamePath.Click += new System.EventHandler(this.btnBrowseGamePath_Click);
            // 
            // lblGamePath
            // 
            this.lblGamePath.AutoSize = true;
            this.lblGamePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePath.ForeColor = System.Drawing.Color.White;
            this.lblGamePath.Location = new System.Drawing.Point(416, 118);
            this.lblGamePath.Name = "lblGamePath";
            this.lblGamePath.Size = new System.Drawing.Size(65, 15);
            this.lblGamePath.TabIndex = 5;
            this.lblGamePath.Text = "Game Path";
            this.toolTip.SetToolTip(this.lblGamePath, "Select game executable");
            // 
            // txtGamePath
            // 
            this.txtGamePath.BackColor = System.Drawing.Color.Transparent;
            this.txtGamePath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtGamePath.BorderColor = System.Drawing.Color.Silver;
            this.txtGamePath.BorderSize = 0;
            this.txtGamePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGamePath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGamePath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGamePath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGamePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGamePath.ForeColor = System.Drawing.Color.White;
            this.txtGamePath.Location = new System.Drawing.Point(417, 139);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.PasswordChar = '\0';
            this.txtGamePath.Radius = 2;
            this.txtGamePath.SelectedText = "";
            this.txtGamePath.Size = new System.Drawing.Size(294, 30);
            this.txtGamePath.TabIndex = 4;
            // 
            // lblGameCover
            // 
            this.lblGameCover.AutoSize = true;
            this.lblGameCover.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameCover.ForeColor = System.Drawing.Color.White;
            this.lblGameCover.Location = new System.Drawing.Point(49, 208);
            this.lblGameCover.Name = "lblGameCover";
            this.lblGameCover.Size = new System.Drawing.Size(89, 15);
            this.lblGameCover.TabIndex = 8;
            this.lblGameCover.Text = "Game Cover Url";
            this.toolTip.SetToolTip(this.lblGameCover, "Url to image file.");
            // 
            // txtGameCoverUrl
            // 
            this.txtGameCoverUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGameCoverUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGameCoverUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtGameCoverUrl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtGameCoverUrl.BorderColor = System.Drawing.Color.Silver;
            this.txtGameCoverUrl.BorderSize = 0;
            this.txtGameCoverUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGameCoverUrl.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGameCoverUrl.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGameCoverUrl.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGameCoverUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGameCoverUrl.ForeColor = System.Drawing.Color.White;
            this.txtGameCoverUrl.Location = new System.Drawing.Point(50, 229);
            this.txtGameCoverUrl.Name = "txtGameCoverUrl";
            this.txtGameCoverUrl.PasswordChar = '\0';
            this.txtGameCoverUrl.Radius = 2;
            this.txtGameCoverUrl.SelectedText = "";
            this.txtGameCoverUrl.Size = new System.Drawing.Size(334, 30);
            this.txtGameCoverUrl.TabIndex = 7;
            // 
            // btnBrowseSaveFolder
            // 
            this.btnBrowseSaveFolder.AnimationHoverSpeed = 0.07F;
            this.btnBrowseSaveFolder.AnimationSpeed = 0.03F;
            this.btnBrowseSaveFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSaveFolder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnBrowseSaveFolder.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseSaveFolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowseSaveFolder.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowseSaveFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseSaveFolder.ForeColor = System.Drawing.Color.White;
            this.btnBrowseSaveFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseSaveFolder.Image")));
            this.btnBrowseSaveFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowseSaveFolder.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowseSaveFolder.Location = new System.Drawing.Point(720, 229);
            this.btnBrowseSaveFolder.Name = "btnBrowseSaveFolder";
            this.btnBrowseSaveFolder.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnBrowseSaveFolder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowseSaveFolder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowseSaveFolder.OnHoverImage = null;
            this.btnBrowseSaveFolder.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowseSaveFolder.Radius = 2;
            this.btnBrowseSaveFolder.Size = new System.Drawing.Size(33, 30);
            this.btnBrowseSaveFolder.TabIndex = 11;
            this.btnBrowseSaveFolder.Click += new System.EventHandler(this.btnBrowseSaveFolder_Click);
            // 
            // lblSaveFileLocation
            // 
            this.lblSaveFileLocation.AutoSize = true;
            this.lblSaveFileLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFileLocation.ForeColor = System.Drawing.Color.White;
            this.lblSaveFileLocation.Location = new System.Drawing.Point(416, 208);
            this.lblSaveFileLocation.Name = "lblSaveFileLocation";
            this.lblSaveFileLocation.Size = new System.Drawing.Size(102, 15);
            this.lblSaveFileLocation.TabIndex = 10;
            this.lblSaveFileLocation.Text = "Save File Location";
            this.toolTip.SetToolTip(this.lblSaveFileLocation, "Select folder which contains save files.");
            // 
            // txtSaveFileLocation
            // 
            this.txtSaveFileLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtSaveFileLocation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtSaveFileLocation.BorderColor = System.Drawing.Color.Silver;
            this.txtSaveFileLocation.BorderSize = 0;
            this.txtSaveFileLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaveFileLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSaveFileLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSaveFileLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSaveFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSaveFileLocation.ForeColor = System.Drawing.Color.White;
            this.txtSaveFileLocation.Location = new System.Drawing.Point(417, 229);
            this.txtSaveFileLocation.Name = "txtSaveFileLocation";
            this.txtSaveFileLocation.PasswordChar = '\0';
            this.txtSaveFileLocation.Radius = 2;
            this.txtSaveFileLocation.SelectedText = "";
            this.txtSaveFileLocation.Size = new System.Drawing.Size(294, 30);
            this.txtSaveFileLocation.TabIndex = 9;
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
            this.btnSubmit.Location = new System.Drawing.Point(175, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Radius = 2;
            this.btnSubmit.Size = new System.Drawing.Size(139, 34);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDocuments
            // 
            this.txtDocuments.AnimationHoverSpeed = 0.07F;
            this.txtDocuments.AnimationSpeed = 0.03F;
            this.txtDocuments.BackColor = System.Drawing.Color.Transparent;
            this.txtDocuments.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtDocuments.BorderColor = System.Drawing.Color.Black;
            this.txtDocuments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtDocuments.FocusedColor = System.Drawing.Color.Empty;
            this.txtDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocuments.ForeColor = System.Drawing.Color.White;
            this.txtDocuments.Image = null;
            this.txtDocuments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocuments.ImageSize = new System.Drawing.Size(20, 20);
            this.txtDocuments.Location = new System.Drawing.Point(324, 323);
            this.txtDocuments.Name = "txtDocuments";
            this.txtDocuments.OnHoverBaseColor = System.Drawing.Color.Black;
            this.txtDocuments.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtDocuments.OnHoverForeColor = System.Drawing.Color.White;
            this.txtDocuments.OnHoverImage = null;
            this.txtDocuments.OnPressedColor = System.Drawing.Color.Black;
            this.txtDocuments.Radius = 2;
            this.txtDocuments.Size = new System.Drawing.Size(139, 34);
            this.txtDocuments.TabIndex = 13;
            this.txtDocuments.Text = "My Documents";
            this.txtDocuments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocuments.Click += new System.EventHandler(this.txtDocuments_Click);
            // 
            // txtAppData
            // 
            this.txtAppData.AnimationHoverSpeed = 0.07F;
            this.txtAppData.AnimationSpeed = 0.03F;
            this.txtAppData.BackColor = System.Drawing.Color.Transparent;
            this.txtAppData.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.txtAppData.BorderColor = System.Drawing.Color.Black;
            this.txtAppData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtAppData.FocusedColor = System.Drawing.Color.Empty;
            this.txtAppData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppData.ForeColor = System.Drawing.Color.White;
            this.txtAppData.Image = null;
            this.txtAppData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAppData.ImageSize = new System.Drawing.Size(20, 20);
            this.txtAppData.Location = new System.Drawing.Point(473, 323);
            this.txtAppData.Name = "txtAppData";
            this.txtAppData.OnHoverBaseColor = System.Drawing.Color.Black;
            this.txtAppData.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtAppData.OnHoverForeColor = System.Drawing.Color.White;
            this.txtAppData.OnHoverImage = null;
            this.txtAppData.OnPressedColor = System.Drawing.Color.Black;
            this.txtAppData.Radius = 2;
            this.txtAppData.Size = new System.Drawing.Size(139, 34);
            this.txtAppData.TabIndex = 14;
            this.txtAppData.Text = "APPDATA";
            this.txtAppData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAppData.Click += new System.EventHandler(this.txtAppData_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.navbarPanel;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "AutoSaver";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.txtAppData);
            this.Controls.Add(this.txtDocuments);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowseSaveFolder);
            this.Controls.Add(this.lblSaveFileLocation);
            this.Controls.Add(this.txtSaveFileLocation);
            this.Controls.Add(this.lblGameCover);
            this.Controls.Add(this.txtGameCoverUrl);
            this.Controls.Add(this.btnBrowseGamePath);
            this.Controls.Add(this.lblGamePath);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.btnSearchGame);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.navbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGame";
            this.Load += new System.EventHandler(this.AddGame_Load);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel navbarPanel;
        private Guna.UI.WinForms.GunaLabel lblGameName;
        private Guna.UI.WinForms.GunaTextBox txtGameName;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaButton btnSearchGame;
        private Guna.UI.WinForms.GunaButton btnBrowseGamePath;
        private Guna.UI.WinForms.GunaLabel lblGamePath;
        private Guna.UI.WinForms.GunaTextBox txtGamePath;
        private Guna.UI.WinForms.GunaControlBox cbClose;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel lblGameCover;
        private Guna.UI.WinForms.GunaTextBox txtGameCoverUrl;
        private Guna.UI.WinForms.GunaButton btnBrowseSaveFolder;
        private Guna.UI.WinForms.GunaLabel lblSaveFileLocation;
        private Guna.UI.WinForms.GunaTextBox txtSaveFileLocation;
        private Guna.UI.WinForms.GunaButton btnSubmit;
        private Guna.UI.WinForms.GunaButton txtAppData;
        private Guna.UI.WinForms.GunaButton txtDocuments;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}