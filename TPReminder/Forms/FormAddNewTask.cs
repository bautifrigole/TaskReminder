using System;
using System.Windows.Forms;
using TaskReminder.Scripts.Controllers;

namespace TaskReminder.Forms
{
    public partial class FormAddNewTask : Form
    {
        public FormAddNewTask()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ProgramController.GetTaskController().CreateTask(nameTextBox.Text, dateTimePicker1.Value, subjectTextBox.Text);
            ProgramController.UpdateFormsInfo();
        }
    }
}