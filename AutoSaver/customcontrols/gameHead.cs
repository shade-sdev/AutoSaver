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
    public partial class gameHead : UserControl
    {
        public gameHead()
        {
            InitializeComponent();
        }

        public System.Drawing.Color colorBG{
            get { return panelSlave.BackColor; }

            set {

                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            }

           }


        public System.Drawing.Color colorSelect
        {
            get { return panelSlave.BackColor; }

            set
            {

                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            }

        }



        public Guna.UI.WinForms.GunaPictureBox picBox
        {
            get
            {
                return GamePicBox;
            }

            set
            {
                GamePicBox = value;
            }
        }

    


    }
}
