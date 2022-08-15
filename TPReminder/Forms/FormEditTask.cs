using System;
using System.Windows.Forms;
using TPReminder.Scripts.Controllers;
using TPReminder.Scripts.Domain;

namespace TPReminder.Forms
{
    public partial class FormEditTask : Form
    {
        private Task _task;
        
        public FormEditTask(Task task)
        {
            _task = task;
            InitializeComponent();
            FillWithTaskInfo();
            
            dateTimePicker1.MinDate = DateTime.Today;
        }
        
        private void FillWithTaskInfo()
        {
            nameTextBox.Text = _task.Title;
            subjectTextBox.Text = _task.Subject;
            dateTimePicker1.Value = _task.Date;
            saveButton.Click += SaveEditButtonHandler;
        }
        
        private void SaveEditButtonHandler(object sender, EventArgs e)
        {
            _task.Title = nameTextBox.Text;
            _task.Subject = subjectTextBox.Text;
            _task.Date = dateTimePicker1.Value;
            ProgramController.SaveTasks();
            ProgramController.UpdateFormsInfo();
            Close();
        }
    }
}