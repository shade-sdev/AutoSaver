using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver
{
    class constants
    {
       public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\AutoSaver.mdf;Integrated Security=True";
        //public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shade\source\repos\AutoSaver\AutoSaver\AutoSaver.mdf;Integrated Security=True";
        public static string autosaverpath = misc.getAutoSaverPath("AutoSaver.ini", 0, 5);
        public static string clientId = misc.getAutoSaverPath("AutoSaver.ini", 1, 9);
        public static string secret = misc.getAutoSaverPath("AutoSaver.ini", 2, 7);
        public static string accessToken = misc.getAutoSaverPath("AutoSaver.ini", 3, 12);
        public static string pathdoesnotexist = "Path does not exist!";
        public static string fillallfields = "Fill all fields";
        public static string invalidimageurl = "Invalid Image Url";
        public static string filedoesnotexist = "File does not exists";
        public static string gameadded = "Game Added!";
        public static string gameupdated = "Game Updated!";
        public static string autosaverrestartmsg = "AutoSaver path set! AutoSaver will now restart!";

    }
}
