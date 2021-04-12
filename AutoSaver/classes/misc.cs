using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoSaver
{
    class misc
    {

        public static void setAutoSaverPath(string path, int count, string textbox)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            lines[count] = textbox;

            System.IO.File.WriteAllLines(path, lines);
        }

        public static string getAutoSaverPath(string path, int count, int substring)
        {
            string[] allLines = File.ReadAllLines(path);
            string randomLine = allLines[count];
            return randomLine.Substring(substring);
        }

        public static void CloneDirectory(string root, string dest)
        {
            foreach (var directory in Directory.GetDirectories(root))
            {
                string dirName = Path.GetFileName(directory);
                if (!Directory.Exists(Path.Combine(dest, dirName)))
                {
                    Directory.CreateDirectory(Path.Combine(dest, dirName));
                }
                CloneDirectory(directory, Path.Combine(dest, dirName));
            }

            foreach (var file in Directory.GetFiles(root))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)),true);
            }
        }

        public static void clearFlp<T>(FlowLayoutPanel flp) where T : Control
        {
           
            foreach (Control item in flp.Controls.OfType<T>())
            {
                flp.Controls.Remove(item);
            }

            flp.Controls.Clear();
        }

        public static bool checkIfEmpty(string text)
        {
            if (text == string.Empty)
            {
                return true;
            }

            return false;
        }

        public static bool checkIfPathExists(string path)
        {
            if (!Directory.Exists(path))
            {
                return true;
            }

            return false;
        }

        public static bool checkIfFileExists(string path)
        {
            if (!File.Exists(path))
            {
                return true;
            }

            return false;
        }

        public static bool CheckImage(string url)
        {

            if (url.Contains(".jpg") || url.Contains(".png"))
            {
                return false;
            }

            return true;

          
        }

        public static bool validateUrl(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        public static void clearTextBoxes(Form form)
        {
            foreach (Control gunaTextBox in form.Controls)
            {
                if (gunaTextBox is Guna.UI.WinForms.GunaTextBox)
                {
                    gunaTextBox.Text = string.Empty;
                }
               
            }
        }

    }
}
