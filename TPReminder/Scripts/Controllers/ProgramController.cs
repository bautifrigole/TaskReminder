using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using TaskReminder.Forms;
using TaskReminder.Scripts.Domain;
using TaskReminder.Scripts.Systems;

namespace TaskReminder.Scripts.Controllers
{
    internal static class ProgramController
    {
        private static readonly TaskController TaskController = new TaskController();
        public static readonly SaveSystem SaveSystem = new SaveSystem();
        
        private static bool _hasStartWithWindows = true;
        private static bool _sendNotifications = true;

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
        
        public static void SaveData()
        {
            SaveSystem.Save();
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
            SetAppInStartup();
        }
        
        public static void SetSendNotifications(bool value)
        {
            _sendNotifications = value;
        }

        public static void SendNotification(string title, string body)
        {
            _sendNotifications = SaveSystem.GetSettingsData()[1].Value;
            if (!_sendNotifications) return;
            new ToastContentBuilder()
                .AddText(title)
                .AddText(body)
                .Show();
        }

        private static void SetAppInStartup()
        {
            var registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (_hasStartWithWindows)
            {
                registryKey?.SetValue("TaskReminder", Application.ExecutablePath);
            }
            else
            {
                if(registryKey?.GetValue("TaskReminder") != null)
                    registryKey?.DeleteValue("TaskReminder");
            }
        }
    }
}