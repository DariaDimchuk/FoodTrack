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
    /// Main form that allows food tracking, adding new food, and seeing your diet habits.
    /// </summary>
    public partial class MainForm : Form
    {
        private DailyTracker tracker;
        private Date date;


        /// <summary>
        /// Creates a new main form.
        /// </summary>
        /// <param name="date">Date to select</param>
        public MainForm(Date date)
        {
            this.date = date;
            this.tracker = this.date.GetDailyTracker();
            
            InitializeComponent();
            UpdateProgressBarMaximums();
            UpdateProgress();
        }//end constructor



        /// <summary>
        /// Method triggered when date value is changed in the Form's dateTimePicked.
        /// Refreshes content to represent the data of the new Date's daily tracker.
        /// </summary>
        /// <param name="date">date to switch to</param>
        private void ChangeFormContentByDate(DateTime date)
        {
            bool dateExists = false;
            Date selectedDate = null;

            foreach(Date d in DateCollection.GetCalendar())
            {
                if(d.DoDatesMatch(date))
                {
                    selectedDate = d;
                    dateExists = true;
                    break;
                }
            }//end loop


            if (!dateExists)
            {
                Date d = new Date(date.Year, date.Month, date.Day);
                DateCollection.GetCalendar().Add(d);
                selectedDate = d;
            }

            if(selectedDate != null)
            {
                this.tracker = selectedDate.GetDailyTracker();
                UpdateProgress();
            }
            

        }//end method



        /// <summary>
        /// Updates the progress bars and all labels to reflect the DailyTracker's current 
        /// nutrient values and current goals.
        /// </summary>
        private void UpdateProgress()
        {
            tracker.UpdateCurrentStats();
            UpdateProgressBarMaximums();

            if (this.tracker.GetCurrentCalories() < caloriesProgressBar.Maximum)
            {
                caloriesProgressBar.Value = this.tracker.GetCurrentCalories();
            }
            else
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.CALORIES);
            }
            

            if (this.tracker.GetCurrentCarbs() < carbsProgressBar.Maximum)
            {
                carbsProgressBar.Value = this.tracker.GetCurrentCarbs();
            }
            else
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.CARBS);
            }

            if(this.tracker.GetCurrentFat() < fatProgressBar.Maximum)
            {
                fatProgressBar.Value = this.tracker.GetCurrentFat();
            }
            else
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.FAT);
            }

            if(this.tracker.GetCurrentProtein() < proteinProgressBar.Maximum)
            {
                proteinProgressBar.Value = this.tracker.GetCurrentProtein();
            }
            else
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.PROTEIN);
            }

            
            UpdateProgressBarLabels();
            UpdateMealLabels();

        }//end method



        /// <summary>
        /// Update labels over the progress bars.
        /// </summary>
        private void UpdateProgressBarLabels()
        {
            if (caloriesProgressBar.Value < caloriesProgressBar.Maximum)
            {
                this.calorieProgressBarValueLabel.Text = caloriesProgressBar.Value.ToString() + " / " + caloriesProgressBar.Maximum.ToString();
            }
            else
            {
                int overflowAmt = tracker.GetCurrentCalories() - tracker.GetCalorieGoal();
                this.calorieProgressBarValueLabel.Text = overflowAmt.ToString() + " over goal!";
            }


            if (carbsProgressBar.Value < carbsProgressBar.Maximum)
            {
                this.carbProgressBarValueLabel.Text = carbsProgressBar.Value.ToString() + " / " + carbsProgressBar.Maximum.ToString();
            }
            else
            {
                int overflowAmt = tracker.GetCurrentCarbs() - tracker.GetCarbsGoal();
                this.carbProgressBarValueLabel.Text = overflowAmt.ToString() + " over goal!";
            }


            if (fatProgressBar.Value < fatProgressBar.Maximum)
            {
                this.fatProgressBarValueLabel.Text = fatProgressBar.Value.ToString() + " / " + fatProgressBar.Maximum.ToString();
            }
            else
            {
                int overflowAmt = tracker.GetCurrentFat() - tracker.GetFatGoal();
                this.fatProgressBarValueLabel.Text = overflowAmt.ToString() + " over goal!";
            }


            if (proteinProgressBar.Value < proteinProgressBar.Maximum)
            {
                this.proteinProgressBarValueLabel.Text = proteinProgressBar.Value.ToString() + " / " + proteinProgressBar.Maximum.ToString();
            }
            else
            {
                int overflowAmt = tracker.GetCurrentProtein() - tracker.GetProteinGoal();
                this.proteinProgressBarValueLabel.Text = overflowAmt.ToString() + " over goal!";
            }

        }//end method


        /// <summary>
        /// Update labels displaying the meal lists' total calories.
        /// </summary>
        private void UpdateMealLabels()
        {
            this.BreakfastAmountLabel.Text = this.tracker.GetTotalBreakfastCalories().ToString();
            this.LunchAmountLabel.Text = this.tracker.GetTotalLunchCalories().ToString();
            this.DinnerAmountLabel.Text = this.tracker.GetTotalDinnerCalories().ToString();
        }//end method


        /// <summary>
        /// Update the progress bars maximum values when the nutrient goals are changed.
        /// </summary>
        private void UpdateProgressBarMaximums()
        {
            if(caloriesProgressBar.Value >= tracker.GetCalorieGoal())
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.CALORIES);
            }

            if (carbsProgressBar.Value >= tracker.GetCarbsGoal())
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.CARBS);
            }

            if (fatProgressBar.Value >= tracker.GetFatGoal())
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.FAT);
            }

            if (proteinProgressBar.Value >= tracker.GetProteinGoal())
            {
                SetNutrientProgressBarToMaxOnOverflow(Nutrients.PROTEIN);
            }


            this.caloriesProgressBar.Maximum = tracker.GetCalorieGoal();
            this.proteinProgressBar.Maximum = tracker.GetProteinGoal();
            this.fatProgressBar.Maximum = tracker.GetFatGoal();
            this.carbsProgressBar.Maximum = tracker.GetCarbsGoal();

            UpdateProgressBarLabels();
        }//end method
        


        /// <summary>
        /// Sets the progress bar value to max when the progress bar overflows. Otherwise
        /// the progress bar would show 0.
        /// </summary>
        /// <param name="nutrient"></param>
        private void SetNutrientProgressBarToMaxOnOverflow(Nutrients nutrient)
        {
            if (nutrient == Nutrients.CALORIES)
            {
                caloriesProgressBar.Value = caloriesProgressBar.Maximum;
            }

            if (nutrient == Nutrients.CARBS)
            {
                carbsProgressBar.Value = carbsProgressBar.Maximum;
            }

            if (nutrient == Nutrients.FAT)
            {
                fatProgressBar.Value = fatProgressBar.Maximum;
            }

            if (nutrient == Nutrients.PROTEIN)
            {
                proteinProgressBar.Value = proteinProgressBar.Maximum;
            }
        }//end method


        
        
        /// <summary>
        /// On edit breakfast button click, opens new MealForm which displays
        /// breakfast list and allows adding new foods or editing existing ones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBreakfastBtn_Click(object sender, EventArgs e)
        {
            var form = new MealForm(tracker, Meal.BREAKFAST);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Text = "Breakfast";
            form.ShowDialog();
            UpdateProgress();
        }//end method



        /// <summary>
        /// On edit lunch button click, opens new MealForm which displays
        /// lunch list and allows adding new foods or editing existing ones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLunchBtn_Click(object sender, EventArgs e)
        {
            var form = new MealForm(tracker, Meal.LUNCH);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Text = "Lunch";
            form.ShowDialog();
            UpdateProgress();
        }//end method



        /// <summary>
        /// On edit dinner button click, opens new MealForm which displays
        /// dinner list and allows adding new foods or editing existing ones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditDinnerBtn_Click(object sender, EventArgs e)
        {
            var form = new MealForm(tracker, Meal.DINNER);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Text = "Dinner";
            form.ShowDialog();
            UpdateProgress();
        }//end method


        /// <summary>
        /// On goals button click, opens the setGoalsForm which changes the 
        /// daily calorie and other nutriens't maximums of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoalsBtn_Click(object sender, EventArgs e)
        {
            var form = new SetGoalsForm(tracker);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            UpdateProgressBarMaximums();
            UpdateProgress();
        }//end method


        /// <summary>
        /// When a different date is picked, the form updates to display that day's 
        /// food lists and food intake.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker x = (DateTimePicker)sender;
            ChangeFormContentByDate(x.Value);
        }//end method

        

    }//end class
}
