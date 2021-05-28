using System;

namespace TPReminder.Scripts.Domain
{
    public class Task
    {
        private string Title { get; set; }
        private DateTime Date { get; set; }
        private string Subject { get; set; }

        public Task(string title, DateTime date, string subject)
        {
            Title = title;
            Date = date;
            Subject = subject;
        }
        
        public string GetTaskInfo()
        {
            return "Tarea: " + Title + "\n" + "    Materia: " + Subject + "\n" + "    Fecha de entrega: " + Date.Day;
        }

        public string GetTitle()
        {
            return Title;
        }
        public DateTime GetDate()
        {
            return Date;
        }

        public string GetSubject()
        {
            return Subject;
        }
        
        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public void SetSubject(string subject)
        {
            Subject = subject;
        }
    }
}