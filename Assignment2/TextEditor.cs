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
    public partial class TextEditor : Form
    {

        Form1 form = new Form1();
        register reg = new register();
        public TextEditor()
        {
            InitializeComponent();
        }


        private void new_file_Click(object sender, EventArgs e)
        {
            New();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            New();
        }
        void New()
        {
            my_document.Clear();
        }

        private void new_save_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void save_documents_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        void saveFile()
        {
            if (savemywork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    my_document.SaveFile(savemywork.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void new_open_Click(object sender, EventArgs e)
        {
            openFile();
        }
        void openFile()
        {
            if (openmywork.ShowDialog() == DialogResult.OK)
            {
                my_document.LoadFile(openmywork.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void new_logout_Click(object sender, EventArgs e)
        {
            if (my_document.TextLength != 0)
            {
                if (!(save_documents.CheckOnClick && new_save.CheckOnClick))
                {
                    DialogResult result = MessageBox.Show("Do you want to save the changes to Untitled?", "TextEditor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)

                    {
                        saveFile();
                        this.Close();
                    }
                    if (result == DialogResult.No)
                    {
                        form.ShowDialog();
                        this.Close();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
            }
            else
            {

                form.ShowDialog();
                this.Close();
            }

        }

        private void new_save_as_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void cut_documents_Click(object sender, EventArgs e)
        {
            cutmysentence();
        }
        void cutmysentence()
        {
            my_document.Cut();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            cutmysentence();
        }

        private void copy_documents_Click(object sender, EventArgs e)
        {
            copysentence();
        }

        private void copy_document_Click(object sender, EventArgs e)
        {
            copysentence();
        }
        void copysentence()
        {
            my_document.Copy();
        }
        void pastemysentence()
        {
            my_document.Paste();
        }

        private void paste_documents_Click(object sender, EventArgs e)
        {
            pastemysentence();
        }

        private void paste_document_Click(object sender, EventArgs e)
        {
            pastemysentence();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutmysentence();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copysentence();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pastemysentence();
        }

        private void bold_document_Click(object sender, EventArgs e)
        {
            Font boldFont = new Font(my_document.Font, FontStyle.Bold);
            Font regularFont = new Font(my_document.Font, FontStyle.Regular);
            if (my_document.SelectedText.Length == 0)
                return;
            if (my_document.SelectionFont.Bold)
            {
                my_document.SelectionFont = regularFont;
            }
            else
            {
                my_document.SelectionFont = boldFont;
            }
        }

        private void italic_document_Click(object sender, EventArgs e)
        {
            Font italic = new Font(my_document.Font, FontStyle.Italic);
            Font regularItalic = new Font(my_document.Font, FontStyle.Regular);
            if (my_document.SelectedText.Length == 0) return;
            if (my_document.SelectionFont.Italic)
            {
                my_document.SelectionFont = regularItalic;
            }
            else
            {
                my_document.SelectionFont = italic;
            }
        }
        private void bold_underline()
        {

        }

        private void underline_document_Click(object sender, EventArgs e)
        {
            Font underline = new Font(my_document.Font, FontStyle.Underline);
            Font regularunderline = new Font(my_document.Font, FontStyle.Regular);
            if (my_document.SelectedText.Length == 0) return;
            if (my_document.SelectionFont.Underline)
            {
                my_document.SelectionFont = regularunderline;
            }
            else
            {
                my_document.SelectionFont = underline;
            }
        }
        void fontSize()
        {
            for (int i = 8; i <= 20; i++)
            {
                fontsize_document.Items.Add(i.ToString());
            }
        }

        private void fontsize_document_Click(object sender, EventArgs e)
        {

        }

        private void Document_TextChanged(object sender, EventArgs e)
        {


        }
        public void setUsername(string name)
        {
            name = username.Text;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            fontSize();


        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void file_Click(object sender, EventArgs e)
        {

        }

        private void username_Click_1(object sender, EventArgs e)
        {
        }

        private void openmywork_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void help_document_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void cut_file_Click(object sender, EventArgs e)
        {
            cutmysentence();
        }

        private void copy_file_Click(object sender, EventArgs e)
        {
            copysentence();
        }

        private void save_file_Click(object sender, EventArgs e)
        {
            pastemysentence();
        }

        private void tools_Customisation_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {

        }

        private void savemywork_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void unknown_tools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mytools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mymenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
