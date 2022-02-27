using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace БЛОКНОТ
{
    public partial class Form1 : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;

        public string filename;
        public bool IsFileChanged;

        public FontSettings fontSetts;

        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            filename = "";
            IsFileChanged = false;
        }

       
       
        private void CreateNewFile_Click(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            richTextBox1.Text = "";
            filename = "";
            IsFileChanged = false;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            SaveUnsavedFile();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = ofd.FileName;
                    IsFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Не удалось открыть файл");
                }
            }
        }

        public void Save(string _filename)
        {

            if(_filename == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    _filename = sfd.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename + ".txt");
                sw.Write(richTextBox1.Text);
                sw.Close();
                filename = _filename;
                IsFileChanged = false;

            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл");
            }
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            Save(filename);
        }
        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            Save("");
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
           
            if(!IsFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                IsFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        public void SaveUnsavedFile()
        {
            if(IsFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?","Сохранение файла",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1); 
                if(result == DialogResult.Yes)
                {
                    Save(filename);
                }
            }
        }

      
        private void CopeText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void CutText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }

        private void PasteText_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void OnFont_Click(object sender, EventArgs e)
        {
            fontSetts = new FontSettings();
            fontSetts.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if(fontSetts != null)
            {
                fontSize = fontSetts.fontSize;
                fs = fontSetts.fs;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize, fs);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
