using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodTrack.data;
using FoodTrack.gui;

namespace FoodTrack
{
    /// <summary>
    /// Dialog that allows adding food to the Main form.
    /// </summary>
    public partial class AddFoodForm : Form
    {
        private DailyTracker tracker;
        private Meal mealType;

        /// <summary>
        /// Creates a dialog that allows adding foods.
        /// </summary>
        public AddFoodForm(DailyTracker tracker, Meal mealType)
        {
            InitializeComponent();
            this.tracker = tracker;
            this.mealType = mealType;
            ClearErrorLabels();
            
        }//end constructor
        

        /// <summary>
        /// When save button is clicked, the Food Item is checked for validity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            bool validationPassed = true;

            FoodItem testItem = new FoodItem("test", 0, 0, 0, 0);


            if (!testItem.SetName(this.nameTextBox.Text))
            {
                validationPassed = false;
                NameErrorLabel.Text = "Name cannot be empty or have numbers";
            }

            if (Int32.TryParse(caloriesTextBox.Text, out int cal))
            {
                if (!testItem.SetCalories(cal))
                {
                    validationPassed = false;
                    CaloriesErrorLabel.Text = "Calories must be 0 or above";
                }
            }
            else
            {
                validationPassed = false;
                if(caloriesTextBox.Text.Length == 0)
                {
                    CaloriesErrorLabel.Text = "Calories cannot be empty";

                }else CaloriesErrorLabel.Text = "Calories cannot be text";
            }


            if (Int32.TryParse(carbsTextBox.Text, out int carb))
            {
                if (!testItem.SetCarbs(carb))
                {
                    validationPassed = false;
                    CarbsErrorLabel.Text = "Carbs must be 0 or above";
                }
            }
            else
            {
                if (carbsTextBox.Text.Length == 0)
                {
                    testItem.SetCarbs(0);
                }
                else
                {
                    validationPassed = false;
                    CarbsErrorLabel.Text = "Carbs cannot be text";
                }
            }


            if (Int32.TryParse(fatTextBox.Text, out int fat))
            {
                if (!testItem.SetFat(fat))
                {
                    validationPassed = false;
                    FatErrorLabel.Text = "Fat must be 0 or above";
                }
            }
            else
            {
                
                if (fatTextBox.Text.Length == 0)
                {
                    testItem.SetFat(0);
                }
                else
                {
                    validationPassed = false;
                    FatErrorLabel.Text = "Fat cannot be text";
                }
            }


            if (Int32.TryParse(proteinTextBox.Text, out int prot))
            {
                if (!testItem.SetProtein(prot))
                {
                    validationPassed = false;
                    ProteinErrorLabel.Text = "Protein must be 0 or above";
                }
            }
            else
            {
                if (proteinTextBox.Text.Length == 0)
                {
                    testItem.SetProtein(0);
                }
                else
                {
                    validationPassed = false;
                    ProteinErrorLabel.Text = "Protein cannot be text";
                }
            }

            //add item if valid
            if (validationPassed)
            {
                tracker.AddFoodItem(testItem, mealType);
                this.Close();
            }
            
        }//end method

        

        /// <summary>
        /// Clears all error labels on form.
        /// </summary>
        private void ClearErrorLabels()
        {
            NameErrorLabel.Text = "";
            CaloriesErrorLabel.Text = "";
            CarbsErrorLabel.Text = "";
            FatErrorLabel.Text = "";
            ProteinErrorLabel.Text = "";
        }//end method
        
    }//end class
}
