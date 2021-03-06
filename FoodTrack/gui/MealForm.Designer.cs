﻿namespace FoodTrack.gui
{
    partial class MealForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealForm));
            this.foodsListBox = new System.Windows.Forms.ListBox();
            this.AddFoodBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.saveEditsBtn = new System.Windows.Forms.Button();
            this.deleteFoodBtn = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.CaloriesErrorLabel = new System.Windows.Forms.Label();
            this.CarbsErrorLabel = new System.Windows.Forms.Label();
            this.FatErrorLabel = new System.Windows.Forms.Label();
            this.ProteinErrorLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.caloriesTxt = new System.Windows.Forms.TextBox();
            this.carbsTxt = new System.Windows.Forms.TextBox();
            this.fatTxt = new System.Windows.Forms.TextBox();
            this.proteinTxt = new System.Windows.Forms.TextBox();
            this.generalErrorLabel = new System.Windows.Forms.Label();
            this.FormsFunctionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyTrackerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dailyTrackerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // foodsListBox
            // 
            this.foodsListBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodsListBox.FormattingEnabled = true;
            this.foodsListBox.ItemHeight = 23;
            this.foodsListBox.Items.AddRange(new object[] {
            "hallo"});
            this.foodsListBox.Location = new System.Drawing.Point(17, 71);
            this.foodsListBox.Name = "foodsListBox";
            this.foodsListBox.Size = new System.Drawing.Size(246, 372);
            this.foodsListBox.TabIndex = 0;
            this.foodsListBox.SelectedIndexChanged += new System.EventHandler(this.FoodsListBox_SelectedIndexChanged);
            // 
            // AddFoodBtn
            // 
            this.AddFoodBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodBtn.Location = new System.Drawing.Point(17, 462);
            this.AddFoodBtn.Name = "AddFoodBtn";
            this.AddFoodBtn.Size = new System.Drawing.Size(246, 50);
            this.AddFoodBtn.TabIndex = 1;
            this.AddFoodBtn.Text = "Add New Food";
            this.AddFoodBtn.UseVisualStyleBackColor = true;
            this.AddFoodBtn.Click += new System.EventHandler(this.AddFoodBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(297, 117);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 23);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(292, 187);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(88, 23);
            this.caloriesLabel.TabIndex = 8;
            this.caloriesLabel.Text = "Calories";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsLabel.Location = new System.Drawing.Point(292, 258);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(68, 23);
            this.carbsLabel.TabIndex = 9;
            this.carbsLabel.Text = "Carbs";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(292, 325);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(41, 23);
            this.fatLabel.TabIndex = 10;
            this.fatLabel.Text = "Fat";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.Location = new System.Drawing.Point(292, 397);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(76, 23);
            this.proteinLabel.TabIndex = 11;
            this.proteinLabel.Text = "Protein";
            // 
            // saveEditsBtn
            // 
            this.saveEditsBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditsBtn.Location = new System.Drawing.Point(329, 462);
            this.saveEditsBtn.Name = "saveEditsBtn";
            this.saveEditsBtn.Size = new System.Drawing.Size(146, 50);
            this.saveEditsBtn.TabIndex = 7;
            this.saveEditsBtn.Text = "Save Edit";
            this.saveEditsBtn.UseVisualStyleBackColor = true;
            this.saveEditsBtn.Click += new System.EventHandler(this.SaveEditsBtn_Click);
            // 
            // deleteFoodBtn
            // 
            this.deleteFoodBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFoodBtn.Location = new System.Drawing.Point(481, 462);
            this.deleteFoodBtn.Name = "deleteFoodBtn";
            this.deleteFoodBtn.Size = new System.Drawing.Size(146, 50);
            this.deleteFoodBtn.TabIndex = 8;
            this.deleteFoodBtn.Text = "Delete Item";
            this.deleteFoodBtn.UseVisualStyleBackColor = true;
            this.deleteFoodBtn.Click += new System.EventHandler(this.DeleteFoodBtn_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(297, 149);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(99, 21);
            this.nameErrorLabel.TabIndex = 14;
            this.nameErrorLabel.Text = "*Error here";
            // 
            // CaloriesErrorLabel
            // 
            this.CaloriesErrorLabel.AutoSize = true;
            this.CaloriesErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CaloriesErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CaloriesErrorLabel.Location = new System.Drawing.Point(292, 219);
            this.CaloriesErrorLabel.Name = "CaloriesErrorLabel";
            this.CaloriesErrorLabel.Size = new System.Drawing.Size(99, 21);
            this.CaloriesErrorLabel.TabIndex = 15;
            this.CaloriesErrorLabel.Text = "*Error here";
            // 
            // CarbsErrorLabel
            // 
            this.CarbsErrorLabel.AutoSize = true;
            this.CarbsErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CarbsErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CarbsErrorLabel.Location = new System.Drawing.Point(292, 290);
            this.CarbsErrorLabel.Name = "CarbsErrorLabel";
            this.CarbsErrorLabel.Size = new System.Drawing.Size(99, 21);
            this.CarbsErrorLabel.TabIndex = 16;
            this.CarbsErrorLabel.Text = "*Error here";
            // 
            // FatErrorLabel
            // 
            this.FatErrorLabel.AutoSize = true;
            this.FatErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FatErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FatErrorLabel.Location = new System.Drawing.Point(292, 357);
            this.FatErrorLabel.Name = "FatErrorLabel";
            this.FatErrorLabel.Size = new System.Drawing.Size(99, 21);
            this.FatErrorLabel.TabIndex = 17;
            this.FatErrorLabel.Text = "*Error here";
            // 
            // ProteinErrorLabel
            // 
            this.ProteinErrorLabel.AutoSize = true;
            this.ProteinErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ProteinErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ProteinErrorLabel.Location = new System.Drawing.Point(292, 429);
            this.ProteinErrorLabel.Name = "ProteinErrorLabel";
            this.ProteinErrorLabel.Size = new System.Drawing.Size(99, 21);
            this.ProteinErrorLabel.TabIndex = 18;
            this.ProteinErrorLabel.Text = "*Error here";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(399, 114);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(228, 32);
            this.nameTxt.TabIndex = 2;
            // 
            // caloriesTxt
            // 
            this.caloriesTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesTxt.Location = new System.Drawing.Point(399, 184);
            this.caloriesTxt.Name = "caloriesTxt";
            this.caloriesTxt.Size = new System.Drawing.Size(228, 32);
            this.caloriesTxt.TabIndex = 3;
            // 
            // carbsTxt
            // 
            this.carbsTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsTxt.Location = new System.Drawing.Point(399, 255);
            this.carbsTxt.Name = "carbsTxt";
            this.carbsTxt.Size = new System.Drawing.Size(228, 32);
            this.carbsTxt.TabIndex = 4;
            // 
            // fatTxt
            // 
            this.fatTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatTxt.Location = new System.Drawing.Point(399, 322);
            this.fatTxt.Name = "fatTxt";
            this.fatTxt.Size = new System.Drawing.Size(228, 32);
            this.fatTxt.TabIndex = 5;
            // 
            // proteinTxt
            // 
            this.proteinTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinTxt.Location = new System.Drawing.Point(399, 394);
            this.proteinTxt.Name = "proteinTxt";
            this.proteinTxt.Size = new System.Drawing.Size(228, 32);
            this.proteinTxt.TabIndex = 6;
            // 
            // generalErrorLabel
            // 
            this.generalErrorLabel.AutoSize = true;
            this.generalErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.generalErrorLabel.Location = new System.Drawing.Point(325, 515);
            this.generalErrorLabel.Name = "generalErrorLabel";
            this.generalErrorLabel.Size = new System.Drawing.Size(99, 21);
            this.generalErrorLabel.TabIndex = 24;
            this.generalErrorLabel.Text = "*Error here";
            // 
            // FormsFunctionLabel
            // 
            this.FormsFunctionLabel.AutoSize = true;
            this.FormsFunctionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsFunctionLabel.Location = new System.Drawing.Point(12, 24);
            this.FormsFunctionLabel.Name = "FormsFunctionLabel";
            this.FormsFunctionLabel.Size = new System.Drawing.Size(206, 28);
            this.FormsFunctionLabel.TabIndex = 25;
            this.FormsFunctionLabel.Text = "Add new food to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edit Food Item Details";
            // 
            // dailyTrackerBindingSource1
            // 
            this.dailyTrackerBindingSource1.DataSource = typeof(FoodTrack.data.DailyTracker);
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormsFunctionLabel);
            this.Controls.Add(this.generalErrorLabel);
            this.Controls.Add(this.proteinTxt);
            this.Controls.Add(this.fatTxt);
            this.Controls.Add(this.carbsTxt);
            this.Controls.Add(this.caloriesTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.ProteinErrorLabel);
            this.Controls.Add(this.FatErrorLabel);
            this.Controls.Add(this.CarbsErrorLabel);
            this.Controls.Add(this.CaloriesErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.deleteFoodBtn);
            this.Controls.Add(this.saveEditsBtn);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.AddFoodBtn);
            this.Controls.Add(this.foodsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MealForm";
            this.Text = "MealForm";
            this.Load += new System.EventHandler(this.MealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyTrackerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox foodsListBox;
        private System.Windows.Forms.BindingSource dailyTrackerBindingSource1;
        private System.Windows.Forms.Button AddFoodBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Button saveEditsBtn;
        private System.Windows.Forms.Button deleteFoodBtn;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label CaloriesErrorLabel;
        private System.Windows.Forms.Label CarbsErrorLabel;
        private System.Windows.Forms.Label FatErrorLabel;
        private System.Windows.Forms.Label ProteinErrorLabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox caloriesTxt;
        private System.Windows.Forms.TextBox carbsTxt;
        private System.Windows.Forms.TextBox fatTxt;
        private System.Windows.Forms.TextBox proteinTxt;
        private System.Windows.Forms.Label generalErrorLabel;
        private System.Windows.Forms.Label FormsFunctionLabel;
        private System.Windows.Forms.Label label1;
    }
}