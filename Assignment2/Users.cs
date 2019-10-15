using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    class userHelper
    {
        public bool findFile(String filePath)
        {
            return File.Exists(filePath);
        }
        public bool createFile(string filePath)
        {
            if (findFile(filePath))
            {
                File.Create(filePath);
                return true;
            }
            else
                return false;
        }
        public bool writeFile(string data, string filePath, bool value = false)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(filePath, true))
                {
                    w.WriteLine(data);
                    w.Flush();
                    w.Close();
                }
                value = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return value;
        }
    }
    class configure
    {
        public string folder = Path.GetDirectoryName(Application.ExecutablePath);
    }
    class Users
    {
        public string password { get; set; }
        public string userName { get; set; }

        public string userType { get; set; }
    }
    class userPopulation
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string dateofBirth { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userType { get; set; }
    }
    class User
    {
        public static List<userPopulation> userList = new List<userPopulation>();
        public static List<Users> selectedUsers = new List<Users>();
        public static void getUsers()
        {
            userList = new List<userPopulation>();
            configure config = new configure();
            userHelper help = new userHelper();

            if (!help.findFile(config.folder + "\\login.txt")) return;
            userList = new List<userPopulation>();
            using (StreamReader sr = new StreamReader(config.folder + "\\login.txt"))
            {
                string[] sentence = sr.ReadToEnd().Replace("\n", "|\r\n").Split('|');
                for (int i = 0; i < sentence.Length - 1; i++)
                {
                    string[] user = sentence[i].Split(',');
                    userList.Add(new userPopulation
                    {
                        userName = user[0],
                        password = user[1],
                        userType = user[2],
                        firstName = user[3],
                        lastName = user[4],
                        dateofBirth = user[5]
                    }
                        );
                }
            }
        }
        public List<userPopulation> getUserList()
        {
            return userList;
        }
    }
}
