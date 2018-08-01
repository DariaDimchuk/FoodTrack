using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrack.data
{
    /// <summary>
    /// Represents a nutrient type.
    /// Calories, Carbs, Fat or Protein.
    /// </summary>
    public enum Nutrients
    {
        CALORIES,
        CARBS,
        FAT,
        PROTEIN
    }


    /// <summary>
    /// Represents a food that gets added to the meal lists.
    /// Must have a name and basic nutrient values.
    /// </summary>
    public class FoodItem
    {
        private string Name;
        private int Calories;
        private int Carbs;
        private int Fat;
        private int Protein;


        /// <summary>
        /// Create a new food item.
        /// </summary>
        /// <param name="Name">Name of food item</param>
        /// <param name="Calories">Food's calories in kcal</param>
        /// <param name="Carbs">Grams of carbs</param>
        /// <param name="Fat">Grams of fat</param>
        /// <param name="Protein">Grams of prtein</param>
        public FoodItem(string Name, int Calories, int Carbs = 0, int Fat = 0, int Protein = 0)
        {
            SetName(Name);
            SetCalories(Calories);
            SetCarbs(Carbs);
            SetFat(Fat);
            SetProtein(Protein);
        }//end constructor


        public string GetName() => Name;
        public int GetCalories() => Calories;
        public int GetCarbs() => Carbs;
        public int GetFat() => Fat;
        public int GetProtein() => Protein;


        /// <summary>
        /// Set food item name. Cannot be null, empty, or have numbers.
        /// </summary>
        /// <param name="name">Name of food</param>
        /// <returns>True if succeeded, false if it failed</returns>
        public bool SetName(string name)
        {
            if(name != null && name.Trim() != "" && !name.Any(char.IsDigit))
            {
                this.Name = name;
                return true;
            }
            else
            {
                return false;
            }
        }//end method


        /// <summary>
        /// Set food calories. Cannot be below 0.
        /// </summary>
        /// <param name="calories">calories to set</param>
        /// <returns>True if succeeded, false if it failed</returns>
        public bool SetCalories(int calories)
        {
            if (calories >= 0)
            {
                this.Calories = calories;
                return true;
            }
            else return false;
        }//end method


        /// <summary>
        /// Set food carbs. Cannot be below 0.
        /// </summary>
        /// <param name="carbs">carbs to set</param>
        /// <returns>True if succeeded, false if it failed</returns>
        public bool SetCarbs(int carbs)
        {
            if (carbs >= 0)
            {
                this.Carbs = carbs;
                return true;
            }
            else return false;
        }//end method


        /// <summary>
        /// Set food fat. Cannot be below 0.
        /// </summary>
        /// <param name="fat">fat to set</param>
        /// <returns>True if succeeded, false if it failed</returns>
        public bool SetFat(int fat)
        {
            if (fat >= 0)
            {
                this.Fat = fat;
                return true;
            }
            else return false;
        }//end method



        /// <summary>
        /// Set food protein. Cannot be below 0.
        /// </summary>
        /// <param name="protein">protein to set</param>
        /// <returns>True if succeeded, false if it failed</returns>
        public bool SetProtein(int protein)
        {
            if (protein >= 0)
            {
                this.Protein = protein;
                return true;
            }
            else return false;
        }//end method


        
        /// <summary>
        /// Overridden toString() method displays object name.
        /// Form list will display object name instead of reference.
        /// </summary>
        /// <returns>Object name</returns>
        override public string ToString()
        {
            return this.Name;
        }//end method

    }//end class
}
