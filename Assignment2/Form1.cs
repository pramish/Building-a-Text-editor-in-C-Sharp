using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        register reg = new register();
        userHelper help = new userHelper();
        configure config = new configure();
        userPopulation user = new userPopulation();
        public Form1()
        {
            InitializeComponent();
            User.getUsers();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void loginbutton_Click(object sender, EventArgs e)
        {

            {
                if (usernameBox.Text.Length == 0 || passwordBox.Text.Length == 0)
                    MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var userValue = User.userList.Where(p => p.userName == usernameBox.Text || p.password == passwordBox.Text).ToList();
                   
                    if (userValue.Count == 0)
                        MessageBox.Show("Incorrect username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {

                        User.selectedUsers = new List<Users>();
                        User.selectedUsers.Add(new Users
                        {
                            
                            userName = userValue[0].userName,
                            password = userValue[0].password,
                            userType = userValue[0].userType
                        });

                        string type = User.selectedUsers[0].userType;
                        if (type == "View")
                        {
                            TextEditor_View text = new TextEditor_View();
                            text.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            TextEditor text = new TextEditor();
                            text.ShowDialog();
                            this.Close();
                        }

                    }



                }
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!(help.findFile(config.folder + "\\login.txt")))
            {
                MessageBox.Show("No Database found", "security", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.loginbutton.Enabled = false;
            }
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.ShowDialog();
            this.Close();
            this.Hide();
            User.getUsers();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextEditor text = new TextEditor();
            text.ShowDialog();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            TextEditor_View view = new TextEditor_View();
            view.ShowDialog();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            TextEditor edit = new TextEditor();
            edit.ShowDialog();
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username")
            {
                usernameBox.Text = "";
                usernameBox.ForeColor = Color.Black;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                usernameBox.Text = "Username";
                usernameBox.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = "";
                passwordBox.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Password";
                passwordBox.ForeColor = Color.Silver;
            }
        }
    }
}
