using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organiser_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IO users = new IO("mydb.csv");
            users.ReadUserList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var init = 0;
            for (var i = 0; i < User.userList.Count; i++)
            {
                if (User.userList[i].remember == true)
                {
                    init = 1;
                    User.curr = i;
                    break;
                }
            }
            if (init == 0) { Application.Run(new LogInPage()); }
            else { Application.Run(new MainPage()); }
            return;
        }
    }
}