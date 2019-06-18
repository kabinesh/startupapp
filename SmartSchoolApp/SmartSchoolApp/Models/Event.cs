using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolApp.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public int ImageCount { get; set; }

        public string Date { get; set; }

        public List<string> Images { get; set; }
    }
}
