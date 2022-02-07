
namespace fileEditor
{
    partial class F_TextEditor
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
            this.components = new System.ComponentModel.Container();
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mb_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_fileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.openTxtDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTxtDialog = new System.Windows.Forms.SaveFileDialog();
            this.rtb_Editor = new System.Windows.Forms.RichTextBox();
            this.contextMenu_RTB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ms_MainMenu.SuspendLayout();
            this.contextMenu_RTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_File});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(309, 24);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "menuStrip1";
            // 
            // mb_File
            // 
            this.mb_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_OpenFile,
            this.mb_SaveFile,
            this.mb_SaveFileAs,
            this.mb_fileClose});
            this.mb_File.Name = "mb_File";
            this.mb_File.Size = new System.Drawing.Size(48, 20);
            this.mb_File.Text = "Файл";
            // 
            // mb_OpenFile
            // 
            this.mb_OpenFile.Name = "mb_OpenFile";
            this.mb_OpenFile.Size = new System.Drawing.Size(166, 22);
            this.mb_OpenFile.Text = "Открыть";
            this.mb_OpenFile.Click += new System.EventHandler(this.mb_OpenFile_Click);
            // 
            // mb_SaveFile
            // 
            this.mb_SaveFile.Enabled = false;
            this.mb_SaveFile.Name = "mb_SaveFile";
            this.mb_SaveFile.Size = new System.Drawing.Size(166, 22);
            this.mb_SaveFile.Text = "Сохранить";
            this.mb_SaveFile.Click += new System.EventHandler(this.mb_SaveFile_Click);
            // 
            // mb_SaveFileAs
            // 
            this.mb_SaveFileAs.Enabled = false;
            this.mb_SaveFileAs.Name = "mb_SaveFileAs";
            this.mb_SaveFileAs.Size = new System.Drawing.Size(166, 22);
            this.mb_SaveFileAs.Text = "Сохранить как ...";
            this.mb_SaveFileAs.Click += new System.EventHandler(this.mb_SaveFileAs_Click);
            // 
            // mb_fileClose
            // 
            this.mb_fileClose.Enabled = false;
            this.mb_fileClose.Name = "mb_fileClose";
            this.mb_fileClose.Size = new System.Drawing.Size(166, 22);
            this.mb_fileClose.Text = "Закрыть";
            this.mb_fileClose.Click += new System.EventHandler(this.mb_fileClose_Click);
            // 
            // openTxtDialog
            // 
            this.openTxtDialog.FileName = "openFileDialog1";
            this.openTxtDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveTxtDialog
            // 
            this.saveTxtDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // rtb_Editor
            // 
            this.rtb_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Editor.ContextMenuStrip = this.contextMenu_RTB;
            this.rtb_Editor.Location = new System.Drawing.Point(14, 44);
            this.rtb_Editor.Name = "rtb_Editor";
            this.rtb_Editor.Size = new System.Drawing.Size(281, 221);
            this.rtb_Editor.TabIndex = 1;
            this.rtb_Editor.Text = "";
            this.toolTip.SetToolTip(this.rtb_Editor, "Правая кнопка для использования контекстного меню");
            // 
            // contextMenu_RTB
            // 
            this.contextMenu_RTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_Copy,
            this.cm_Cut,
            this.cm_Paste});
            this.contextMenu_RTB.Name = "contextMenuStrip1";
            this.contextMenu_RTB.Size = new System.Drawing.Size(140, 70);
            this.contextMenu_RTB.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_RTB_Opening);
            // 
            // cm_Copy
            // 
            this.cm_Copy.Name = "cm_Copy";
            this.cm_Copy.Size = new System.Drawing.Size(139, 22);
            this.cm_Copy.Text = "Копировать";
            this.cm_Copy.Click += new System.EventHandler(this.cm_Copy_Click);
            // 
            // cm_Cut
            // 
            this.cm_Cut.Name = "cm_Cut";
            this.cm_Cut.Size = new System.Drawing.Size(139, 22);
            this.cm_Cut.Text = "Вырезать";
            this.cm_Cut.Click += new System.EventHandler(this.cm_Cut_Click);
            // 
            // cm_Paste
            // 
            this.cm_Paste.Name = "cm_Paste";
            this.cm_Paste.Size = new System.Drawing.Size(139, 22);
            this.cm_Paste.Text = "Вставить";
            this.cm_Paste.Click += new System.EventHandler(this.cm_Paste_Click);
            // 
            // F_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 287);
            this.Controls.Add(this.rtb_Editor);
            this.Controls.Add(this.ms_MainMenu);
            this.MainMenuStrip = this.ms_MainMenu;
            this.Name = "F_TextEditor";
            this.Text = "Текстовый редактор";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.contextMenu_RTB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mb_File;
        private System.Windows.Forms.ToolStripMenuItem mb_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveFileAs;
        private System.Windows.Forms.OpenFileDialog openTxtDialog;
        private System.Windows.Forms.SaveFileDialog saveTxtDialog;
        private System.Windows.Forms.RichTextBox rtb_Editor;
        private System.Windows.Forms.ToolStripMenuItem mb_fileClose;
        private System.Windows.Forms.ContextMenuStrip contextMenu_RTB;
        private System.Windows.Forms.ToolStripMenuItem cm_Copy;
        private System.Windows.Forms.ToolStripMenuItem cm_Cut;
        private System.Windows.Forms.ToolStripMenuItem cm_Paste;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

