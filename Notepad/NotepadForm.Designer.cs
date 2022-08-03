namespace Notepad
{
    partial class NotepadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.formatFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeThoughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.MainMenuStrip, "MainMenuStrip");
            this.MainMenuStrip.Name = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.toolStripMenuItem5,
            this.dateTimeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            resources.ApplyResources(this.deleteAllToolStripMenuItem, "deleteAllToolStripMenuItem");
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            resources.ApplyResources(this.dateTimeToolStripMenuItem, "dateTimeToolStripMenuItem");
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.toolStripMenuItem6,
            this.formatFontToolStripMenuItem,
            this.changeTextColorToolStripMenuItem,
            this.toolStripMenuItem7,
            this.normalToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.strikeThoughToolStripMenuItem,
            this.underlineToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            resources.ApplyResources(this.formatToolStripMenuItem, "formatToolStripMenuItem");
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            resources.ApplyResources(this.zoomToolStripMenuItem, "zoomToolStripMenuItem");
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            resources.ApplyResources(this.zoomInToolStripMenuItem, "zoomInToolStripMenuItem");
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            resources.ApplyResources(this.zoomOutToolStripMenuItem, "zoomOutToolStripMenuItem");
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // formatFontToolStripMenuItem
            // 
            this.formatFontToolStripMenuItem.Name = "formatFontToolStripMenuItem";
            resources.ApplyResources(this.formatFontToolStripMenuItem, "formatFontToolStripMenuItem");
            this.formatFontToolStripMenuItem.Click += new System.EventHandler(this.formatFontToolStripMenuItem_Click);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            resources.ApplyResources(this.changeTextColorToolStripMenuItem, "changeTextColorToolStripMenuItem");
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            resources.ApplyResources(this.normalToolStripMenuItem, "normalToolStripMenuItem");
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            resources.ApplyResources(this.boldToolStripMenuItem, "boldToolStripMenuItem");
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            resources.ApplyResources(this.italicToolStripMenuItem, "italicToolStripMenuItem");
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // strikeThoughToolStripMenuItem
            // 
            this.strikeThoughToolStripMenuItem.Name = "strikeThoughToolStripMenuItem";
            resources.ApplyResources(this.strikeThoughToolStripMenuItem, "strikeThoughToolStripMenuItem");
            this.strikeThoughToolStripMenuItem.Click += new System.EventHandler(this.strikeThoughToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            resources.ApplyResources(this.underlineToolStripMenuItem, "underlineToolStripMenuItem");
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutNotepadToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutNotepadToolStripMenuItem
            // 
            this.aboutNotepadToolStripMenuItem.Name = "aboutNotepadToolStripMenuItem";
            resources.ApplyResources(this.aboutNotepadToolStripMenuItem, "aboutNotepadToolStripMenuItem");
            this.aboutNotepadToolStripMenuItem.Click += new System.EventHandler(this.aboutNotepadToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // NotepadForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MainMenuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "NotepadForm";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutNotepadToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem formatFontToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem strikeThoughToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
    }
}