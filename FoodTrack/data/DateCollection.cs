using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodTrack.data
{
    /// <summary>
    /// Static class contains List of Date objects.
    /// Starts with the 'current date' (when the program is run), and has more dates added as they are 
    /// chosen on the Form's calendar.
    /// </summary>
    public static class DateCollection
    {
        private static readonly List<Date> Calendar = new List<Date>();

        /// <summary>
        /// Returns list of Date objects
        /// </summary>
        /// <returns>List of Date objects</returns>
        public static List<Date> GetCalendar() => Calendar;

    }//end class
}
