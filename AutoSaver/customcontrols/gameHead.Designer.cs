namespace AutoSaver
{
    partial class gameHead
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.GamePicBox = new Guna.UI.WinForms.GunaPictureBox();
            this.panelSlave = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GamePicBox)).BeginInit();
            this.panelSlave.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // GamePicBox
            // 
            this.GamePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GamePicBox.BaseColor = System.Drawing.Color.White;
            this.GamePicBox.ImageLocation = "";
            this.GamePicBox.Location = new System.Drawing.Point(6, 6);
            this.GamePicBox.Name = "GamePicBox";
            this.GamePicBox.Size = new System.Drawing.Size(145, 215);
            this.GamePicBox.TabIndex = 0;
            this.GamePicBox.TabStop = false;
            // 
            // panelSlave
            // 
            this.panelSlave.BackColor = System.Drawing.Color.Transparent;
            this.panelSlave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panelSlave.Controls.Add(this.GamePicBox);
            this.panelSlave.Location = new System.Drawing.Point(2, 2);
            this.panelSlave.Name = "panelSlave";
            this.panelSlave.Size = new System.Drawing.Size(155, 225);
            this.panelSlave.TabIndex = 1;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 6;
            this.gunaElipse2.TargetControl = this.GamePicBox;
            // 
            // gameHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelSlave);
            this.Name = "gameHead";
            this.Size = new System.Drawing.Size(160, 230);
            ((System.ComponentModel.ISupportInitialize)(this.GamePicBox)).EndInit();
            this.panelSlave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel panelSlave;
        private Guna.UI.WinForms.GunaPictureBox GamePicBox;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}
