namespace FoodTrack.gui
{
    partial class SetGoalsForm
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
            this.proteinLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.caloriesTxt = new System.Windows.Forms.TextBox();
            this.carbsTxt = new System.Windows.Forms.TextBox();
            this.fatTxt = new System.Windows.Forms.TextBox();
            this.proteinTxt = new System.Windows.Forms.TextBox();
            this.CaloriesErrorLabel = new System.Windows.Forms.Label();
            this.CarbsErrorLabel = new System.Windows.Forms.Label();
            this.FatErrorLabel = new System.Windows.Forms.Label();
            this.ProteinErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.Location = new System.Drawing.Point(12, 300);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(131, 23);
            this.proteinLabel.TabIndex = 22;
            this.proteinLabel.Text = "Protein Goal";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(12, 225);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(96, 23);
            this.fatLabel.TabIndex = 20;
            this.fatLabel.Text = "Fat Goal";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsLabel.Location = new System.Drawing.Point(12, 145);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(123, 23);
            this.carbsLabel.TabIndex = 18;
            this.carbsLabel.Text = "Carbs Goal";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(12, 70);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(143, 23);
            this.caloriesLabel.TabIndex = 16;
            this.caloriesLabel.Text = "Calories Goal";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(144, 378);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 45);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(270, 378);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 45);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // caloriesTxt
            // 
            this.caloriesTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesTxt.Location = new System.Drawing.Point(212, 72);
            this.caloriesTxt.Name = "caloriesTxt";
            this.caloriesTxt.Size = new System.Drawing.Size(178, 32);
            this.caloriesTxt.TabIndex = 23;
            // 
            // carbsTxt
            // 
            this.carbsTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsTxt.Location = new System.Drawing.Point(212, 142);
            this.carbsTxt.Name = "carbsTxt";
            this.carbsTxt.Size = new System.Drawing.Size(178, 32);
            this.carbsTxt.TabIndex = 24;
            // 
            // fatTxt
            // 
            this.fatTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatTxt.Location = new System.Drawing.Point(212, 222);
            this.fatTxt.Name = "fatTxt";
            this.fatTxt.Size = new System.Drawing.Size(178, 32);
            this.fatTxt.TabIndex = 25;
            // 
            // proteinTxt
            // 
            this.proteinTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinTxt.Location = new System.Drawing.Point(212, 297);
            this.proteinTxt.Name = "proteinTxt";
            this.proteinTxt.Size = new System.Drawing.Size(178, 32);
            this.proteinTxt.TabIndex = 26;
            // 
            // CaloriesErrorLabel
            // 
            this.CaloriesErrorLabel.AutoSize = true;
            this.CaloriesErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CaloriesErrorLabel.Location = new System.Drawing.Point(12, 110);
            this.CaloriesErrorLabel.Name = "CaloriesErrorLabel";
            this.CaloriesErrorLabel.Size = new System.Drawing.Size(100, 21);
            this.CaloriesErrorLabel.TabIndex = 27;
            this.CaloriesErrorLabel.Text = "*Error Here";
            // 
            // CarbsErrorLabel
            // 
            this.CarbsErrorLabel.AutoSize = true;
            this.CarbsErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CarbsErrorLabel.Location = new System.Drawing.Point(12, 185);
            this.CarbsErrorLabel.Name = "CarbsErrorLabel";
            this.CarbsErrorLabel.Size = new System.Drawing.Size(100, 21);
            this.CarbsErrorLabel.TabIndex = 28;
            this.CarbsErrorLabel.Text = "*Error Here";
            // 
            // FatErrorLabel
            // 
            this.FatErrorLabel.AutoSize = true;
            this.FatErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FatErrorLabel.Location = new System.Drawing.Point(12, 265);
            this.FatErrorLabel.Name = "FatErrorLabel";
            this.FatErrorLabel.Size = new System.Drawing.Size(100, 21);
            this.FatErrorLabel.TabIndex = 29;
            this.FatErrorLabel.Text = "*Error Here";
            // 
            // ProteinErrorLabel
            // 
            this.ProteinErrorLabel.AutoSize = true;
            this.ProteinErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ProteinErrorLabel.Location = new System.Drawing.Point(12, 340);
            this.ProteinErrorLabel.Name = "ProteinErrorLabel";
            this.ProteinErrorLabel.Size = new System.Drawing.Size(100, 21);
            this.ProteinErrorLabel.TabIndex = 30;
            this.ProteinErrorLabel.Text = "*Error Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Set Nutrition Goals";
            // 
            // SetGoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProteinErrorLabel);
            this.Controls.Add(this.FatErrorLabel);
            this.Controls.Add(this.CarbsErrorLabel);
            this.Controls.Add(this.CaloriesErrorLabel);
            this.Controls.Add(this.proteinTxt);
            this.Controls.Add(this.fatTxt);
            this.Controls.Add(this.carbsTxt);
            this.Controls.Add(this.caloriesTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SetGoalsForm";
            this.Text = "Set Goals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox caloriesTxt;
        private System.Windows.Forms.TextBox carbsTxt;
        private System.Windows.Forms.TextBox fatTxt;
        private System.Windows.Forms.TextBox proteinTxt;
        private System.Windows.Forms.Label CaloriesErrorLabel;
        private System.Windows.Forms.Label CarbsErrorLabel;
        private System.Windows.Forms.Label FatErrorLabel;
        private System.Windows.Forms.Label ProteinErrorLabel;
        private System.Windows.Forms.Label label1;
    }
}