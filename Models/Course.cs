using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_6.Models
{
    public class Course 
    {                                                   //Properties
        public string Code { get; } 
        public string Title { get; }

        private int weeklyHours; 

        public int WeeklyHours
        {
            get { return weeklyHours; } // Read property for WeeklyHours
            set { weeklyHours = value; } // Write property for WeeklyHours
        }
        public Course(string code, string title) // Constructor
        {
            Code = code;
            Title = title;
        }
    }
}