using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

/*
 * Requisitos para el correcto funcionamiento del programa:
 *     Indicar ruta de la carpeta con los trabajos sin hacer
 *     Colocar el siguiente formato de nombre para todos los archivos:
 *         "Mes.Día - Materia - Título del TP"
 *         Ej: "09.10 - FEC - CIERRE DE LOS DERECHOS HUMANOS"
 *         *Importante primero el mes, después el día
 */

namespace TPReminder
{
    static class Program
    {
        public static string path = "C:/Users/bauti/OneDrive/Escritorio/TPs sin hacer";
        
        public static string CurrentTpPath;
        public static string CurrentTpName;
        public static string CurrentTpDay;
        public static string CurrentTpMonth;
        public static string AllTpsToDo;
        
        public static int TpToDo;
        public static int DaysToSubmit;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetStartup();

            TpsToDo();
            NextTp();
            AllTps();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
        }

        private static void TpsToDo()
        {
            foreach (string f in Directory.GetFiles(path))
            {
                TpToDo++;
            }
        }
        
        private static void NextTp()
        {
            foreach (string f in Directory.GetFiles(path))
            {
                CurrentTpPath = Path.GetFileNameWithoutExtension(f);
                break;
            }

            if (CurrentTpPath == null) return;
            char[] b = new char[CurrentTpPath.Length];

            using (StringReader sr = new StringReader(CurrentTpPath))
            {
                // Read 2 characters from the string into the array. Month
                sr.Read(b, 0, 2);
                CurrentTpMonth = new string(b);
                
                // Remove 1 characters
                sr.Read(b, 0, 1);
                
                // Read 2 characters from the string into the array. Day
                sr.Read(b, 0, 2);
                CurrentTpDay = new string(b);
                
                // Remove 3 characters
                sr.Read(b, 0, 3);
                
                // Read the rest of the string starting at the current string position.
                sr.Read(b, 0, CurrentTpPath.Length);
                CurrentTpName = new string(b);
            }
            
            DateTime now = DateTime.Now;
            DateTime tpDate = new DateTime(20, Int32.Parse(CurrentTpMonth), Int32.Parse(CurrentTpDay));

            DaysToSubmit = Int32.Parse(CurrentTpDay) - now.Day;

            Console.WriteLine("Faltan " + DaysToSubmit + " días para entregar el trabajo '" + CurrentTpName + "'");
            Console.WriteLine("");
        }

        private static void AllTps()
        {
            Console.WriteLine("Los trabajos a realizar son los siguientes:");
            DirectorySearch(path);
        }
        
        private static void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    AllTpsToDo = (Path.GetFileNameWithoutExtension(f));
                    Console.WriteLine(AllTpsToDo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private static void SetStartup()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            registryKey?.SetValue("TPReminder", Application.ExecutablePath);
        }
    }
}