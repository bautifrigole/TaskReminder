using System.Windows.Forms;

namespace TPReminder
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            
            if (Program.DaysToSubmit > 0)
            {
                lblNextTp.Text = "Faltan " + Program.DaysToSubmit + " días para entregar el trabajo: \n" +
                                 Program.CurrentTpName;
            }
            else if (Program.DaysToSubmit == 0)
            {
                lblNextTp.Text = "Hoy debes entregar el trabajo: \n" +
                                 Program.CurrentTpName;
            }
            else if (Program.DaysToSubmit < 0)
            {
                lblNextTp.Text = "Debías entregar hace " + (Program.DaysToSubmit * -1) + " días el trabajo: \n" +
                                 Program.CurrentTpName;
            }
            
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