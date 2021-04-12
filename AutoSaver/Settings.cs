using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaver
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnBrowseSettingPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            oFD.FileName = "Don't Select any file.";
            oFD.CheckPathExists = true;
            oFD.ShowReadOnly = false;
            oFD.ReadOnlyChecked = true;
            oFD.CheckFileExists = false;
            oFD.ValidateNames = false;

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                txtSettingPath.Text = oFD.FileName;
                int index = txtSettingPath.Text.LastIndexOf(@"\");
                txtSettingPath.Text = txtSettingPath.Text.Substring(0, index);
               
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(txtSettingPath.Text))
            {
                misc.setAutoSaverPath("AutoSaver.ini", 0, txtSettingPath.Text);
                if (startupSwitch.Checked == true)
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).SetValue(Application.ProductName, Application.ExecutablePath);
                } else
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue(Application.ProductName);
                }
                Application.Restart();
            } else
            {
                MessageBox.Show(constants.pathdoesnotexist);
            }
           

        }

        private void Settings_Load(object sender, EventArgs e)
        {
             txtSettingPath.Text = misc.getAutoSaverPath("AutoSaver.ini", 0, 0);
        }


    }
}
