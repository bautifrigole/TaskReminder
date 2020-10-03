using System;

namespace TPReminder.Scripts.Domain
{
    public class Task
    {
        private DateTime Date { get; set; }
        private string Subject { get; set; }
        private string Title { get; set; }

        public DateTime GetDate()
        {
            return Date;
        }

        public string GetSubject()
        {
            return Subject;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public void SetSubject(string subject)
        {
            Subject = subject;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }
    }
}