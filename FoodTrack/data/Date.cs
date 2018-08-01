using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrack.data
{

    /// <summary>
    /// Date class represents a date on the Form that has its own unique DailyTracker which contains all 
    /// the foods eaten on this day.
    /// </summary>
    public class Date
    {
        private DateTime date;
        private DailyTracker tracker;


        /// <summary>
        /// Create a new Date object using a DateTime date.
        /// Creates a new empty DailyTracker for the date.
        /// </summary>
        /// <param name="date">DateTime object</param>
        public Date(DateTime date)
        {
            this.date = date;
            tracker = new DailyTracker();
        }//end constructor



        /// <summary>
        /// Create a new Date object using values for year, month, and day.
        /// Creates a new empty DailyTracker for the date.
        /// </summary>
        /// <param name="year">Year of chosen date</param>
        /// <param name="month">Month of chosen date</param>
        /// <param name="day">Day of chosen date</param>
        public Date(int year, int month, int day)
        {
            this.date = new DateTime(year, month, day);
            tracker = new DailyTracker();
        }//end constructor



        /// <summary>
        /// Returns the DateTime date of this class.
        /// </summary>
        /// <returns>DateTime object</returns>
        public DateTime GetDate() => date;



        /// <summary>
        /// Compares the year, month and day of the current date and the parameter date.
        /// </summary>
        /// <param name="given"></param>
        /// <returns>True if dates are the same, false if they are different</returns>
        public bool DoDatesMatch(DateTime given)
        {
            if (this.date.Year == given.Year && this.date.Month == given.Month && this.date.Day == given.Day)
            {
                return true;
            }
            else return false;

        }//end method



        /// <summary>
        /// Returns the DailyTracker of this Date.
        /// </summary>
        /// <returns>unique DailyTracker object</returns>
        public DailyTracker GetDailyTracker() => tracker;

    }//end class
}
