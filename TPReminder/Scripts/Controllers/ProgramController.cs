using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using TPReminder.Forms;

namespace TPReminder.Scripts.Controllers
{
    internal static class ProgramController
    {
        public static string path = "C:/Users/bauti/OneDrive/Escritorio/TPs sin hacer";
        
        public static string CurrentTpPath;
        public static string CurrentTpName;
        public static string CurrentTpDay;
        public static string CurrentTpMonth;
        public static string AllTpsToDo;
        
        public static int TpToDo;
        public static int DaysToSubmit;
        
        [STAThread]
        private static void Main()
        {
            SetStartup();

            GetAllTpsToDoQuantity();
            FindNextTp();
            GetAllTpNames();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());
        }

        private static void GetAllTpsToDoQuantity()
        {
            foreach (string f in Directory.GetFiles(path))
            {
                TpToDo++;
            }
        }
        
        private static void FindNextTp()
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
            
            DateTime tpDate = new DateTime(20, Int32.Parse(CurrentTpMonth), Int32.Parse(CurrentTpDay));

            DaysToSubmit = tpDate.DayOfYear - DateTime.Now.DayOfYear;
        }

        private static void GetAllTpNames()
        {
            DirectorySearch(path);
        }
        
        private static void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    AllTpsToDo = (Path.GetFileNameWithoutExtension(f));
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