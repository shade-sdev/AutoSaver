namespace AutoSaver
{
    partial class directoryHead
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(directoryHead));
            this.direcPicBox = new Guna.UI.WinForms.GunaPictureBox();
            this.lblDateTime = new Guna.UI.WinForms.GunaLabel();
            this.Seperator = new Guna.UI.WinForms.GunaSeparator();
            this.btnSwap = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.direcPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // direcPicBox
            // 
            this.direcPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("direcPicBox.BackgroundImage")));
            this.direcPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.direcPicBox.BaseColor = System.Drawing.Color.White;
            this.direcPicBox.Location = new System.Drawing.Point(10, 7);
            this.direcPicBox.Name = "direcPicBox";
            this.direcPicBox.Size = new System.Drawing.Size(30, 30);
            this.direcPicBox.TabIndex = 0;
            this.direcPicBox.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateTime.Location = new System.Drawing.Point(47, 13);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(96, 17);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Date and Time";
            // 
            // Seperator
            // 
            this.Seperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Seperator.Location = new System.Drawing.Point(0, 39);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(403, 10);
            this.Seperator.TabIndex = 2;
            // 
            // btnSwap
            // 
            this.btnSwap.AnimationHoverSpeed = 0.07F;
            this.btnSwap.AnimationSpeed = 0.03F;
            this.btnSwap.BackColor = System.Drawing.Color.Transparent;
            this.btnSwap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.btnSwap.BorderColor = System.Drawing.Color.Black;
            this.btnSwap.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSwap.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSwap.CheckedForeColor = System.Drawing.Color.White;
            this.btnSwap.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSwap.CheckedImage")));
            this.btnSwap.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSwap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwap.FocusedColor = System.Drawing.Color.Empty;
            this.btnSwap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwap.ForeColor = System.Drawing.Color.White;
            this.btnSwap.Image = ((System.Drawing.Image)(resources.GetObject("btnSwap.Image")));
            this.btnSwap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSwap.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSwap.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSwap.Location = new System.Drawing.Point(315, 7);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSwap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSwap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSwap.OnHoverImage = null;
            this.btnSwap.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSwap.OnPressedColor = System.Drawing.Color.Black;
            this.btnSwap.Radius = 2;
            this.btnSwap.Size = new System.Drawing.Size(30, 30);
            this.btnSwap.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(351, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 2;
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 4;
            // 
            // directoryHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.direcPicBox);
            this.Name = "directoryHead";
            this.Size = new System.Drawing.Size(395, 45);
            ((System.ComponentModel.ISupportInitialize)(this.direcPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox direcPicBox;
        private Guna.UI.WinForms.GunaLabel lblDateTime;
        private Guna.UI.WinForms.GunaSeparator Seperator;
        private Guna.UI.WinForms.GunaAdvenceButton btnSwap;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
    }
}
