using System;
using System.Windows.Forms;
using System.IO;

namespace TPReminder
{
    public partial class FormAllTps : Form
    {
        public FormAllTps()
        {
            Program.AllTpsToDo = null;
            
            InitializeComponent();

            DirectorySearch(Program.path);
            
            if (Program.TpToDo > 1)
            {
                lblTpsToDoTitle.Text = "Los trabajos a realizar son los siguientes:";
            }
            else if (Program.TpToDo == 1)
            {
                lblTpsToDoTitle.Text = "El trabajo a realizar es el siguiente:";
            }
            else if (Program.TpToDo == 0)
            {
                lblTpsToDoTitle.Text = "¡No tienes ninguna tarea por entregar! ¡Puedes descansar!";
            }
            
            lblTpsToDo.Text = Program.AllTpsToDo;
        }
        
        private static void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    Program.AllTpsToDo += (Path.GetFileNameWithoutExtension(f)) + "\n" + "\n";
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}