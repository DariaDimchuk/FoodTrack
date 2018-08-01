using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrack.data
{
    /// <summary>
    /// Sets maximum calorie and nutrient goals for the program.
    /// </summary>
    static class GoalSettings
    {

        public const int DEFAULT_CALORIES = 2000;
        public const int DEFAULT_CARBS = 150;
        public const int DEFAULT_FAT = 50;
        public const int DEFAULT_PROTEIN = 80;

        public const int MINIMUM_CALORIES = 1000;
        public const int MINIMUM_NUTRIENT_VALUE = 0;


        private static int calorieGoal = DEFAULT_CALORIES;
        private static int carbGoal = DEFAULT_CARBS;
        private static int fatGoal = DEFAULT_FAT;
        private static int proteinGoal = DEFAULT_PROTEIN;

        public static int CalorieGoal() => calorieGoal;
        public static int CarbGoal() => carbGoal;
        public static int FatGoal() => fatGoal;
        public static int ProteinGoal() => proteinGoal;
        

        /// <summary>
        /// Sets all maximum goals.
        /// </summary>
        /// <param name="tracker">Tracker to set the goals on.</param>
        /// <param name="calorieGoal">calories value to set to</param>
        /// <param name="carb">carbs value to set to</param>
        /// <param name="fat">fat value to set to</param>
        /// <param name="protein">protein value to set to</param>
        public static void SetAllSettings(DailyTracker tracker, int calorieGoal, int carb, int fat, int protein)
        {
            SetCalorieGoal(tracker, calorieGoal);
            SetCarbGoal(tracker, carb);
            SetFatGoal(tracker, fat);
            SetProteinGoal(tracker, protein);
        }//end method


        /// <summary>
        /// Set maximum calories
        /// </summary>
        /// <param name="tracker">tracker to set values on</param>
        /// <param name="cal">value to set to</param>
        /// <returns>true if setting succeeded, false if failed</returns>
        public static bool SetCalorieGoal(DailyTracker tracker, int cal)
        {
            if (cal >= MINIMUM_CALORIES)
            {
                calorieGoal = cal;
                tracker.SetCalorieGoal(cal);
                return true;
            }
            else return false;
        }//end method


        /// <summary>
        /// Set maximum carbs
        /// </summary>
        /// <param name="tracker">tracker to set values on</param>
        /// <param name="carb">value to set to</param>
        /// <returns>true if setting succeeded, false if failed</returns>
        public static bool SetCarbGoal(DailyTracker tracker, int carb)
        {
            if (carb >= MINIMUM_NUTRIENT_VALUE)
            {
                carbGoal = carb;
                tracker.SetCarbsGoal(carb);
                return true;
            }
            else return false;
        }//end method


        /// <summary>
        /// Set maximum fat
        /// </summary>
        /// <param name="tracker">tracker to set values on</param>
        /// <param name="fat">value to set to</param>
        /// <returns>true if setting succeeded, false if failed</returns>
        public static bool SetFatGoal(DailyTracker tracker, int fat)
        {
            if (fat >= MINIMUM_NUTRIENT_VALUE)
            {
                fatGoal = fat;
                tracker.SetFatGoal(fat);
                return true;
            }
            else return false;
        }//end method


        /// <summary>
        /// Set maximum protein
        /// </summary>
        /// <param name="tracker">tracker to set values on</param>
        /// <param name="protein"></param>
        /// <returns>true if setting succeeded, false if failed</returns>
        public static bool SetProteinGoal (DailyTracker tracker, int protein)
        {
            if (protein >= MINIMUM_NUTRIENT_VALUE)
            {
                proteinGoal = protein;
                tracker.SetProteinGoal(protein);
                return true;
            }
            else return false;
        }//end method

    }//end class
}
