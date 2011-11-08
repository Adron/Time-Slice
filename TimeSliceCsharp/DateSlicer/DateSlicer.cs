using System;
using System.Collections.Generic;

namespace DateSlicer
{
    public class DateSlicer
    {
        private DateTime dateAndTime;
        private readonly char delimiter = Convert.ToChar(@"/");

        public DateSlicer(DateTime dateTime)
        {
            dateAndTime = dateTime;
            months = GetMonths();
        }

        public static Dictionary<int, string> GetMonths()
        {
            return new Dictionary<int, string>
                       {
                           {1, "January"},
                           {2, "February"},
                           {3, "March"},
                           {4, "April"},
                           {5, "May"},
                           {6, "June"},
                           {7, "July"},
                           {8, "August"},
                           {9, "September"},
                           {10, "October"},
                           {11, "November"},
                           {12, "December"}
                       };
        }

        protected Dictionary<int, string> months { get; set; }

        public string MonthName()
        {
            return GetMonths()[dateAndTime.Month];
        }

        public DateTime FirstOfMonth()
        {
            string dateToParse = string.Format("{1}{0}{2}{0}{3}", delimiter, dateAndTime.Month, 1, dateAndTime.Year);
            return DateTime.Parse(dateToParse);
        }

        public DateTime LastOfMonth()
        {
            string dateToParse = string.Format("{1}{0}{2}{0}{3}", delimiter, dateAndTime.Month, 1, dateAndTime.Year);
            return DateTime.Parse(dateToParse).AddMonths(1).AddDays(-1);
        }
    }
}
