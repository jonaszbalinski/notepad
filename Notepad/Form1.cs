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
        private bool isFileSaved = false;
        private String pathToFile = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files|*.txt|BAT files|*.bat|All|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                NotepadTextBox.Text = File.ReadAllText(ofd.FileName);
                MainWindow.ActiveForm.Text = ofd.FileName;
                pathToFile = ofd.FileName;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pathToFile != "")
            {
                File.WriteAllText(pathToFile, NotepadTextBox.Text);
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
                MainWindow.ActiveForm.Text = sfd.FileName;
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
    }
}
