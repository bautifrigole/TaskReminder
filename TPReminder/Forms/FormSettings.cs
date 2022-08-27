using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TaskReminder.Scripts.Controllers;

namespace TaskReminder.Forms
{
    public partial class FormSettings : Form
    {
        private List<CheckBox> _checkboxes;
        public FormSettings()
        {
            InitializeComponent();
            _checkboxes = new List<CheckBox>{ startupCheckBox, notificationsCheckBox };
            LoadSettingsValues();
        }

        private void LoadSettingsValues()
        {
            var settings = ProgramController.SaveSystem.GetSettingsData();
            if (settings == null || settings.Count == 0) return;
            foreach (var setting in settings)
            {
                var first = _checkboxes?.FirstOrDefault(c => setting.Name == c.Name);
                if (first != null) first.Checked = setting.Value;
            }
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