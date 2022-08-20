using System;
using System.Windows.Forms;
using TaskReminder.Scripts.Controllers;

namespace TaskReminder.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            LoadSettingsValues();
        }

        private void LoadSettingsValues()
        {
            var settings = ProgramController.SaveSystem.GetSettingsData();
            if (settings == null || settings.Count == 0) return;
            startupCheckBox.Checked = settings[0].Value;
            notificationsCheckBox.Checked = settings[1].Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ProgramController.SetHasStartWithWindows(startupCheckBox.Checked);
            ProgramController.SaveSystem.AddSettingValue(startupCheckBox.Name, startupCheckBox.Checked);
        }

        private void notificationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ProgramController.SetSendNotifications(notificationsCheckBox.Checked);
            ProgramController.SaveSystem.AddSettingValue(notificationsCheckBox.Name, notificationsCheckBox.Checked);
        }
    }
}