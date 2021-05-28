using System;
using System.Windows.Forms;
using TPReminder.Scripts.Controllers;

namespace TPReminder.Forms
{
    public partial class FormAddNewTask : Form
    {
        public FormAddNewTask()
        {
            InitializeComponent();
        }

        private void iconButtonBrowse_Click(object sender, EventArgs e)
        {
            ProgramController.GetTaskController().CreateTask(nameTextBox.Text, dateTimePicker1.Value, subjectTextBox.Text);
        }
    }
}