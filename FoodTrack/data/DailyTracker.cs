using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FoodTrack.data
{

    /// <summary>
    /// Represents a meal time.
    /// Breakfast, Lunch or Dinner.
    /// </summary>
    public enum Meal
    {
        BREAKFAST,
        LUNCH,
        DINNER
    }


    /// <summary>
    /// DailyTracker contains lists of foods eaten at different meals, contains its nutrient goals, 
    /// and tracks current nutrient values.
    /// A unique DailyTracker should belong to a Date object, so each date represents a new day 
    /// of meals/foods eaten.
    /// </summary>
    public class DailyTracker
    {
        private int calorieGoal = GoalSettings.CalorieGoal();
        private int carbsGoal = GoalSettings.CarbGoal();
        private int fatGoal = GoalSettings.FatGoal();
        private int proteinGoal = GoalSettings.ProteinGoal();

        private int currentCalories = 0;
        private int currentCarbs = 0;
        private int currentFat = 0;
        private int currentProtein = 0;

        private BindingList<FoodItem> breakfast = new BindingList<FoodItem>();
        private BindingList<FoodItem> lunch = new BindingList<FoodItem>();
        private BindingList<FoodItem> dinner = new BindingList<FoodItem>();
        

        /// <summary>
        /// Create new DailyTracker with empty meal lists and default nutrient goals.
        /// </summary>
        public DailyTracker(){}


        public int GetCalorieGoal() => calorieGoal;
        public int GetProteinGoal() => proteinGoal;
        public int GetFatGoal() => fatGoal;
        public int GetCarbsGoal() => carbsGoal;
        
        
        public int GetCurrentCalories() => currentCalories;
        public int GetCurrentCarbs() => currentCarbs;
        public int GetCurrentFat() => currentFat;
        public int GetCurrentProtein() => currentProtein;


        public int GetTotalBreakfastCalories() => GetMealCalories(Meal.BREAKFAST);
        public int GetTotalLunchCalories() => GetMealCalories(Meal.LUNCH);
        public int GetTotalDinnerCalories() => GetMealCalories(Meal.DINNER);


        public BindingList<FoodItem> GetBreakfast() => breakfast;
        public BindingList<FoodItem> GetLunch() => lunch;
        public BindingList<FoodItem> GetDinner() => dinner;


        /// <summary>
        /// Sets all nutrient goals simultaniously. Must pass validation.
        /// </summary>
        /// <param name="calorieGoal">Maximum calories for the day</param>
        /// <param name="carbsGoal">Maximum carbs for the day</param>
        /// <param name="fatGoal">Maximum fat for the day</param>
        /// <param name="proteinGoal">Maximum protein for the day</param>
        public void SetGoals(int calorieGoal, int carbsGoal, int fatGoal, int proteinGoal)
        {
            SetCalorieGoal(calorieGoal);
            SetCarbsGoal(carbsGoal);
            SetFatGoal(fatGoal);
            SetProteinGoal(proteinGoal);
        }//end method



        /// <summary>
        /// Sets the maximum calories for the day. Must be a minimum of 1000.
        /// If below minimum, a safe default will be set.
        /// </summary>
        /// <param name="calories"></param>
        public void SetCalorieGoal(int calories)
        {
            if (calorieGoal > GoalSettings.MINIMUM_CALORIES)
            {
                this.calorieGoal = calories;
            }
            else this.calorieGoal = GoalSettings.CalorieGoal();

        }//end method


        /// <summary>
        /// Sets the maximum carbs for the day. Must be above 0.
        /// If below 0, a safe default will be set.
        /// </summary>
        /// <param name="carbs"></param>
        public void SetCarbsGoal(int carbs)
        {
            if (carbsGoal > GoalSettings.MINIMUM_NUTRIENT_VALUE)
            {
                this.carbsGoal = carbs;
            }
            else this.carbsGoal = GoalSettings.CarbGoal();
        }//end method



        /// <summary>
        /// Sets the maximum fat for the day. Must be above 0.
        /// If below 0, a safe default will be set.
        /// </summary>
        /// <param name="fat"></param>
        public void SetFatGoal(int fat)
        {
            if (fatGoal > GoalSettings.MINIMUM_NUTRIENT_VALUE)
            {
                this.fatGoal = fat;
            }
            else this.fatGoal = GoalSettings.FatGoal();
        }//end method



        /// <summary>
        /// Sets the maximum protein for the day. Must be above 0.
        /// If below 0, a safe default will be set.
        /// </summary>
        /// <param name="protein"></param>
        public void SetProteinGoal(int protein)
        {
            if (proteinGoal > GoalSettings.MINIMUM_NUTRIENT_VALUE)
            {
                this.proteinGoal = protein;
            }
            else this.proteinGoal = GoalSettings.ProteinGoal();
        }//end method



        /// <summary>
        /// Add food item to the chosen meal list. Breakfast, lunch or dinner. 
        /// </summary>
        /// <param name="food">Food Item to add</param>
        /// <param name="meal">Meal list to add food item to</param>
        public void AddFoodItem(FoodItem food, Meal meal)
        {
            if (meal == Meal.BREAKFAST)
            {
                breakfast.Add(food);
            }

            if (meal == Meal.LUNCH)
            {
                lunch.Add(food);
            }

            if (meal == Meal.DINNER)
            {
                dinner.Add(food);
            }

            UpdateCurrentStats();
        }//end method



        /// <summary>
        /// Update all current nutrient values by looping through meal lists.
        /// </summary>
        public void UpdateCurrentStats()
        {
            currentCalories = 0;
            currentCarbs = 0;
            currentFat = 0;
            currentProtein = 0;

            LoopThroughListAddAllNutrients(breakfast);
            LoopThroughListAddAllNutrients(lunch);
            LoopThroughListAddAllNutrients(dinner);

        }//end method



        /// <summary>
        /// Returns the total calories of the chosen meal list.
        /// </summary>
        /// <param name="m">Meal to check</param>
        /// <returns>Total calories in specific meal list</returns>
        private int GetMealCalories(Meal m)
        {
            int cal = 0;

            if(m == Meal.BREAKFAST)
            {
                foreach (FoodItem food in breakfast)
                {
                    cal += food.GetCalories();
                }
            }

            if (m == Meal.LUNCH)
            {
                foreach (FoodItem food in lunch)
                {
                    cal += food.GetCalories();
                }
            }

            if (m == Meal.DINNER)
            {
                foreach (FoodItem food in dinner)
                {
                    cal += food.GetCalories();
                }
            }

            return cal;
        }//end method



        /// <summary>
        /// Adds up all calories, carbs, fat and protein in given list
        /// </summary>
        /// <param name="list">list to loop through</param>
        private void LoopThroughListAddAllNutrients(BindingList<FoodItem> list)
        {
            foreach(FoodItem food in list)
            {
                currentCalories += food.GetCalories();
                currentCarbs += food.GetCarbs();
                currentFat += food.GetFat();
                currentProtein += food.GetProtein();
            }
        }//end method


    }//end class
}
