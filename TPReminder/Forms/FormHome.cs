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
            UpdateNextTpDay();
            UpdateNextTps();
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

        private void UpdateNextTpDay()
        {
            if (ProgramController.DaysToSubmit > 1)
            {
                lblNextTp.Text = "Faltan " + ProgramController.DaysToSubmit + " días para entregar el trabajo: \n" +
                                 ProgramController.CurrentTpName;
            }
            else if (ProgramController.DaysToSubmit == 1)
            {
                lblNextTp.Text = "Mañana debes entregar el trabajo: \n" + ProgramController.CurrentTpName;
            }
            else if (ProgramController.DaysToSubmit == 0)
            {
                lblNextTp.Text = "Hoy debes entregar el trabajo: \n" + ProgramController.CurrentTpName;
            }
            else if (ProgramController.DaysToSubmit < 0)
            {
                lblNextTp.Text = "Debías entregar hace " + (ProgramController.DaysToSubmit * -1) + " días el trabajo: \n" +
                                 ProgramController.CurrentTpName;
            }
        }

        private void UpdateNextTps()
        {
            if (ProgramController.TpToDo > 1)
            {
                lblTpToDo.Text = "Tienes " + ProgramController.TpToDo + " tareas por entregar";
            }
            else if (ProgramController.TpToDo == 1)
            {
                lblTpToDo.Text = "Tienes " + ProgramController.TpToDo + " tarea por entregar";
            }
            else if (ProgramController.TpToDo == 0)
            {
                lblTpToDo.Text = "¡Yuju! ¡No tienes ninguna tarea por entregar!";
                lblNextTp.Text = "";
            }
        }
    }
}