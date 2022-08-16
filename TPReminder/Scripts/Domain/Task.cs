using System;

namespace TPReminder.Scripts.Domain
{
    public class Task
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }

        public Task(string title, DateTime date, string subject)
        {
            Title = title;
            Date = date;
            Subject = subject;
        }
        
        public string GetTaskInfo()
        {
            return "Task: " + Title + "\n" + "Subject: " + Subject + "\n" + "Due date: " + Date.ToShortDateString();
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