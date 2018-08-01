using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodTrack.data;

namespace FoodTrack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Date currentDate = new Date(DateTime.Now);   
            DateCollection.GetCalendar().Add(currentDate);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(currentDate));

        }//end Main()
        
    }//end class
}
