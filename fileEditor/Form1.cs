using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileEditor
{
    public partial class F_TextEditor : Form
    {
        string filePath = "";
        FileEditor fileEditor;

        public F_TextEditor()
        {
            InitializeComponent();
            CheckCmEnable();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void UnlockControlls()
        {
            mb_fileClose.Enabled = true;
            mb_SaveFile.Enabled = true;
            mb_SaveFileAs.Enabled = true;
        }

        void LockControlls()
        {
            mb_fileClose.Enabled = false;
            mb_SaveFile.Enabled = false;
            mb_SaveFileAs.Enabled = false;
        }

        void CheckCmEnable()
        {
            if (rtb_Editor.SelectionLength > 0)
            {
                cm_Copy.Enabled = true;
                cm_Cut.Enabled = true;
            }
            else
            {
                cm_Copy.Enabled = false;
                cm_Cut.Enabled = false;
            }

            if (Clipboard.ContainsText())
            {
                cm_Paste.Enabled = true;
            }
            else
            {
                cm_Paste.Enabled = false;
            }    

        }

        private void mb_OpenFile_Click(object sender, EventArgs e)
        {
            if (openTxtDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openTxtDialog.FileName;
                fileEditor = new FileEditor(filePath);
                List<string> lines = fileEditor.ReadFile();
                string resText = "";
                lines.ForEach(delegate (string line)
                {
                    resText += line + "\n";
                });
                if(!String.IsNullOrEmpty(resText))
                {
                    rtb_Editor.Text = resText.Remove(resText.Length - 1);
                }
                else
                {
                    rtb_Editor.Text = "";
                }
                UnlockControlls();
            }
        }

        private void mb_SaveFile_Click(object sender, EventArgs e)
        {
            fileEditor.WriteFile(rtb_Editor.Text);
        }

        private void mb_SaveFileAs_Click(object sender, EventArgs e)
        {
            if (saveTxtDialog.ShowDialog() == DialogResult.OK)
            {
                fileEditor.writeFileAs(rtb_Editor.Text, saveTxtDialog.FileName);
            }
        }

        private void mb_fileClose_Click(object sender, EventArgs e)
        {
            filePath = "";
            fileEditor = null;
            rtb_Editor.Text = "";
            LockControlls();
        }

        private void cm_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_Editor.SelectedText);
        }

        private void cm_Cut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_Editor.SelectedText);
            rtb_Editor.SelectedText = "";
        }

        private void cm_Paste_Click(object sender, EventArgs e)
        {
            if (rtb_Editor.SelectedText == "")
            {
                int cursorPosition = rtb_Editor.SelectionStart;
                rtb_Editor.Text = rtb_Editor.Text.Insert(cursorPosition, Clipboard.GetText());
            }
                
            else
                rtb_Editor.SelectedText = Clipboard.GetText();
        }

        private void contextMenu_RTB_Opening(object sender, CancelEventArgs e)
        {
            CheckCmEnable();
        }
    }
}
