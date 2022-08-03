using System.Drawing;

namespace Notepad
{
    public partial class NotepadForm : Form
    {
        #region fields
            private bool isFileAlreadySaved;
            private bool isFileDirty ;
            private string currOpenFileName ;
        #endregion

        public NotepadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Notepad Menu Code...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All right reserved with the author", "About Nopepad Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// New File Menui Code...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileDirty)
            {
                DialogResult result = MessageBox.Show("Do youn want to save changes?","File Save",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFileMenu();
                        break;
                    case DialogResult.No:
                        break;

                }

            }
            
            ClearScreen();
            isFileAlreadySaved = false;
            currOpenFileName = "";
            EnableDisableUndoRedoProcess(false);
        }
        
        /// <summary>
        /// Exit Menu Code...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Open File Menu Code...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openFile.FileName) == ".txt")
                {
                    richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                }

                if (Path.GetExtension(openFile.FileName) == ".rtf")
                {
                    richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                }

                this.Text = Path.GetFileName(openFile.FileName) + " - Notepad";

                isFileAlreadySaved = true;
                isFileDirty = false;
                currOpenFileName = openFile.FileName;
                EnableDisableUndoRedoProcess(false);
            }


        }

        private void EnableDisableUndoRedoProcess(bool enable)
        {
            undoToolStripMenuItem.Enabled = enable;
            redoToolStripMenuItem.Enabled = enable;
        }

        /// <summary>
        /// Save File Menu Code...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call Save File Menu Function...
            SaveFileMenu();
        }
        // Purpose: Implementation of Save File Menu Function...
        private void SaveFileMenu()
        {
            if (isFileAlreadySaved)
            {
                if (Path.GetExtension(currOpenFileName) == ".txt")
                {
                    richTextBox1.SaveFile(currOpenFileName, RichTextBoxStreamType.PlainText);
                }

                if (Path.GetExtension(currOpenFileName) == ".rtf")
                {
                    richTextBox1.SaveFile(currOpenFileName, RichTextBoxStreamType.RichText);
                }
                isFileDirty = false;
            }
            else
            {
                if (isFileDirty == true)
                {
                    SaveAsFileMenu();
                }
                else
                {
                    ClearScreen();
                }
            }
        }

        // Clear the screen and default the variable...
        private void ClearScreen()
        {
            richTextBox1.Clear();
            this.Text = "Untitled - Notepad";
            isFileDirty = false;
        }

        /// <summary>
        /// Save As File Menu Code...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFileMenu();
        }

        // Save As File Menu Function Implementation...
        private void SaveAsFileMenu()
        {
            SaveFileDialog saveAsFile = new SaveFileDialog();

            saveAsFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";

            DialogResult result = saveAsFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveAsFile.FileName) == ".txt")
                {
                    richTextBox1.SaveFile(saveAsFile.FileName, RichTextBoxStreamType.PlainText);
                }

                if (Path.GetExtension(saveAsFile.FileName) == ".rtf")
                {
                    richTextBox1.SaveFile(saveAsFile.FileName, RichTextBoxStreamType.RichText);
                }

                this.Text = Path.GetFileName(saveAsFile.FileName) + " - Notepad";

                isFileAlreadySaved = true;
                isFileDirty = false;
                 currOpenFileName = saveAsFile.FileName;
            }


        }

        /// <summary>
        /// Text Box change event...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isFileDirty = true;
            undoToolStripMenuItem.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            redoToolStripMenuItem.Enabled = true;
            undoToolStripMenuItem.Enabled = false;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void formatFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
              FontDialog fontDialog = new FontDialog();
              fontDialog.ShowColor = true;
              DialogResult result = fontDialog.ShowDialog();

              if (result == DialogResult.OK & !string.IsNullOrEmpty(richTextBox1.Text))
              {
                  richTextBox1.SelectionFont = fontDialog.Font;
                  richTextBox1.SelectionColor = fontDialog.Color;
              }           
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void strikeThoughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Strikeout);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Copy();

            if (richTextBox1.SelectionLength > 0)
                Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Paste();

            if (Clipboard.ContainsText())
                richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Cut();

            if (richTextBox1.SelectionLength > 0)
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
        }
    }
}
