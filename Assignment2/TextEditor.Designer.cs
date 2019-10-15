namespace Assignment2
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.mymenu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.new_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.new_save = new System.Windows.Forms.ToolStripMenuItem();
            this.new_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.new_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cut_document = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_document = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_document = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.mytools = new System.Windows.Forms.ToolStrip();
            this.new_button = new System.Windows.Forms.ToolStripButton();
            this.open_button = new System.Windows.Forms.ToolStripButton();
            this.cut_documents = new System.Windows.Forms.ToolStripButton();
            this.copy_documents = new System.Windows.Forms.ToolStripButton();
            this.save_documents = new System.Windows.Forms.ToolStripButton();
            this.paste_documents = new System.Windows.Forms.ToolStripButton();
            this.bold_document = new System.Windows.Forms.ToolStripButton();
            this.italic_document = new System.Windows.Forms.ToolStripButton();
            this.underline_document = new System.Windows.Forms.ToolStripButton();
            this.fontsize_document = new System.Windows.Forms.ToolStripComboBox();
            this.help_document = new System.Windows.Forms.ToolStripButton();
            this.username = new System.Windows.Forms.ToolStripLabel();
            this.my_document = new System.Windows.Forms.RichTextBox();
            this.openmywork = new System.Windows.Forms.OpenFileDialog();
            this.savemywork = new System.Windows.Forms.SaveFileDialog();
            this.unknown_tools = new System.Windows.Forms.ToolStrip();
            this.cut_file = new System.Windows.Forms.ToolStripButton();
            this.copy_file = new System.Windows.Forms.ToolStripButton();
            this.save_file = new System.Windows.Forms.ToolStripButton();
            this.mymenu.SuspendLayout();
            this.mytools.SuspendLayout();
            this.unknown_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mymenu
            // 
            this.mymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.help});
            this.mymenu.Location = new System.Drawing.Point(0, 0);
            this.mymenu.Name = "mymenu";
            this.mymenu.Size = new System.Drawing.Size(742, 24);
            this.mymenu.TabIndex = 0;
            this.mymenu.Text = "menuStrip1";
            this.mymenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mymenu_ItemClicked);
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_file,
            this.new_open,
            this.toolStripSeparator,
            this.new_save,
            this.new_save_as,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.new_logout});
            this.file.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "&File";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // new_file
            // 
            this.new_file.Image = ((System.Drawing.Image)(resources.GetObject("new_file.Image")));
            this.new_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_file.Name = "new_file";
            this.new_file.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new_file.Size = new System.Drawing.Size(186, 22);
            this.new_file.Text = "&New";
            this.new_file.Click += new System.EventHandler(this.new_file_Click);
            // 
            // new_open
            // 
            this.new_open.Image = ((System.Drawing.Image)(resources.GetObject("new_open.Image")));
            this.new_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_open.Name = "new_open";
            this.new_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.new_open.Size = new System.Drawing.Size(186, 22);
            this.new_open.Text = "&Open";
            this.new_open.Click += new System.EventHandler(this.new_open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(183, 6);
            // 
            // new_save
            // 
            this.new_save.Image = ((System.Drawing.Image)(resources.GetObject("new_save.Image")));
            this.new_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_save.Name = "new_save";
            this.new_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.new_save.Size = new System.Drawing.Size(186, 22);
            this.new_save.Text = "&Save";
            this.new_save.Click += new System.EventHandler(this.new_save_Click);
            // 
            // new_save_as
            // 
            this.new_save_as.Image = ((System.Drawing.Image)(resources.GetObject("new_save_as.Image")));
            this.new_save_as.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_save_as.Name = "new_save_as";
            this.new_save_as.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.new_save_as.Size = new System.Drawing.Size(186, 22);
            this.new_save_as.Text = "Save &As";
            this.new_save_as.Click += new System.EventHandler(this.new_save_as_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // new_logout
            // 
            this.new_logout.Image = ((System.Drawing.Image)(resources.GetObject("new_logout.Image")));
            this.new_logout.Name = "new_logout";
            this.new_logout.Size = new System.Drawing.Size(186, 22);
            this.new_logout.Text = "Logout";
            this.new_logout.Click += new System.EventHandler(this.new_logout_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.cut_document,
            this.copy_document,
            this.paste_document,
            this.toolStripSeparator4});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(39, 20);
            this.edit.Text = "&Edit";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cut_document
            // 
            this.cut_document.Image = ((System.Drawing.Image)(resources.GetObject("cut_document.Image")));
            this.cut_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut_document.Name = "cut_document";
            this.cut_document.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut_document.Size = new System.Drawing.Size(144, 22);
            this.cut_document.Text = "Cu&t";
            this.cut_document.Click += new System.EventHandler(this.cut_documents_Click);
            // 
            // copy_document
            // 
            this.copy_document.Image = ((System.Drawing.Image)(resources.GetObject("copy_document.Image")));
            this.copy_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy_document.Name = "copy_document";
            this.copy_document.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy_document.Size = new System.Drawing.Size(144, 22);
            this.copy_document.Text = "&Copy";
            this.copy_document.Click += new System.EventHandler(this.copy_document_Click);
            // 
            // paste_document
            // 
            this.paste_document.Image = ((System.Drawing.Image)(resources.GetObject("paste_document.Image")));
            this.paste_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste_document.Name = "paste_document";
            this.paste_document.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste_document.Size = new System.Drawing.Size(144, 22);
            this.paste_document.Text = "&Paste";
            this.paste_document.Click += new System.EventHandler(this.paste_document_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "&Help";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(116, 22);
            this.about.Text = "About...";
            this.about.Click += new System.EventHandler(this.tools_Customisation_Click);
            // 
            // mytools
            // 
            this.mytools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_button,
            this.open_button,
            this.cut_documents,
            this.copy_documents,
            this.save_documents,
            this.paste_documents,
            this.bold_document,
            this.italic_document,
            this.underline_document,
            this.fontsize_document,
            this.help_document,
            this.username});
            this.mytools.Location = new System.Drawing.Point(0, 24);
            this.mytools.Name = "mytools";
            this.mytools.Size = new System.Drawing.Size(742, 25);
            this.mytools.TabIndex = 1;
            this.mytools.Text = "toolStrip1";
            this.mytools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mytools_ItemClicked);
            // 
            // new_button
            // 
            this.new_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.new_button.Image = ((System.Drawing.Image)(resources.GetObject("new_button.Image")));
            this.new_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(23, 22);
            this.new_button.Text = "&New";
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // open_button
            // 
            this.open_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open_button.Image = ((System.Drawing.Image)(resources.GetObject("open_button.Image")));
            this.open_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(23, 22);
            this.open_button.Text = "&Open";
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // cut_documents
            // 
            this.cut_documents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut_documents.Image = ((System.Drawing.Image)(resources.GetObject("cut_documents.Image")));
            this.cut_documents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut_documents.Name = "cut_documents";
            this.cut_documents.Size = new System.Drawing.Size(23, 22);
            this.cut_documents.Text = "C&ut";
            this.cut_documents.Click += new System.EventHandler(this.tb_Cut_Click);
            // 
            // copy_documents
            // 
            this.copy_documents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy_documents.Image = ((System.Drawing.Image)(resources.GetObject("copy_documents.Image")));
            this.copy_documents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy_documents.Name = "copy_documents";
            this.copy_documents.Size = new System.Drawing.Size(23, 22);
            this.copy_documents.Text = "&Copy";
            this.copy_documents.Click += new System.EventHandler(this.copy_documents_Click);
            // 
            // save_documents
            // 
            this.save_documents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_documents.Image = ((System.Drawing.Image)(resources.GetObject("save_documents.Image")));
            this.save_documents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_documents.Name = "save_documents";
            this.save_documents.Size = new System.Drawing.Size(23, 22);
            this.save_documents.Text = "&Save";
            this.save_documents.Click += new System.EventHandler(this.save_documents_Click);
            // 
            // paste_documents
            // 
            this.paste_documents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paste_documents.Image = ((System.Drawing.Image)(resources.GetObject("paste_documents.Image")));
            this.paste_documents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste_documents.Name = "paste_documents";
            this.paste_documents.Size = new System.Drawing.Size(23, 22);
            this.paste_documents.Text = "&Paste";
            this.paste_documents.Click += new System.EventHandler(this.paste_documents_Click);
            // 
            // bold_document
            // 
            this.bold_document.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bold_document.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold_document.Image = ((System.Drawing.Image)(resources.GetObject("bold_document.Image")));
            this.bold_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold_document.Name = "bold_document";
            this.bold_document.Size = new System.Drawing.Size(23, 22);
            this.bold_document.Text = "B";
            this.bold_document.Click += new System.EventHandler(this.bold_document_Click);
            // 
            // italic_document
            // 
            this.italic_document.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italic_document.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic_document.Image = ((System.Drawing.Image)(resources.GetObject("italic_document.Image")));
            this.italic_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic_document.Name = "italic_document";
            this.italic_document.Size = new System.Drawing.Size(23, 22);
            this.italic_document.Text = "I";
            this.italic_document.Click += new System.EventHandler(this.italic_document_Click);
            // 
            // underline_document
            // 
            this.underline_document.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underline_document.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_document.Image = ((System.Drawing.Image)(resources.GetObject("underline_document.Image")));
            this.underline_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline_document.Name = "underline_document";
            this.underline_document.Size = new System.Drawing.Size(23, 22);
            this.underline_document.Text = "U";
            this.underline_document.Click += new System.EventHandler(this.underline_document_Click);
            // 
            // fontsize_document
            // 
            this.fontsize_document.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontsize_document.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fontsize_document.Name = "fontsize_document";
            this.fontsize_document.Size = new System.Drawing.Size(121, 25);
            this.fontsize_document.Click += new System.EventHandler(this.fontsize_document_Click);
            // 
            // help_document
            // 
            this.help_document.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.help_document.Image = ((System.Drawing.Image)(resources.GetObject("help_document.Image")));
            this.help_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help_document.Name = "help_document";
            this.help_document.Size = new System.Drawing.Size(23, 22);
            this.help_document.Text = "He&lp";
            this.help_document.Click += new System.EventHandler(this.help_document_Click);
            // 
            // username
            // 
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 22);
            this.username.Click += new System.EventHandler(this.username_Click_1);
            // 
            // my_document
            // 
            this.my_document.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.my_document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.my_document.Location = new System.Drawing.Point(27, 49);
            this.my_document.Name = "my_document";
            this.my_document.Size = new System.Drawing.Size(715, 417);
            this.my_document.TabIndex = 2;
            this.my_document.Text = "";
            this.my_document.TextChanged += new System.EventHandler(this.Document_TextChanged);
            // 
            // openmywork
            // 
            this.openmywork.FileName = " ";
            this.openmywork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.openmywork.Title = "Open Work";
            this.openmywork.FileOk += new System.ComponentModel.CancelEventHandler(this.openmywork_FileOk);
            // 
            // savemywork
            // 
            this.savemywork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.savemywork.InitialDirectory = "@\"C:\\\";";
            this.savemywork.Title = "Open Work";
            this.savemywork.FileOk += new System.ComponentModel.CancelEventHandler(this.savemywork_FileOk);
            // 
            // unknown_tools
            // 
            this.unknown_tools.Dock = System.Windows.Forms.DockStyle.Left;
            this.unknown_tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.unknown_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut_file,
            this.copy_file,
            this.save_file});
            this.unknown_tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.unknown_tools.Location = new System.Drawing.Point(0, 49);
            this.unknown_tools.Name = "unknown_tools";
            this.unknown_tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.unknown_tools.Size = new System.Drawing.Size(24, 418);
            this.unknown_tools.TabIndex = 0;
            this.unknown_tools.Text = "toolStrip1";
            this.unknown_tools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.unknown_tools_ItemClicked);
            // 
            // cut_file
            // 
            this.cut_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut_file.Image = ((System.Drawing.Image)(resources.GetObject("cut_file.Image")));
            this.cut_file.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cut_file.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cut_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut_file.Margin = new System.Windows.Forms.Padding(0);
            this.cut_file.Name = "cut_file";
            this.cut_file.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.cut_file.Size = new System.Drawing.Size(21, 20);
            this.cut_file.Text = "C&ut";
            this.cut_file.Click += new System.EventHandler(this.cut_file_Click);
            // 
            // copy_file
            // 
            this.copy_file.CheckOnClick = true;
            this.copy_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy_file.Image = ((System.Drawing.Image)(resources.GetObject("copy_file.Image")));
            this.copy_file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copy_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy_file.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.copy_file.Name = "copy_file";
            this.copy_file.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.copy_file.Size = new System.Drawing.Size(21, 20);
            this.copy_file.Text = "&Copy";
            this.copy_file.Click += new System.EventHandler(this.copy_file_Click);
            // 
            // save_file
            // 
            this.save_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_file.Image = ((System.Drawing.Image)(resources.GetObject("save_file.Image")));
            this.save_file.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.save_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(21, 20);
            this.save_file.Text = "&Paste";
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 467);
            this.ControlBox = false;
            this.Controls.Add(this.unknown_tools);
            this.Controls.Add(this.my_document);
            this.Controls.Add(this.mytools);
            this.Controls.Add(this.mymenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mymenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 473);
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.mymenu.ResumeLayout(false);
            this.mymenu.PerformLayout();
            this.mytools.ResumeLayout(false);
            this.mytools.PerformLayout();
            this.unknown_tools.ResumeLayout(false);
            this.unknown_tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mymenu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem new_file;
        private System.Windows.Forms.ToolStripMenuItem new_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem new_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem new_logout;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cut_document;
        private System.Windows.Forms.ToolStripMenuItem copy_document;
        private System.Windows.Forms.ToolStripMenuItem paste_document;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStrip mytools;
        private System.Windows.Forms.RichTextBox my_document;
        private System.Windows.Forms.ToolStripButton new_button;
        private System.Windows.Forms.ToolStripButton open_button;
        private System.Windows.Forms.ToolStripButton save_documents;
        private System.Windows.Forms.ToolStripButton cut_documents;
        private System.Windows.Forms.ToolStripButton copy_documents;
        private System.Windows.Forms.ToolStripButton paste_documents;
        private System.Windows.Forms.ToolStripButton bold_document;
        private System.Windows.Forms.ToolStripButton italic_document;
        private System.Windows.Forms.ToolStripButton underline_document;
        private System.Windows.Forms.ToolStripComboBox fontsize_document;
        private System.Windows.Forms.OpenFileDialog openmywork;
        private System.Windows.Forms.SaveFileDialog savemywork;
        private System.Windows.Forms.ToolStripMenuItem new_save_as;
        private System.Windows.Forms.ToolStripButton help_document;
        private System.Windows.Forms.ToolStripLabel username;
        private System.Windows.Forms.ToolStrip unknown_tools;
        private System.Windows.Forms.ToolStripButton cut_file;
        private System.Windows.Forms.ToolStripButton copy_file;
        private System.Windows.Forms.ToolStripButton save_file;
    }
}