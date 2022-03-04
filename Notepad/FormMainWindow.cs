using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainWindow : Form
    {
        private bool isFileSaved = true;
        private String pathToFile = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateIsFileSaved(bool isSaved)
        {
            if(isFileSaved != isSaved)
            {
                if(isSaved == true)
                {
                    MainWindow.ActiveForm.Text = Path.GetFileName(pathToFile);
                }
                else
                {
                    MainWindow.ActiveForm.Text += "*";
                }
            }
            isFileSaved = isSaved;
        }

        private void UpdateTheme(string theme)
        {
            switch (theme)
            {
                case "white":
                    MainWindow.ActiveForm.BackColor = Color.WhiteSmoke;
                    MainWindow.ActiveForm.ForeColor = Color.Black;
                    menuStrip1.BackColor = Color.FloralWhite;
                    menuStrip1.ForeColor = Color.Black;
                    NotepadTextBox.BackColor = Color.AntiqueWhite;
                    NotepadTextBox.ForeColor = Color.Black;
                    break;

                case "dark":
                    MainWindow.ActiveForm.BackColor = Color.DarkCyan;
                    MainWindow.ActiveForm.ForeColor = Color.White;
                    menuStrip1.BackColor = Color.DarkGray;
                    menuStrip1.ForeColor = Color.WhiteSmoke;
                    NotepadTextBox.BackColor = Color.DarkSlateGray;
                    NotepadTextBox.ForeColor = Color.White;
                    break;
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileSaved == false)
            {
                DialogResult saveDialog = MessageBox.Show("Do you want to save?",
                    "Save", MessageBoxButtons.YesNo);
                if (saveDialog == DialogResult.Yes)
                {
                    SaveToolStripMenuItem.PerformClick();
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files|*.txt|BAT files|*.bat|All|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                NotepadTextBox.Text = File.ReadAllText(ofd.FileName);
                MainWindow.ActiveForm.Text = Path.GetFileName(ofd.FileName);
                pathToFile = ofd.FileName;
                isFileSaved = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pathToFile != "")
            {
                File.WriteAllText(pathToFile, NotepadTextBox.Text);
                UpdateIsFileSaved(true);
            }
            else
            {
                SaveAsToolStripMenuItem.PerformClick();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT files|*.txt|BAT files|*.bat|All|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, NotepadTextBox.Text);
                MainWindow.ActiveForm.Text = Path.GetFileName(sfd.FileName);
                pathToFile = sfd.FileName;
                isFileSaved = true;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileSaved == false)
            {
                DialogResult saveDialog = MessageBox.Show("Do you want to save?",
                    "Save", MessageBoxButtons.YesNo);
                if (saveDialog == DialogResult.Yes)
                {
                    SaveToolStripMenuItem.PerformClick();
                }
            }

            pathToFile = "";
            NotepadTextBox.Text = "";
            MainWindow.ActiveForm.Text = "New file";
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFileSaved == false)
            {
                DialogResult saveDialog = MessageBox.Show("Do you want to save?",
                    "Save", MessageBoxButtons.YesNo);
                if (saveDialog == DialogResult.Yes)
                {
                    SaveToolStripMenuItem.PerformClick();
                }
            }
        }

        private void NotepadTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateIsFileSaved(false);
        }

        private void ThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemes ft = new FormThemes();
            ft.ShowDialog();
            UpdateTheme(ft.ChoosenTheme);
        }
    }
}
