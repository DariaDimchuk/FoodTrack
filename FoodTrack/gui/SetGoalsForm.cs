using FoodTrack.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTrack.gui
{
    /// <summary>
    /// Sets the maximum calorie and nutrient goals
    /// </summary>
    public partial class SetGoalsForm : Form
    {
        private DailyTracker tracker;


        /// <summary>
        /// Creates a new form that allows setting the calorie and nutrient goals.
        /// </summary>
        /// <param name="tracker"></param>
        public SetGoalsForm(DailyTracker tracker)
        {
            InitializeComponent();
            this.tracker = tracker;

            SetGoalTextboxValues();
            ClearErrorLabels();
        }//end constructor


        /// <summary>
        /// Attempts to save the changes to the goals. Must pass validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();

            bool errorsFound = false;

            if (!(Int32.TryParse(this.caloriesTxt.Text, out int cal) && cal >= GoalSettings.MINIMUM_CALORIES))
            {
                CaloriesErrorLabel.Text = "Calories must be 1000 or higher.";
                errorsFound = true;
            }

            if (!(Int32.TryParse(this.carbsTxt.Text, out int carb) && carb >= GoalSettings.MINIMUM_NUTRIENT_VALUE))
            {
                CarbsErrorLabel.Text = "Carbs must be 0 or higher.";
                errorsFound = true;
            }

            if (!(Int32.TryParse(this.fatTxt.Text, out int fat) && fat >= GoalSettings.MINIMUM_NUTRIENT_VALUE))
            {
                FatErrorLabel.Text = "Fat must be 0 or higher.";
                errorsFound = true;
            }

            if (!(Int32.TryParse(this.proteinTxt.Text, out int protein) && protein >= GoalSettings.MINIMUM_NUTRIENT_VALUE))
            {
                ProteinErrorLabel.Text = "Protein must be 0 or higher.";
                errorsFound = true;
            }


            //if validation passed, set values
            if (!errorsFound)
            {
                GoalSettings.SetAllSettings(tracker, cal, carb, fat, protein);
                this.Close();
            }

        }//end method



        /// <summary>
        /// Updates textbox values to represent the current goals
        /// </summary>
        private void SetGoalTextboxValues()
        {
            caloriesTxt.Text = tracker.GetCalorieGoal().ToString();
            carbsTxt.Text = tracker.GetCarbsGoal().ToString();
            fatTxt.Text = tracker.GetFatGoal().ToString();
            proteinTxt.Text = tracker.GetProteinGoal().ToString();
        }//end method



        /// <summary>
        /// Clears error labels
        /// </summary>
        private void ClearErrorLabels()
        {
            CaloriesErrorLabel.Text = "";
            CarbsErrorLabel.Text = "";
            FatErrorLabel.Text = "";
            ProteinErrorLabel.Text = "";
        }//end method


    }//end class
}
