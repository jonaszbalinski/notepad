using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormThemes : Form
    {
        private string choosenTheme;
        public string ChoosenTheme
        {
            get => choosenTheme;
            set => choosenTheme = value;
        }

        public FormThemes()
        {
            InitializeComponent();
        }

        private void ButtonThemeWhite_Click(object sender, EventArgs e)
        {
            ChoosenTheme = "white";
            this.Close();
        }

        private void ButtonThemeDark_Click(object sender, EventArgs e)
        {
            ChoosenTheme = "dark";
            this.Close();
        }
    }
}
