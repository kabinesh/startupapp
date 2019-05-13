using System;

namespace SmartSchoolApp.Models
{
    public class GroupMessage
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

        public DateTime DateTime { get; set; }

        public string AuthorName { get; set; }

        public string PublishedInfo
        {
            get
            {
                return DateTime.ToShortDateString() + " by " + AuthorName;
            }
        }
    }
}
