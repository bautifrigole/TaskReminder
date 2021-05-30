using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using TPReminder.Forms;
using TPReminder.Scripts.Domain;

namespace TPReminder.Scripts.Controllers
{
    internal static class ProgramController
    {
        private static readonly TaskController TaskController = new TaskController();
        private static readonly string Path = Application.StartupPath + "/TPsToDo";
        private static bool _hasStartWithWindows = true;

        public static int TasksToDoAmount;
        public static int DaysToSubmitNextTask;
        
        [STAThread]
        private static void Main()
        {
            // Ask to set in the start up
            SetAppInStartup();
            //InitializeTpFolder();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());
        }

        public static TaskController GetTaskController()
        {
            return TaskController;
        }
        
        public static List<Task> GetTasks()
        {
            return TaskController.GetTasks();
        }

        public static int GetDaysToSubmitNextTask()
        {
            if (TaskController.GetTasks() != null && TaskController.GetTasks().Count != 0)
                DaysToSubmitNextTask = TaskController.GetTasks()[0].GetDate().DayOfYear - DateTime.Now.DayOfYear;
            return DaysToSubmitNextTask;
        }
        
        public static int GetAllTasksToDoQuantity()
        {
            if (TaskController.GetTasks() != null)
                TasksToDoAmount = TaskController.GetTasks().Count;
            return TasksToDoAmount;
        }
        
        public static string GetAllTasksToDoText()
        {
            return TaskController.GetTasks().Aggregate("", (current, t) => 
                current + "\n" + "Tarea: " + t.GetTitle() + "\n" + "    Materia: " + t.GetSubject() + "\n" + "    Fecha de entrega: " + t.GetDate().Day);
        }

        public static void SetHasStartWithWindows(bool value)
        {
            _hasStartWithWindows = value;
        }

        private static void SetAppInStartup()
        {
            var registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (_hasStartWithWindows)
            {
                registryKey?.SetValue("TPReminder", Application.ExecutablePath);
            }
            else
            {
                if(registryKey?.GetValue("TPReminder") != null)
                    registryKey?.DeleteValue("TPReminder");
            }
        }

        private static void InitializeTaskFolder()
        {
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
        }

        /*private static void FindNextTask()
        {
            foreach (string f in Directory.GetFiles(path))
            {
                CurrentTpPath = Path.GetFileNameWithoutExtension(f);
                Console.WriteLine("CurrentTpPath: " + CurrentTpPath);
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

        private static void SetAllTasksNames()
        {
            foreach (var t in TaskController.GetTasks())
            {
                AllTasksToDoText = AllTasksToDoText + Environment.NewLine + "Tarea: " +t.GetTitle() + Environment.NewLine +
                             "    Materia: " + t.GetSubject() + Environment.NewLine +
                             "    Fecha de entrega: "+ t.GetDate().Day;
            }

            //DirectorySearch(path);
        }
        
        private static void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    AllTasksToDoText = (System.IO.Path.GetFileNameWithoutExtension(f));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}