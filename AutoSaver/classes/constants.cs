using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver
{
    class constants
    {
       // public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\AutoSaver.mdf;Integrated Security=True";
       public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shade\source\repos\AutoSaver\AutoSaver\AutoSaver.mdf;Integrated Security=True";
        public static string clientId = "lhf9av4jg9c5i1tz00lc9pq4nq2rwh";
        public static string accessToken = "Bearer o6zbmtqlkhr6dd0gbiw3zk7xmh5ks0";
        public static string secret = "";
        public static string autosaverpath = misc.getAutoSaverPath("AutoSaver.ini", 0, 0);
        public static string pathdoesnotexist = "Path does not exist!";
        public static string fillallfields = "Fill all fields";
        public static string invalidimageurl = "Invalid Image Url";
        public static string filedoesnotexist = "File does not exists";
        public static string gameadded = "Game Added!";
        public static string gameupdated = "Game Updated!";
        public static string autosaverrestartmsg = "AutoSaver path set! AutoSaver will now restart!";

    }
}
