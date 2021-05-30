using System;
using System.Windows.Forms;
using TPReminder.Scripts.Controllers;

namespace TPReminder.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ProgramController.SetHasStartWithWindows(startupCheckBox.Checked);
        }
    }
}