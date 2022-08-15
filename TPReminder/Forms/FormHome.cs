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
                lblWelcome.Text = "Buen día,";
            }
            else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 20)
            {
                lblWelcome.Text = "Buenas tardes,";
            }
            else if(DateTime.Now.Hour >= 20 || DateTime.Now.Hour < 6)
            {
                lblWelcome.Text = "Buenas noches,";
            }
        }
        
        private void UpdateTasksToDoQuantity()
        {
            var tasksToDoQuantity = ProgramController.GetAllTasksToDoQuantity();
            
            if (tasksToDoQuantity > 1)
            {
                lblTpToDo.Text = "Tienes " + tasksToDoQuantity + " tareas por entregar";
            }
            else if (tasksToDoQuantity == 1)
            {
                lblTpToDo.Text = "Tienes " + tasksToDoQuantity + " tarea por entregar";
            }
            else if (tasksToDoQuantity == 0)
            {
                lblTpToDo.Text = "¡Yuju! ¡No tienes ninguna tarea por entregar!";
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

            var keyTask = nextTasks.Count == 1 ? "el trabajo" : "los trabajos";
            if (daysToSubmitNextTask > 1)
            {
                lblNextTp.Text = "Faltan " + daysToSubmitNextTask + " días para entregar "+keyTask+": \n" +
                                 nextTaskToSubmitName;
            }
            else if (daysToSubmitNextTask == 1)
            {
                lblNextTp.Text = "Mañana debes entregar "+keyTask+": \n" + nextTaskToSubmitName;
            }
            else if (daysToSubmitNextTask == 0)
            {
                lblNextTp.Text = "Hoy debes entregar "+keyTask+": \n" + nextTaskToSubmitName;
            }
            else if (daysToSubmitNextTask < 0)
            {
                lblNextTp.Text = "Debías entregar hace " + (daysToSubmitNextTask * -1) + " días "+keyTask+": \n" +
                                 nextTaskToSubmitName;
            }
        }
    }
}