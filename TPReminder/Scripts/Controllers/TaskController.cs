using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using TPReminder.Scripts.Domain;

namespace TPReminder.Scripts.Controllers
{
    public class TaskController
    {
        private static readonly string TasksToDoPath = Application.StartupPath + "/TasksToDo";
        private List<Task> _tasks = new List<Task>();
        private List<string> _tasksJson = new List<string>();

        public TaskController()
        {
            LoadTasks();
        }

        public void CreateTask(string title, DateTime date, string subject)
        {
            var task = new Task(title, date, subject);
            _tasks.Add(task);
            SaveTask(task);
        }

        private void SaveTask(Task task)
        {
            _tasksJson.Add(JsonConvert.SerializeObject(task, Formatting.Indented));
            MessageBox.Show("¡Creada con éxito!" + "\n" + task.GetTaskInfo());
            
            using (var file = File.CreateText(TasksToDoPath))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, _tasksJson);
            }
        }
        
        private void LoadTasks()
        {
            if (!File.Exists(TasksToDoPath)) return;
            using (var file = File.OpenText(TasksToDoPath))
            {
                var serializer = new JsonSerializer();
                _tasksJson = (List<string>)serializer.Deserialize(file, typeof(List<string>));
                _tasksJson?.ForEach(t => _tasks.Add(JsonConvert.DeserializeObject<Task>(t)));
            }
        }

        public List<Task> GetTasks()
        {
            return _tasks;
        }

        public Task GetNextTaskToSubmit()
        {
            return _tasks[0];
        }
    }
}