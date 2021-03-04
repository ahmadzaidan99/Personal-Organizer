using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organiser_App
{
    class User
    {
        public static List<User> userList = new List<User>();
        public static int curr = -1;
        public string username;
        public string password;
        public string userType;
        public bool remember;
        public int ID;
        public string firstName = "";
        public string surname = "";
        public string phoneNumber = "";
        public string emailAddress = "";
        public string address = "";
        public string picture = "";
        public double minimumSalary = 0.00;
        public List<Reminder> remindersList = new List<Reminder>();

        public User(string username, string password, string remember = "False", string userType = "User")
        {
            this.username = username;
            this.password = password;
            if (remember == "False") { this.remember = false; }
            else { this.remember = true; }
            this.userType = userType;
        }
        public static void AddUserToList(User user)
        {
            userList.Add(user);
        }
    }
}