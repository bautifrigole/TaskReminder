using System.Collections.Generic;
using System.Windows.Forms;
using TaskReminder.Scripts.Controllers;
using TaskReminder.Scripts.Domain;

namespace TaskReminder.Forms
{
    public partial class FormAllTps : Form
    {
        private List<TaskBlock> _taskBlocks = new List<TaskBlock>();
        
        public FormAllTps()
        {
            InitializeComponent();
            UpdateTasksText();
        }

        public void UpdateTasksText()
        {
            if (ProgramController.GetTasks() == null) return;
            var tasksAmount = ProgramController.GetTasks().Count;

            if (tasksAmount > 1)
            {
                lblTpsToDoTitle.Text = "The tasks to be carried out are the following:";
            }
            else if (tasksAmount == 1)
            {
                lblTpsToDoTitle.Text = "The task to be carried out is the following:";
            }
            else if (tasksAmount == 0)
            {
                lblTpsToDoTitle.Text = "You don't have any task to hand in! You can rest!";
            }
            
            var count = 0;
            if (_taskBlocks.Count > 0)
                foreach (var block in _taskBlocks)
                {
                    block.panel.Dispose();
                }
            
            foreach (var task in ProgramController.GetTasks())
            {
                count++;
                var taskBlock = new TaskBlock(task, flowLayoutPanel1, count);
                _taskBlocks.Add(taskBlock);
            }
        }
    }
}