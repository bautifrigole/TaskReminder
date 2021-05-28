using System;
using System.Collections.Generic;
using TPReminder.Scripts.Domain;

namespace TPReminder.Scripts.Controllers
{
    public class TaskController
    {
        private List<Task> _tasks = new List<Task>();

        public void CreateTask(string title, DateTime date, string subject)
        {
            var task = new Task(title, date, subject);
            _tasks.Add(task);
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