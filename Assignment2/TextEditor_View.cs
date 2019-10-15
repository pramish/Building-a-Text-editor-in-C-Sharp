using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class TextEditor_View : Form
    {
        Form1 form = new Form1();
        public TextEditor_View()
        {
            InitializeComponent();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void open_button_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void usernames_Click(object sender, EventArgs e)
        {
            openFile();
        }
        
        void openFile()
        {
            if (hello.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(hello.FileName, RichTextBoxStreamType.PlainText);
                //richTextBox.LoadFile
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox.Enabled = false;
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void TextEditor_View_Load(object sender, EventArgs e)
        {
            //string type = User.selectedUsers[0].userName;
            //usernames.Text = "User Name: " + User.selectedUsers[0].userName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
            this.Close();
            
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
