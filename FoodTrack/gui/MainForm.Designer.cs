namespace FoodTrack
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.caloriesProgressBar = new System.Windows.Forms.ProgressBar();
            this.totalCaloriesProgressBar = new System.Windows.Forms.Label();
            this.BreakfastAmountLabel = new System.Windows.Forms.Label();
            this.LunchAmountLabel = new System.Windows.Forms.Label();
            this.DinnerAmountLabel = new System.Windows.Forms.Label();
            this.editBreakfastBtn = new System.Windows.Forms.Button();
            this.editLunchBtn = new System.Windows.Forms.Button();
            this.editDinnerBtn = new System.Windows.Forms.Button();
            this.CarbsLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.ProteinLabel = new System.Windows.Forms.Label();
            this.fatProgressBar = new System.Windows.Forms.ProgressBar();
            this.carbsProgressBar = new System.Windows.Forms.ProgressBar();
            this.proteinProgressBar = new System.Windows.Forms.ProgressBar();
            this.goalsBtn = new System.Windows.Forms.Button();
            this.calorieProgressBarValueLabel = new System.Windows.Forms.Label();
            this.proteinProgressBarValueLabel = new System.Windows.Forms.Label();
            this.fatProgressBarValueLabel = new System.Windows.Forms.Label();
            this.carbProgressBarValueLabel = new System.Windows.Forms.Label();
            this.FoodListsBelowLabel = new System.Windows.Forms.Label();
            this.BreakfastLabel = new System.Windows.Forms.Label();
            this.LunchLabel = new System.Windows.Forms.Label();
            this.DinnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 26);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(246, 32);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // caloriesProgressBar
            // 
            this.caloriesProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.caloriesProgressBar.Location = new System.Drawing.Point(22, 170);
            this.caloriesProgressBar.MarqueeAnimationSpeed = 0;
            this.caloriesProgressBar.Maximum = 10000;
            this.caloriesProgressBar.Name = "caloriesProgressBar";
            this.caloriesProgressBar.Size = new System.Drawing.Size(680, 53);
            this.caloriesProgressBar.TabIndex = 4;
            // 
            // totalCaloriesProgressBar
            // 
            this.totalCaloriesProgressBar.AutoSize = true;
            this.totalCaloriesProgressBar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesProgressBar.Location = new System.Drawing.Point(246, 90);
            this.totalCaloriesProgressBar.Name = "totalCaloriesProgressBar";
            this.totalCaloriesProgressBar.Size = new System.Drawing.Size(227, 26);
            this.totalCaloriesProgressBar.TabIndex = 2;
            this.totalCaloriesProgressBar.Text = "Total Calories Today";
            // 
            // BreakfastAmountLabel
            // 
            this.BreakfastAmountLabel.AutoSize = true;
            this.BreakfastAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastAmountLabel.Location = new System.Drawing.Point(108, 489);
            this.BreakfastAmountLabel.Name = "BreakfastAmountLabel";
            this.BreakfastAmountLabel.Size = new System.Drawing.Size(65, 25);
            this.BreakfastAmountLabel.TabIndex = 16;
            this.BreakfastAmountLabel.Text = "0 cal";
            this.BreakfastAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LunchAmountLabel
            // 
            this.LunchAmountLabel.AutoSize = true;
            this.LunchAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchAmountLabel.Location = new System.Drawing.Point(346, 489);
            this.LunchAmountLabel.Name = "LunchAmountLabel";
            this.LunchAmountLabel.Size = new System.Drawing.Size(65, 25);
            this.LunchAmountLabel.TabIndex = 19;
            this.LunchAmountLabel.Text = "0 cal";
            this.LunchAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DinnerAmountLabel
            // 
            this.DinnerAmountLabel.AutoSize = true;
            this.DinnerAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerAmountLabel.Location = new System.Drawing.Point(560, 489);
            this.DinnerAmountLabel.Name = "DinnerAmountLabel";
            this.DinnerAmountLabel.Size = new System.Drawing.Size(65, 25);
            this.DinnerAmountLabel.TabIndex = 22;
            this.DinnerAmountLabel.Text = "0 cal";
            this.DinnerAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editBreakfastBtn
            // 
            this.editBreakfastBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBreakfastBtn.Location = new System.Drawing.Point(71, 535);
            this.editBreakfastBtn.Name = "editBreakfastBtn";
            this.editBreakfastBtn.Size = new System.Drawing.Size(140, 45);
            this.editBreakfastBtn.TabIndex = 17;
            this.editBreakfastBtn.Text = "Edit";
            this.editBreakfastBtn.UseVisualStyleBackColor = true;
            this.editBreakfastBtn.Click += new System.EventHandler(this.EditBreakfastBtn_Click);
            // 
            // editLunchBtn
            // 
            this.editLunchBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLunchBtn.Location = new System.Drawing.Point(302, 535);
            this.editLunchBtn.Name = "editLunchBtn";
            this.editLunchBtn.Size = new System.Drawing.Size(140, 45);
            this.editLunchBtn.TabIndex = 20;
            this.editLunchBtn.Text = "Edit";
            this.editLunchBtn.UseVisualStyleBackColor = true;
            this.editLunchBtn.Click += new System.EventHandler(this.EditLunchBtn_Click);
            // 
            // editDinnerBtn
            // 
            this.editDinnerBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDinnerBtn.Location = new System.Drawing.Point(520, 535);
            this.editDinnerBtn.Name = "editDinnerBtn";
            this.editDinnerBtn.Size = new System.Drawing.Size(140, 45);
            this.editDinnerBtn.TabIndex = 23;
            this.editDinnerBtn.Text = "Edit";
            this.editDinnerBtn.UseVisualStyleBackColor = true;
            this.editDinnerBtn.Click += new System.EventHandler(this.EditDinnerBtn_Click);
            // 
            // CarbsLabel
            // 
            this.CarbsLabel.AutoSize = true;
            this.CarbsLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbsLabel.Location = new System.Drawing.Point(75, 240);
            this.CarbsLabel.Name = "CarbsLabel";
            this.CarbsLabel.Size = new System.Drawing.Size(76, 25);
            this.CarbsLabel.TabIndex = 5;
            this.CarbsLabel.Text = "Carbs";
            this.CarbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(340, 240);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(46, 25);
            this.fatLabel.TabIndex = 8;
            this.fatLabel.Text = "Fat";
            this.fatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProteinLabel
            // 
            this.ProteinLabel.AutoSize = true;
            this.ProteinLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinLabel.Location = new System.Drawing.Point(578, 240);
            this.ProteinLabel.Name = "ProteinLabel";
            this.ProteinLabel.Size = new System.Drawing.Size(76, 23);
            this.ProteinLabel.TabIndex = 11;
            this.ProteinLabel.Text = "Protein";
            this.ProteinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatProgressBar
            // 
            this.fatProgressBar.Location = new System.Drawing.Point(260, 275);
            this.fatProgressBar.Maximum = 5000;
            this.fatProgressBar.Name = "fatProgressBar";
            this.fatProgressBar.Size = new System.Drawing.Size(200, 45);
            this.fatProgressBar.TabIndex = 9;
            // 
            // carbsProgressBar
            // 
            this.carbsProgressBar.Location = new System.Drawing.Point(22, 275);
            this.carbsProgressBar.Maximum = 5000;
            this.carbsProgressBar.Name = "carbsProgressBar";
            this.carbsProgressBar.Size = new System.Drawing.Size(200, 45);
            this.carbsProgressBar.TabIndex = 6;
            // 
            // proteinProgressBar
            // 
            this.proteinProgressBar.Location = new System.Drawing.Point(502, 275);
            this.proteinProgressBar.Maximum = 5000;
            this.proteinProgressBar.Name = "proteinProgressBar";
            this.proteinProgressBar.Size = new System.Drawing.Size(200, 45);
            this.proteinProgressBar.TabIndex = 12;
            // 
            // goalsBtn
            // 
            this.goalsBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsBtn.Location = new System.Drawing.Point(554, 22);
            this.goalsBtn.Name = "goalsBtn";
            this.goalsBtn.Size = new System.Drawing.Size(158, 45);
            this.goalsBtn.TabIndex = 1;
            this.goalsBtn.Text = "Set Goals";
            this.goalsBtn.UseVisualStyleBackColor = true;
            this.goalsBtn.Click += new System.EventHandler(this.GoalsBtn_Click);
            // 
            // calorieProgressBarValueLabel
            // 
            this.calorieProgressBarValueLabel.AutoSize = true;
            this.calorieProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.calorieProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieProgressBarValueLabel.Location = new System.Drawing.Point(310, 130);
            this.calorieProgressBarValueLabel.Name = "calorieProgressBarValueLabel";
            this.calorieProgressBarValueLabel.Size = new System.Drawing.Size(106, 25);
            this.calorieProgressBarValueLabel.TabIndex = 3;
            this.calorieProgressBarValueLabel.Text = "xxx / yyy";
            this.calorieProgressBarValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proteinProgressBarValueLabel
            // 
            this.proteinProgressBarValueLabel.AutoSize = true;
            this.proteinProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.proteinProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinProgressBarValueLabel.Location = new System.Drawing.Point(569, 330);
            this.proteinProgressBarValueLabel.Name = "proteinProgressBarValueLabel";
            this.proteinProgressBarValueLabel.Size = new System.Drawing.Size(94, 23);
            this.proteinProgressBarValueLabel.TabIndex = 13;
            this.proteinProgressBarValueLabel.Text = "xxx / yyy";
            this.proteinProgressBarValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatProgressBarValueLabel
            // 
            this.fatProgressBarValueLabel.AutoSize = true;
            this.fatProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.fatProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatProgressBarValueLabel.Location = new System.Drawing.Point(312, 330);
            this.fatProgressBarValueLabel.Name = "fatProgressBarValueLabel";
            this.fatProgressBarValueLabel.Size = new System.Drawing.Size(94, 23);
            this.fatProgressBarValueLabel.TabIndex = 10;
            this.fatProgressBarValueLabel.Text = "xxx / yyy";
            this.fatProgressBarValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carbProgressBarValueLabel
            // 
            this.carbProgressBarValueLabel.AutoSize = true;
            this.carbProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.carbProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbProgressBarValueLabel.Location = new System.Drawing.Point(57, 330);
            this.carbProgressBarValueLabel.Name = "carbProgressBarValueLabel";
            this.carbProgressBarValueLabel.Size = new System.Drawing.Size(94, 23);
            this.carbProgressBarValueLabel.TabIndex = 7;
            this.carbProgressBarValueLabel.Text = "xxx / yyy";
            this.carbProgressBarValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodListsBelowLabel
            // 
            this.FoodListsBelowLabel.AutoSize = true;
            this.FoodListsBelowLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodListsBelowLabel.Location = new System.Drawing.Point(297, 401);
            this.FoodListsBelowLabel.Name = "FoodListsBelowLabel";
            this.FoodListsBelowLabel.Size = new System.Drawing.Size(163, 26);
            this.FoodListsBelowLabel.TabIndex = 14;
            this.FoodListsBelowLabel.Text = "Today\'s Meals";
            // 
            // BreakfastLabel
            // 
            this.BreakfastLabel.AutoSize = true;
            this.BreakfastLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastLabel.Location = new System.Drawing.Point(88, 450);
            this.BreakfastLabel.Name = "BreakfastLabel";
            this.BreakfastLabel.Size = new System.Drawing.Size(111, 25);
            this.BreakfastLabel.TabIndex = 15;
            this.BreakfastLabel.Text = "Breakfast";
            this.BreakfastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LunchLabel
            // 
            this.LunchLabel.AutoSize = true;
            this.LunchLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchLabel.Location = new System.Drawing.Point(337, 450);
            this.LunchLabel.Name = "LunchLabel";
            this.LunchLabel.Size = new System.Drawing.Size(75, 25);
            this.LunchLabel.TabIndex = 18;
            this.LunchLabel.Text = "Lunch";
            this.LunchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DinnerLabel
            // 
            this.DinnerLabel.AutoSize = true;
            this.DinnerLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerLabel.Location = new System.Drawing.Point(549, 450);
            this.DinnerLabel.Name = "DinnerLabel";
            this.DinnerLabel.Size = new System.Drawing.Size(79, 25);
            this.DinnerLabel.TabIndex = 21;
            this.DinnerLabel.Text = "Dinner";
            this.DinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 607);
            this.Controls.Add(this.DinnerLabel);
            this.Controls.Add(this.LunchLabel);
            this.Controls.Add(this.BreakfastLabel);
            this.Controls.Add(this.FoodListsBelowLabel);
            this.Controls.Add(this.carbProgressBarValueLabel);
            this.Controls.Add(this.fatProgressBarValueLabel);
            this.Controls.Add(this.proteinProgressBarValueLabel);
            this.Controls.Add(this.calorieProgressBarValueLabel);
            this.Controls.Add(this.goalsBtn);
            this.Controls.Add(this.CarbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.ProteinLabel);
            this.Controls.Add(this.fatProgressBar);
            this.Controls.Add(this.carbsProgressBar);
            this.Controls.Add(this.proteinProgressBar);
            this.Controls.Add(this.editDinnerBtn);
            this.Controls.Add(this.editLunchBtn);
            this.Controls.Add(this.editBreakfastBtn);
            this.Controls.Add(this.DinnerAmountLabel);
            this.Controls.Add(this.LunchAmountLabel);
            this.Controls.Add(this.BreakfastAmountLabel);
            this.Controls.Add(this.totalCaloriesProgressBar);
            this.Controls.Add(this.caloriesProgressBar);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Food Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ProgressBar caloriesProgressBar;
        private System.Windows.Forms.Label totalCaloriesProgressBar;
        private System.Windows.Forms.Label BreakfastAmountLabel;
        private System.Windows.Forms.Label LunchAmountLabel;
        private System.Windows.Forms.Label DinnerAmountLabel;
        private System.Windows.Forms.Button editBreakfastBtn;
        private System.Windows.Forms.Button editLunchBtn;
        private System.Windows.Forms.Button editDinnerBtn;
        private System.Windows.Forms.Label CarbsLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label ProteinLabel;
        private System.Windows.Forms.ProgressBar fatProgressBar;
        private System.Windows.Forms.ProgressBar carbsProgressBar;
        private System.Windows.Forms.ProgressBar proteinProgressBar;
        private System.Windows.Forms.Button goalsBtn;
        private System.Windows.Forms.Label calorieProgressBarValueLabel;
        private System.Windows.Forms.Label proteinProgressBarValueLabel;
        private System.Windows.Forms.Label fatProgressBarValueLabel;
        private System.Windows.Forms.Label carbProgressBarValueLabel;
        private System.Windows.Forms.Label FoodListsBelowLabel;
        private System.Windows.Forms.Label BreakfastLabel;
        private System.Windows.Forms.Label LunchLabel;
        private System.Windows.Forms.Label DinnerLabel;
    }
}

