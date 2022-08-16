using System;
using System.Windows.Forms;
using TPReminder.Scripts.Controllers;

namespace TPReminder.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            GiveGreeting();
            UpdateTasksToDoQuantity();
            UpdateNextTaskToSubmitInfo();
        }

        public void UpdateInfo()
        {
            UpdateTasksToDoQuantity();
            UpdateNextTaskToSubmitInfo();
        }

        private void GiveGreeting()
        {
            if(DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                lblWelcome.Text = "Good morning,";
            }
            else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 20)
            {
                lblWelcome.Text = "Good evening,";
            }
            else if(DateTime.Now.Hour >= 20 || DateTime.Now.Hour < 6)
            {
                lblWelcome.Text = "Good night,";
            }
        }
        
        private void UpdateTasksToDoQuantity()
        {
            var tasksToDoQuantity = ProgramController.GetAllTasksToDoQuantity();
            
            if (tasksToDoQuantity > 1)
            {
                lblTpToDo.Text = "You have " + tasksToDoQuantity + " tasks to hand in";
            }
            else if (tasksToDoQuantity == 1)
            {
                lblTpToDo.Text = "You have " + tasksToDoQuantity + " task to hand in";
            }
            else if (tasksToDoQuantity == 0)
            {
                lblTpToDo.Text = "yoo-hoo! You don't have any homework to hand in!";
                lblNextTp.Text = "";
            }
        }

        private void UpdateNextTaskToSubmitInfo()
        {
            if (ProgramController.GetTasks().Count == 0) return;
            
            var daysToSubmitNextTask = ProgramController.GetDaysToSubmitNextTask();
            var nextTasks = ProgramController.GetTaskController().GetNextTasksToSubmit();
            var nextTaskToSubmitName = "";

            for (int i = 0; i < nextTasks.Count; i++)
            {
                if (i == 0)
                    nextTaskToSubmitName += nextTasks[i].Title;
                else if (i >= nextTasks.Count-1)
                    nextTaskToSubmitName += " y "+nextTasks[i].Title;
                else
                    nextTaskToSubmitName += ", "+nextTasks[i].Title;
            }

            var keyTask = nextTasks.Count == 1 ? "the task" : "the tasks";
            if (daysToSubmitNextTask > 1)
            {
                lblNextTp.Text = "There are " + daysToSubmitNextTask + " days left to hand in "+keyTask+": \n" +
                                 nextTaskToSubmitName;
            }
            else if (daysToSubmitNextTask == 1)
            {
                lblNextTp.Text = "Tomorrow you must hand in "+keyTask+": \n" + nextTaskToSubmitName;
            }
            else if (daysToSubmitNextTask == 0)
            {
                lblNextTp.Text = "Today you must hand in "+keyTask+": \n" + nextTaskToSubmitName;
            }
            else if (daysToSubmitNextTask < 0)
            {
                lblNextTp.Text = "You have to hand in " + keyTask + " "+ (daysToSubmitNextTask * -1) + " days ago: \n" +
                                 nextTaskToSubmitName;
            }
        }
    }
}