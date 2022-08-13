using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            AddTask(task);
        }
        
        public void DeleteTask(Task task)
        {
            _tasks.Remove(task);
            _tasksJson.Remove(JsonConvert.SerializeObject(task, Formatting.Indented));
            SaveTasks();
        }

        private void AddTask(Task task)
        {
            _tasksJson.Add(JsonConvert.SerializeObject(task, Formatting.Indented));
            MessageBox.Show("¡Creada con éxito!" + "\n" + task.GetTaskInfo());
            SaveTasks();
        }
        
        private void SaveTasks()
        {
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

        public List<Task> GetNextTasksToSubmit()
        {
            return _tasks.Where(t => t.Date.ToShortDateString() == _tasks[0].Date.ToShortDateString()).ToList();
        }
    }
}