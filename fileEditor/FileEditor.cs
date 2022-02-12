using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace fileEditor
{
    class FileEditor
    {
        string filePath = "";

        public FileEditor(string filePath)
        {
            this.filePath = filePath;
        }

        void WriteText(string text)
        {
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(text);
            sw.Close();
        }

        public List<string> ReadFile()
        {
            List<string> lines = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            return lines;
        }


        public void WriteFile(string text)
        {
            try
            {
                WriteText(text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }

        public void WriteFileAs(string text, string newFilePath)
        {
            try
            {
                filePath = newFilePath;
                WriteText(text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }
    }
}
