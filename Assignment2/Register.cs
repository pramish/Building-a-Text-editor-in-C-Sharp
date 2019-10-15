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
    public partial class register : Form
    {
        string value = "";
        userHelper user = new userHelper();
        configure config = new configure();
        User newuser = new User();
        public register()
        {
            InitializeComponent();


        }private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "MMMM-dd-yyyy";
        }

        private void register_Load(object sender, EventArgs e)
        {

            if (!(user.findFile(config.folder + "\\login.txt")))
            {
                if (!(user.createFile(config.folder + "\\login.txt")))
                {
                    MessageBox.Show("Can't Create your Text File.", "Dernied", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    this.Close();
                }
            }
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (viewBox.Text == "Edit")
            {
                if (usernameText.Text.Length == 0 || firstNameText.Text.Length == 0 || lastNameText.Text.Length == 0 || DOB.Text.Length == 0 || passwordBox.Text.Length == 0 || confirmPasswordbox.Text.Length == 0 || viewBox.Text.Length == 0)

                {
                    MessageBox.Show("Please fill out all the fields.", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    return;
                }
                if (passwordBox.Text != confirmPasswordbox.Text)
                {
                    MessageBox.Show("Password does not match. Please enter the same password.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    return;
                }
                if (usernameText.Text.Length != 0 || firstNameText.Text.Length != 00 || lastNameText.Text.Length != 0 || DOB.Text.Length != 0 || passwordBox.Text.Length != 0 || confirmPasswordbox.Text.Length != 0)
                {
                    if (User.userList.Count == 0) return;
                    else
                    {
                        var list = User.userList.Where(a => a.userName == usernameText.Text && a.firstName == firstNameText.Text && a.lastName == lastNameText.Text);
                        if (list.ToList().Count >= 1)
                        {
                            MessageBox.Show(usernameText.Text + " is already Registered", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    
                    string data = usernameText.Text + "," + passwordBox.Text + "," + viewBox.Text + "," + firstNameText.Text + "," + lastNameText.Text + "," + DateTime.Parse(DOB.Text).ToString("MM-dd-yyyy");
                    if (user.writeFile(data, config.folder + "\\login.txt"))
                    {
                        MessageBox.Show(firstNameText.Text + " " + lastNameText.Text + " is Registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                        TextEditor text = new TextEditor();
                        text.ShowDialog();
                        this.Close();
                        string name = usernameText.Text;
                        text.setUsername(name);
                    }
                }
                else
                {
                    MessageBox.Show("Error in User Registration", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            if (viewBox.Text == "View")
            {
                if (usernameText.Text.Length == 0 || firstNameText.Text.Length == 0 || lastNameText.Text.Length == 0 || DOB.Text.Length == 0 || passwordBox.Text.Length == 0 || confirmPasswordbox.Text.Length == 0 || viewBox.Text.Length == 0)

                {
                    MessageBox.Show("Please fill out all the fields.", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    return;
                }
                if (passwordBox.Text != confirmPasswordbox.Text)
                {
                    MessageBox.Show("Password does not match. Please enter the same password.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    return;
                }
                if (usernameText.Text.Length != 0 || firstNameText.Text.Length != 00 || lastNameText.Text.Length != 0 || DOB.Text.Length != 0 || passwordBox.Text.Length != 0 || confirmPasswordbox.Text.Length != 0)
                {
                    if (User.userList.Count == 0) return;
                    else
                    {
                        var list = User.userList.Where(a => a.userName == usernameText.Text && a.firstName == firstNameText.Text && a.lastName == lastNameText.Text);
                        if (list.ToList().Count >= 1)
                        {
                            MessageBox.Show(usernameText.Text + " is already Registered", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    string data = usernameText.Text + "," + passwordBox.Text + "," + viewBox.Text + "," + firstNameText.Text + "," + lastNameText.Text + "," + DateTime.Parse(DOB.Text).ToString("MM/dd/yyyy");
                    if (user.writeFile(data, config.folder + "\\login.txt"))
                    {
                        MessageBox.Show(firstNameText.Text + " " + lastNameText.Text + " is Registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        TextEditor_View text = new TextEditor_View();
                        text.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error in User Registration", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void viewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = this.viewBox.Text;
        }
        public string getValue()
        {
            return value;
        }
        public string getName() { return this.usernameText.Text; }

        private void confirmPasswordbox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordbox.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            // this.usernameText.Text += "Hello World!";
        }

        private void usernameText_Enter(object sender, EventArgs e)
        {
            if (usernameText.Text == "Username")
            {
                usernameText.Text = "";
                usernameText.ForeColor = Color.Black;
            }
        }

        private void usernameText_Leave(object sender, EventArgs e)
        {
            if (usernameText.Text == "")
            {
                usernameText.Text = "Username";
                usernameText.ForeColor = Color.Silver;
            }
        }

        private void firstname_Enter(object sender, EventArgs e)
        {
            if (firstNameText.Text == "First Name")
            {
                firstNameText.Text = "";
                firstNameText.ForeColor = Color.Black;
            }
        }

        private void firstname_Leave(object sender, EventArgs e)
        {
            if (firstNameText.Text == "")
            {
                firstNameText.Text = "First Name";
                firstNameText.ForeColor = Color.Silver;
            }
        }

        private void lastname_Enter(object sender, EventArgs e)
        {
            if (lastNameText.Text == "Last Name")
            {
                lastNameText.Text = "";
                lastNameText.ForeColor = Color.Black;
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastNameText.Text == "")
            {
                lastNameText.Text = "Last Name";
                lastNameText.ForeColor = Color.Silver;
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

        private void confirmPassword_Enter(object sender, EventArgs e)
        {
            if (confirmPasswordbox.Text == "Confirm Password")
            {
                confirmPasswordbox.Text = "";
                confirmPasswordbox.ForeColor = Color.Black;
            }
        }

        private void confirmPassword_Leave(object sender, EventArgs e)
        {
            if (confirmPasswordbox.Text == "")
            {
                confirmPasswordbox.Text = "Confirm Password";
                confirmPasswordbox.ForeColor = Color.Silver;
            }
        }
    }
}

