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
            ProgramController.AllTpsToDo = null;
            
            InitializeComponent();

            DirectorySearch(ProgramController.path);
            
            if (ProgramController.TpToDo > 1)
            {
                lblTpsToDoTitle.Text = "Los trabajos a realizar son los siguientes:";
            }
            else if (ProgramController.TpToDo == 1)
            {
                lblTpsToDoTitle.Text = "El trabajo a realizar es el siguiente:";
            }
            else if (ProgramController.TpToDo == 0)
            {
                lblTpsToDoTitle.Text = "¡No tienes ninguna tarea por entregar! ¡Puedes descansar!";
            }
            
            lblTpsToDo.Text = ProgramController.AllTpsToDo;
        }
        
        private static void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    ProgramController.AllTpsToDo += (Path.GetFileNameWithoutExtension(f)) + "\n" + "\n";
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}