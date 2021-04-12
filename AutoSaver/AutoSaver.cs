using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Management;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace AutoSaver
{
    public partial class AutoSaver : Form
    {
        private readonly database db = new database();
        private string currentGame = string.Empty;
        public delegate void gamesDelegate();
        public delegate void savesDelegate(string currentGame);

        public AutoSaver()
        {
            InitializeComponent();
        }

        private void AutoSaver_Load(object sender, EventArgs e)
        {

            flpMain.Padding = new Padding(13, 0, 13, 0);

            loadGamesFunc();
            WaitForProcess();
          
        }

        public void loadGamesThread()
        {
            this.Invoke(new gamesDelegate(loadGames));
        }

       public Thread loadSavesThread(string currentGame)
        {
            var t = new Thread(() => loadSavesFunc(currentGame));
            t.Start();
            return t;
        }

        void loadSavesFunc(string currentGame)
        {
            if (InvokeRequired)
            {
                Invoke(new savesDelegate(loadSavesFunc), currentGame);
                return;
            }

            loadSaves(currentGame);

        }

        void loadGamesFunc()
        {
            Thread thread = new Thread(loadGamesThread);
            thread.Start();
        }


        void WaitForProcess()
        {

            ManagementEventWatcher endWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 1 WHERE TargetInstance ISA 'Win32_Process'"));
            endWatch.EventArrived += new EventArrivedEventHandler(endWatch_EventArrived);
            endWatch.Start();

        }


        private void endWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            var targetInstance = (ManagementBaseObject)e.NewEvent["TargetInstance"];

            ArrayList gameList = db.getDataFromDatabase("SELECT * FROM games");

            foreach (DataRow item in gameList)
            {

                string game = item[3].ToString();
                int index = game.LastIndexOf(@"\");
                game = game.Substring(index + 1);
                if (game.Equals(targetInstance["Name"]?.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    


                    string dest = constants.autosaverpath + @"\" + item[1].ToString() + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    DirectoryInfo di = Directory.CreateDirectory(dest);

                    string root = item[4].ToString();

                    misc.CloneDirectory(root, dest);

                    List<KeyValuePair<string, string>> save = new List<KeyValuePair<string, string>>();
                    List<Saves> saveObject = new List<Saves>
            {
                new Saves() {game_id = item[0].ToString(), path = dest, datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm")}
            };

                    foreach (var data in saveObject)
                    {

                        save.Clear();
                        foreach (var savedata in data.GetType().GetProperties())
                        {
                            save.Add(new KeyValuePair<string, string>(savedata.Name, savedata.GetValue(data).ToString()));
                        }
                    }

                    db.insertToDatabase(save, "saves");
                    saveNotifyer.Tag = dest;
                    saveNotifyer.ShowBalloonTip(1, "AutoSaver", game + " save backup!", ToolTipIcon.Info);

                }

            }

        }

        private void loadGames()
        {

            misc.clearFlp<gameHead>(flpMain);

            ArrayList gameList = db.getDataFromDatabase("SELECT * FROM games");

            foreach (DataRow item in gameList)
            {
                gameHead gh = new gameHead();
                gh.Margin = new Padding(20, 10, 10, 20);
                gh.Name = item[0].ToString();
                gh.picBox.Name = item[0].ToString();
                gh.picBox.Click += new EventHandler(gh_click);
                gh.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                gh.picBox.ImageLocation = item[2].ToString();
                flpMain.Controls.Add(gh);

                if(gh.Name == currentGame)
                {
                    gh.colorSelect = Color.Red;
                };
            
            }
        
        }

        private void loadSaves(string currentGame)
        {
            ArrayList saveList = db.getDataFromDatabase("SELECT * FROM saves WHERE game_id = " + currentGame + " ORDER BY Id DESC");

            foreach (DataRow item in saveList)
            {
                directoryHead dHead = new directoryHead();
                dHead.Click += new EventHandler(dHead_click);
                dHead.Margin = new Padding(0, 0, 0, 0);
                dHead.Name = item[2].ToString();
                dHead.buttonSwap.Name = item[2].ToString();
                dHead.buttonDel.Name = item[2].ToString();
                dHead.buttonSwap.Tag = item[1].ToString();
                dHead.buttonDel.Tag = item[0].ToString();
                dHead.buttonSwap.Click += new EventHandler(dHead_swapClick);
                dHead.buttonDel.Click += new EventHandler(dHead_delClick);
                dHead.lblDirectoryName.Name = item[2].ToString();
                dHead.lblDirectoryName.Text = item[3].ToString();
                flpSub.Controls.Add(dHead);

            }
        }

        private void gh_click(object sender, EventArgs e)

        {
            resetSelectColors();
            misc.clearFlp<directoryHead>(flpSub);
           
            var gameHead = (Guna.UI.WinForms.GunaPictureBox)sender;

            foreach(gameHead gh in flpMain.Controls)
            {
                if(gh.Name == gameHead.Name)
                {
                    gh.colorSelect = Color.Red;
                }
            }
            
            currentGame = gameHead.Name.ToString();
            loadSavesThread(currentGame);

        }

        private void dHead_delClick(object sender, EventArgs e)
        {
            var btnDel = (Guna.UI.WinForms.GunaAdvenceButton)sender;



            DialogResult delDialog = MessageBox.Show("Are you sure?", "Delete Save", MessageBoxButtons.YesNo);

            if (delDialog == DialogResult.Yes)
            {
                db.deleteFromDatabase("saves", int.Parse(btnDel.Tag.ToString()));
                Directory.Delete(btnDel.Name.ToString(), true);
                misc.clearFlp<directoryHead>(flpSub);
                
                loadSavesThread(currentGame);
            }
            else
                if (delDialog == DialogResult.No)
            {
                
            }

           
        }

    

        private void dHead_swapClick(object sender, EventArgs e)
        {
            string savepath = string.Empty;
            var btnSwap = (Guna.UI.WinForms.GunaAdvenceButton)sender;
            

            ArrayList gameList = db.getDataFromDatabase("SELECT savepath FROM games WHERE Id = " + btnSwap.Tag.ToString());
            foreach (DataRow item in gameList)
            {
                savepath = item[0].ToString();

            }

            misc.CloneDirectory(btnSwap.Name.ToString(), savepath);

        }

        private void dHead_click(object sender, EventArgs e)
        {

            var dHead = (directoryHead)sender;
            Process.Start(dHead.Name);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
               
            }
        }

        public void resetSelectColors()
        {
            foreach (gameHead item in flpMain.Controls)
            {
                item.colorBG = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            addGame.setOperationType(1);
            addGame.ShowDialog();
            loadGamesFunc();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (currentGame != string.Empty) {
           
                AddGame addGame = new AddGame();
                addGame.setCurrentGame(int.Parse(currentGame));
                addGame.setOperationType(2);
                addGame.ShowDialog();
                loadGamesFunc();
           
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentGame != string.Empty)
            {
                DialogResult delDialog = MessageBox.Show("Are you sure?", "Delete Save", MessageBoxButtons.YesNo);

            if (delDialog == DialogResult.Yes)
            {
             
                    db.deleteFromDatabase("games", int.Parse(currentGame));
                    loadGamesFunc();
                    misc.clearFlp<AutoSaver>(flpSub);
                    currentGame = string.Empty;
            }
            else
                if (delDialog == DialogResult.No)
            {

            }
            }

        }

        private void saveNotifyer_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start(saveNotifyer.Tag.ToString());
        }

        private void AutoSaver_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                saveNotifyer.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void saveNotifyer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            saveNotifyer.Visible = false;
        }
    }

}


//ManagementEventWatcher startWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 1 WHERE TargetInstance ISA 'Win32_Process'"));
//startWatch.EventArrived += new EventArrivedEventHandler(startWatch_EventArrived);
//startWatch.Start();


//private void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
//{
//    var targetInstance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
//   // Console.WriteLine("Process started: " + targetInstance["Name"]?.ToString());

//    ArrayList gameList = db.getDataFromDatabase("SELECT * FROM games");

//    foreach (DataRow item in gameList)
//    {

//        string game = item[3].ToString();
//        int index = game.LastIndexOf(@"\");
//        game = game.Substring(index + 1);
//        if (game.Equals(targetInstance["Name"]?.ToString(), StringComparison.OrdinalIgnoreCase))
//        {
//            MessageBox.Show("Process Started " + game);

//        }

//    }

//}