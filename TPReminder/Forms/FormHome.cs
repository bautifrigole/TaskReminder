using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace TPReminder
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
            if(DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
            {
                lblWelcome.Text = "Buen día,";
            }
            else if(DateTime.Now.Hour > 12 && DateTime.Now.Hour < 20)
            {
                lblWelcome.Text = "Buenas tardes,";
            }
            else if(DateTime.Now.Hour > 20 || DateTime.Now.Hour < 6)
            {
                lblWelcome.Text = "Buenas noches,";
            }
        }

        private void UpdateNextTpDay()
        {
            if (Program.DaysToSubmit > 1)
            {
                lblNextTp.Text = "Faltan " + Program.DaysToSubmit + " días para entregar el trabajo: \n" +
                                 Program.CurrentTpName;
            }
            else if (Program.DaysToSubmit == 1)
            {
                lblNextTp.Text = "Mañana debes entregar el trabajo: \n" + Program.CurrentTpName;
            }
            else if (Program.DaysToSubmit == 0)
            {
                lblNextTp.Text = "Hoy debes entregar el trabajo: \n" + Program.CurrentTpName;
            }
            else if (Program.DaysToSubmit < 0)
            {
                lblNextTp.Text = "Debías entregar hace " + (Program.DaysToSubmit * -1) + " días el trabajo: \n" +
                                 Program.CurrentTpName;
            }
        }

        private void UpdateNextTps()
        {
            if (Program.TpToDo > 1)
            {
                lblTpToDo.Text = "Tienes " + Program.TpToDo + " tareas por entregar";
            }
            else if (Program.TpToDo == 1)
            {
                lblTpToDo.Text = "Tienes " + Program.TpToDo + " tarea por entregar";
            }
            else if (Program.TpToDo == 0)
            {
                lblTpToDo.Text = "¡Yuju! ¡No tienes ninguna tarea por entregar!";
                lblNextTp.Text = "";
            }
        }
    }
}