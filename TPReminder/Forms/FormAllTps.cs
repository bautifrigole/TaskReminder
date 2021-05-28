using System;
using System.Windows.Forms;
using System.IO;
using TPReminder.Scripts.Controllers;

namespace TPReminder.Forms
{
    public partial class FormAllTps : Form
    {
        public FormAllTps()
        {
            InitializeComponent();
            
            if (ProgramController.GetTasks() == null) return;
            var tasksAmount = ProgramController.GetTasks().Count;

            if (tasksAmount > 1)
            {
                lblTpsToDoTitle.Text = "Los trabajos a realizar son los siguientes:";
            }
            else if (tasksAmount == 1)
            {
                lblTpsToDoTitle.Text = "El trabajo a realizar es el siguiente:";
            }
            else if (tasksAmount == 0)
            {
                lblTpsToDoTitle.Text = "¡No tienes ninguna tarea por entregar! ¡Puedes descansar!";
            }
            
            lblTpsToDo.Text = ProgramController.GetAllTasksToDoText();
        }
    }
}