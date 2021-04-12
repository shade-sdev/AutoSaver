using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaver
{
    public partial class directoryHead : UserControl
    {
        public directoryHead()
        {
            InitializeComponent();
        }

        public Guna.UI.WinForms.GunaPictureBox picBox
        {
            get
            {
                return direcPicBox;
            }

            set
            {
                direcPicBox = value;
            }
        }

        public Guna.UI.WinForms.GunaAdvenceButton buttonSwap
        {
            get { return btnSwap; }
            set { btnSwap = value; }
        }

        public Guna.UI.WinForms.GunaAdvenceButton buttonDel
        {
            get { return btnDelete; }
            set { btnDelete = value; }
        }

        public Label lblDirectoryName
        {
            get { return lblDateTime; }
            set { lblDateTime.Text = value.Text; }
        }
    }
}
