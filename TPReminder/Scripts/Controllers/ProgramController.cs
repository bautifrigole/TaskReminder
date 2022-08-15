using System;
using System.Collections.Generic;
using System.Drawing;
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
        private static bool _hasStartWithWindows = true;

        public static int TasksToDoAmount;
        public static int DaysToSubmitNextTask;

        public static MainForm MainForm;
        public static FormHome FormHome;
        public static FormAllTps FormAllTps;
        public static FormAddNewTask FormAddNewTask;
        public static FormSettings FormSettings;

        [STAThread]
        private static void Main()
        {
            // Ask to set in the start up
            SetAppInStartup();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();
            MainForm.Location = new Point(0, 0);
            Application.Run(MainForm);
        }

        public static void UpdateFormsInfo()
        {
            FormHome.UpdateInfo();
            FormAllTps.UpdateTasksText();
        }

        public static TaskController GetTaskController()
        {
            return TaskController;
        }
        
        public static List<Task> GetTasks()
        {
            return TaskController.GetTasks();
        }
        
        public static void DeleteTask(Task task)
        {
            TaskController.DeleteTask(task);
        }
        
        public static void SaveTasks()
        {
            TaskController.SaveTasks();
        }

        public static int GetDaysToSubmitNextTask()
        {
            if (TaskController.GetTasks() != null && TaskController.GetTasks().Count != 0)
            {
                var yearDifference = DateTime.Now.Year - TaskController.GetTasks()[0].GetDate().Year;
                if (yearDifference == 0)
                    DaysToSubmitNextTask = TaskController.GetTasks()[0].GetDate().DayOfYear - DateTime.Now.DayOfYear;
                else
                    DaysToSubmitNextTask = TaskController.GetTasks()[0].GetDate().DayOfYear - DateTime.Now.DayOfYear 
                                           - 365*yearDifference;
            }
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
            return TaskController.GetTasks().Aggregate("", (current, t) => current + t.GetTaskInfo() + "\n" + "\n");
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
    }
}