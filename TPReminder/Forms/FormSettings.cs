using System;
using System.Windows.Forms;

namespace TPReminder
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void iconButtonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)  
            {
                Program.path = folderBrowserDialog.SelectedPath;
            }
        }
    }
}