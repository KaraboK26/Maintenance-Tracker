using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    class Logins
    {
        private static string username; 
        public string Username { get; set; }
        private static string password; 
        public string Password { get; set; }
        private static string position;
        public string Position { get; set; }

        static List<object> myusers = new List<object>();

        public void Populate()
        {
            Logins user1 = new Logins(); user1.Username = "jack"; user1.Password = "password"; user1.Position = "agent";
            Logins user2 = new Logins(); user2.Username = "Mack"; user2.Password = "password"; user2.Position = "technician";
            Logins user3 = new Logins(); user3.Username = "Lack"; user3.Password = "password"; user3.Position = "manager";
            Logins user4 = new Logins(); user4.Username = "root"; user4.Password = "admin"; user4.Position = "admin";

            myusers.Add(user1);
            myusers.Add(user2);
            myusers.Add(user3);
            myusers.Add(user4);
        }

        public bool ValidateUser()
        {
            bool found = false;

            foreach (var item in myusers)
            {
                if (item.GetType().GetProperty("Username").GetValue(item,null).ToString() == Username && item.GetType().GetProperty("Password").GetValue(item,null).ToString() == Password)
                {
                    found = true;

                    username = item.GetType().GetProperty("Username").GetValue(item, null).ToString();
                    password = item.GetType().GetProperty("Password").GetValue(item, null).ToString();
                    position = item.GetType().GetProperty("Position").GetValue(item, null).ToString();
                }
            }

            return found;
        }

        public Logins getcredentials()
        {
            Logins logins = new Logins();

            logins.Username = username;
            logins.Position = position;

            return logins;
        }
    }
}
