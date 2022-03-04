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
    public partial class mainWindow : Form
    {
        private bool isFileSaved = false;
        private String pathToFile = "";

        public mainWindow()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files|*.txt|BAT files|*.bat|All|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                notepadTextBox.Text = File.ReadAllText(ofd.FileName);
                mainWindow.ActiveForm.Text = ofd.FileName;
                pathToFile = ofd.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pathToFile != "")
            {
                File.WriteAllText(pathToFile, notepadTextBox.Text);
            }
            else
            {
                saveAsToolStripMenuItem.PerformClick();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT files|*.txt|BAT files|*.bat|All|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, notepadTextBox.Text);
                mainWindow.ActiveForm.Text = sfd.FileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileSaved == false)
            {
                DialogResult saveDialog = MessageBox.Show("Do you want to save?",
                    "Save", MessageBoxButtons.YesNo);
                if (saveDialog == DialogResult.Yes)
                {
                    saveToolStripMenuItem.PerformClick();
                }
            }

            pathToFile = "";
            notepadTextBox.Text = "";
            mainWindow.ActiveForm.Text = "New file";
        }
    }
}
