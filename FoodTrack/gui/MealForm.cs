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
using FoodTrack.utility;

namespace FoodTrack.gui
{
    /// <summary>
    /// Opens form that display the meal list's food items, and allows editing existing foods or adding 
    /// new ones.
    /// </summary>
    public partial class MealForm : Form
    {
        private DailyTracker tracker;
        private Meal mealType;
        private BindingList<FoodItem> foodListBinding = new BindingList<FoodItem>();
        
        /// <summary>
        /// Creates a new Meal form that displays the selected Meal's food list.
        /// </summary>
        /// <param name="tracker">mainForm's tracker of the selected date</param>
        /// <param name="mealType">the meal list to open</param>
        public MealForm(DailyTracker tracker, Meal mealType)
        {
            InitializeComponent();
            this.tracker = tracker;
            this.mealType = mealType;
            
            SelectFoodListToDisplayByMealType(mealType);
            foodsListBox.DataSource = foodListBinding;

            SetUpEditSection();
            ClearErrorLabels();
        }//end constructor
        

        public BindingList<FoodItem> GetBindingFoodList() => foodListBinding;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="mealType"></param>
        private void SelectFoodListToDisplayByMealType(Meal mealType)
        {
            if(mealType == Meal.BREAKFAST) foodListBinding = tracker.GetBreakfast();

            if (mealType == Meal.LUNCH) foodListBinding = tracker.GetLunch();

            if (mealType == Meal.DINNER) foodListBinding = tracker.GetDinner();
        }//end method


        /// <summary>
        /// Set up the "edit selected food" section.
        /// 
        /// If the food list is empty, the edit section is empty and disabled.
        /// If the food list contains at least one item, the edit section will by default show 
        /// details of the last food item in the food list.
        /// </summary>
        private void SetUpEditSection()
        {
            if(foodListBinding.Count > 0)
            {
                saveEditsBtn.Enabled = true;
                deleteFoodBtn.Enabled = true;
                nameTxt.Enabled = true;
                caloriesTxt.Enabled = true;
                carbsTxt.Enabled = true;
                fatTxt.Enabled = true;
                proteinTxt.Enabled = true;

                SetEditTextboxesToFoodItemValues(foodListBinding.ElementAt(foodListBinding.Count - 1));
                foodsListBox.SelectedIndex = foodListBinding.Count - 1;
            }
            else
            {
                saveEditsBtn.Enabled = false;
                deleteFoodBtn.Enabled = false;

                nameTxt.Text = "";
                nameTxt.Enabled = false;

                caloriesTxt.Text = "";
                caloriesTxt.Enabled = false;

                carbsTxt.Text = "";
                carbsTxt.Enabled = false;

                fatTxt.Text = "";
                fatTxt.Enabled = false;

                proteinTxt.Text = "";
                proteinTxt.Enabled = false;
            }
        }//end method



        /// <summary>
        /// When add food button is clicked, a form is opened to allow adding new food to the food list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFoodBtn_Click(object sender, EventArgs e)
        {
            var form = new AddFoodForm(tracker, mealType);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            SetUpEditSection();

            this.Refresh();
        }//end method
        
        

        /// <summary>
        /// When a different food item is selected in the food list, the edit section will display
        /// the selected food item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearErrorLabels();

            if(foodsListBox.SelectedIndex >= 0)
            {
                FoodItem current = foodListBinding.ElementAt(foodsListBox.SelectedIndex);

                if (current != null)
                {
                    SetEditTextboxesToFoodItemValues(current);
                }
            }
            
        }//end method


        /// <summary>
        /// Sets the edit textboxes to display the values of a given food item
        /// </summary>
        /// <param name="food"></param>
        private void SetEditTextboxesToFoodItemValues(FoodItem food)
        {
            if (food != null)
            {
                nameTxt.Text = food.GetName();
                caloriesTxt.Text = food.GetCalories().ToString();
                carbsTxt.Text = food.GetCarbs().ToString();
                fatTxt.Text = food.GetFat().ToString();
                proteinTxt.Text = food.GetProtein().ToString();
            }
        }//end method


        /// <summary>
        /// When save edit button is clicked, the changes must pass validation, before the changes are
        /// saved to the selected food item in the food list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveEditsBtn_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            bool validationPassed = true;

            FoodItem currentFoodItem = foodListBinding.ElementAt(foodsListBox.SelectedIndex);

            if (currentFoodItem.SetName(nameTxt.Text) == false)
            {
                validationPassed = false;
                nameErrorLabel.Text = "Name can't be empty or have numbers in it.";
            }

            if(Int32.TryParse(caloriesTxt.Text, out int cal))
            {
                if (!currentFoodItem.SetCalories(cal))
                {
                    validationPassed = false;
                    CaloriesErrorLabel.Text = "Calories must be 0 or above";
                }
            }

            if (Int32.TryParse(carbsTxt.Text, out int carb))
            {
                if (!currentFoodItem.SetCarbs(carb))
                {
                    validationPassed = false;
                    CarbsErrorLabel.Text = "Carbs must be 0 or above";
                }
            }

            if (Int32.TryParse(fatTxt.Text, out int fat))
            {
                if (!currentFoodItem.SetFat(fat))
                {
                    validationPassed = false;
                    FatErrorLabel.Text = "Fat must be 0 or above";
                }
            }

            if (Int32.TryParse(proteinTxt.Text, out int prot))
            {
                if(!currentFoodItem.SetProtein(prot)){
                    validationPassed = false;
                    ProteinErrorLabel.Text = "Protein must be 0 or above";
                }
            }


            if (validationPassed)
            {
                foodListBinding[foodsListBox.SelectedIndex] = currentFoodItem;
                generalErrorLabel.ForeColor = Color.Green;
                generalErrorLabel.Text = "Changes saved!";
            }
            else
            {
                generalErrorLabel.Text = "Invalid input";
            }
        }//end method


        /// <summary>
        /// Deletes selected food item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFoodBtn_Click(object sender, EventArgs e)
        {
            String foodName = foodListBinding.ElementAt(foodsListBox.SelectedIndex).GetName();

            if(new ConfirmForm("Are you sure you want to delete " +
                foodName + "?").ShowDialog() == DialogResult.OK)
            {
                if (foodsListBox.SelectedIndex >= 0)
                {
                    foodListBinding.RemoveAt(foodsListBox.SelectedIndex);
                    SetUpEditSection();
                }
            }
            
        }//end method


        /// <summary>
        /// Clears all error labels
        /// </summary>
        private void ClearErrorLabels()
        {
            nameErrorLabel.Text = "";
            CaloriesErrorLabel.Text = "";
            CarbsErrorLabel.Text = "";
            FatErrorLabel.Text = "";
            ProteinErrorLabel.Text = "";

            generalErrorLabel.ForeColor = Color.Red;
            generalErrorLabel.Text = "";
        }//end method


        /// <summary>
        /// Updates some labels when this form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealForm_Load(object sender, EventArgs e)
        {
            if (mealType == Meal.BREAKFAST) FormsFunctionLabel.Text += " Breakfast";

            if (mealType == Meal.LUNCH) FormsFunctionLabel.Text += " Lunch";

            if (mealType == Meal.DINNER) FormsFunctionLabel.Text += " Dinner";
            

        }//end method

    }//end class
}
