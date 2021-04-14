using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AutoSaver
{
    public partial class AddGame : Form
    {
        private readonly database db = new database();
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        private int operationType = 0;
        private int currentGame = 0;

        public AddGame()
        {
            InitializeComponent();
        }

        private void btnBrowseGamePath_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".exe";
            ofd.Filter = "Executable (*.exe)|*.exe";
            ofd.ShowDialog();
            path = ofd.FileName;
            txtGamePath.Text = path;
        }

        private void btnSearchGame_Click(object sender, EventArgs e)
        {

            if (constants.clientId == string.Empty || constants.accessToken == string.Empty)
            {

            }else
            {

                autoComplete.Clear();

                igdb ig = new igdb();
                dynamic response = ig.getIgdbResponse("https://api.igdb.com/v4/games/", constants.clientId, constants.accessToken, "fields *; search \"" + txtGameName.Text + "\";");
                foreach (dynamic res in response)
                {
                    string game = res["name"] + "*" + res["id"];
                    autoComplete.Add(game);
                }

                MessageBox.Show("Results has been added to the textbox, press spacebar or clear and type again");
            }


        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            txtGameName.AutoCompleteCustomSource = autoComplete;
            if (operationType == 1)
            {
                setForAddGame();
            } else
                if (operationType == 2)
            {
                setForUpdateGame();
                ArrayList gameList = db.getDataFromDatabase("SELECT * FROM games WHERE id = " + currentGame);

           

                foreach (DataRow item in gameList)
                {
                    txtGameName.Text = item[1].ToString();
                    txtGameCoverUrl.Text = item[2].ToString();
                    txtGamePath.Text = item[3].ToString();
                    txtSaveFileLocation.Text = item[4].ToString();

                }
            }
        }

        private void txtGameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtGameName.AutoCompleteCustomSource.Contains(txtGameName.Text))
                {
                    int index = txtGameName.Text.LastIndexOf("*");
                    string gameid = txtGameName.Text.Substring((index + 1), (txtGameName.Text.Length - index - 1));
                    txtGameName.Text = txtGameName.Text.Substring(0, index);

                    igdb ig = new igdb();
                    dynamic response = ig.getIgdbResponse("https://api.igdb.com/v4/games/", constants.clientId, constants.accessToken, "fields *; where id = " + gameid + ";");
                    string coverid = response[0]["cover"];

                    dynamic response2 = ig.getIgdbResponse("https://api.igdb.com/v4/covers", constants.clientId, constants.accessToken, "fields *; where id =" + coverid + ";");
                    string imageurl = response2[0]["url"];
                    imageurl = "https:" + imageurl;
                    imageurl = imageurl.Replace("t_thumb", "t_cover_big");
                    txtGameCoverUrl.Text = imageurl;
                }
            }
        }

        private void btnBrowseSaveFolder_Click(object sender, EventArgs e)
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
                txtSaveFileLocation.Text = oFD.FileName;
                int index = txtSaveFileLocation.Text.LastIndexOf(@"\");
                txtSaveFileLocation.Text = txtSaveFileLocation.Text.Substring(0, index);
            }

           
        }

        private void txtDocuments_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void txtAppData_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var reg = new Regex("[^a-zA-Z 0-9-/-]");
            txtGameName.Text = Regex.Replace(txtGameName.Text, "[^a-zA-Z 0-9-/-]", " ");
            bool textError = false;
            bool pathError = false;
            bool fileError = false;
            bool imageError = false;
            bool urlError = true;

            textError = misc.checkIfEmpty(txtGameName.Text);
            textError = misc.checkIfEmpty(txtGamePath.Text);
            textError = misc.checkIfEmpty(txtSaveFileLocation.Text);
            textError = misc.checkIfEmpty(txtGameCoverUrl.Text);

            pathError = misc.checkIfPathExists(txtSaveFileLocation.Text);
            fileError = misc.checkIfFileExists(txtGamePath.Text);
            try
            {
                urlError = misc.validateUrl(txtGameCoverUrl.Text);
                imageError = misc.CheckImage(txtGameCoverUrl.Text);
            }
            catch
            {

            }

            if (textError == true)
            {
                MessageBox.Show(constants.fillallfields);
              
            } else
                if (pathError == true)
            {
                MessageBox.Show(constants.pathdoesnotexist);
            } else
            if (fileError == true)
            {
                MessageBox.Show(constants.filedoesnotexist);
            }else
            if (urlError == false)
            {
                MessageBox.Show(constants.invalidimageurl);
            }else
                if (imageError == true)
            {
                MessageBox.Show(constants.invalidimageurl);
            } else
            if (textError == false && pathError == false && fileError == false && urlError == true && imageError == false)
            {

                if (operationType == 1)
                {
                    List<KeyValuePair<string, string>> game = new List<KeyValuePair<string, string>>();
                    List<Games> gameObject = new List<Games>
            {
                new Games() {name = txtGameName.Text, image = txtGameCoverUrl.Text, path = txtGamePath.Text, savepath = txtSaveFileLocation.Text}
            };

                    foreach (var data in gameObject)
                    {

                        game.Clear();
                        foreach (var item in data.GetType().GetProperties())
                        {
                            game.Add(new KeyValuePair<string, string>(item.Name, item.GetValue(data).ToString()));
                        }
                    }

                    db.insertToDatabase(game, "games");

                    string dest = constants.autosaverpath + @"\" + txtGameName.Text;
                    DirectoryInfo di = Directory.CreateDirectory(dest);
                    MessageBox.Show(constants.gameadded);
                } else
                    if (operationType == 2)
                {
                    List<KeyValuePair<string, string>> game = new List<KeyValuePair<string, string>>();
                    List<Games> gameObject = new List<Games>
            {
                new Games() {name = txtGameName.Text, image = txtGameCoverUrl.Text, path = txtGamePath.Text, savepath = txtSaveFileLocation.Text}
            };

                    foreach (var data in gameObject)
                    {

                        game.Clear();
                        foreach (var item in data.GetType().GetProperties())
                        {
                            game.Add(new KeyValuePair<string, string>(item.Name, item.GetValue(data).ToString()));
                        }
                    }

                    db.updateToDatabase(game, "games", currentGame);

                    string dest = constants.autosaverpath + @"\" + txtGameName.Text;
                    DirectoryInfo di = Directory.CreateDirectory(dest);
                    MessageBox.Show(constants.gameupdated);
                }

              
                misc.clearTextBoxes(this);

            }


        }

        private void setForAddGame()
        {
            lblTitle.Text = "Add Game";
            btnSubmit.Text = "Submit";
        }

        private void setForUpdateGame()
        {
            lblTitle.Text = "Update Game";
            btnSubmit.Text = "Update";
        }

        public void setOperationType(int type)
        {
            operationType = type;
        }

        public void setCurrentGame(int currentgame)
        {
            currentGame = currentgame;
        }

    }
}
