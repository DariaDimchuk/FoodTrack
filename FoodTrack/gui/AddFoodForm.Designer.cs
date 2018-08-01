namespace FoodTrack
{
    partial class AddFoodForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.fatLabel = new System.Windows.Forms.Label();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.CaloriesErrorLabel = new System.Windows.Forms.Label();
            this.CarbsErrorLabel = new System.Windows.Forms.Label();
            this.FatErrorLabel = new System.Windows.Forms.Label();
            this.ProteinErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(137, 347);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 39);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(101, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(101, 86);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(282, 26);
            this.caloriesTextBox.TabIndex = 1;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(23, 89);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(66, 20);
            this.caloriesLabel.TabIndex = 4;
            this.caloriesLabel.Text = "Calories";
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(101, 147);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(282, 26);
            this.carbsTextBox.TabIndex = 2;
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(23, 150);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(51, 20);
            this.carbsLabel.TabIndex = 6;
            this.carbsLabel.Text = "Carbs";
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(101, 210);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(282, 26);
            this.fatTextBox.TabIndex = 3;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(23, 213);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(33, 20);
            this.fatLabel.TabIndex = 8;
            this.fatLabel.Text = "Fat";
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(101, 271);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(282, 26);
            this.proteinTextBox.TabIndex = 4;
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(23, 274);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(59, 20);
            this.proteinLabel.TabIndex = 10;
            this.proteinLabel.Text = "Protein";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(263, 347);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 39);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(23, 63);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(86, 20);
            this.NameErrorLabel.TabIndex = 12;
            this.NameErrorLabel.Text = "*Error here";
            // 
            // CaloriesErrorLabel
            // 
            this.CaloriesErrorLabel.AutoSize = true;
            this.CaloriesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CaloriesErrorLabel.Location = new System.Drawing.Point(23, 124);
            this.CaloriesErrorLabel.Name = "CaloriesErrorLabel";
            this.CaloriesErrorLabel.Size = new System.Drawing.Size(86, 20);
            this.CaloriesErrorLabel.TabIndex = 13;
            this.CaloriesErrorLabel.Text = "*Error here";
            // 
            // CarbsErrorLabel
            // 
            this.CarbsErrorLabel.AutoSize = true;
            this.CarbsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CarbsErrorLabel.Location = new System.Drawing.Point(23, 187);
            this.CarbsErrorLabel.Name = "CarbsErrorLabel";
            this.CarbsErrorLabel.Size = new System.Drawing.Size(86, 20);
            this.CarbsErrorLabel.TabIndex = 14;
            this.CarbsErrorLabel.Text = "*Error here";
            // 
            // FatErrorLabel
            // 
            this.FatErrorLabel.AutoSize = true;
            this.FatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FatErrorLabel.Location = new System.Drawing.Point(23, 248);
            this.FatErrorLabel.Name = "FatErrorLabel";
            this.FatErrorLabel.Size = new System.Drawing.Size(86, 20);
            this.FatErrorLabel.TabIndex = 15;
            this.FatErrorLabel.Text = "*Error here";
            // 
            // ProteinErrorLabel
            // 
            this.ProteinErrorLabel.AutoSize = true;
            this.ProteinErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ProteinErrorLabel.Location = new System.Drawing.Point(23, 310);
            this.ProteinErrorLabel.Name = "ProteinErrorLabel";
            this.ProteinErrorLabel.Size = new System.Drawing.Size(86, 20);
            this.ProteinErrorLabel.TabIndex = 16;
            this.ProteinErrorLabel.Text = "*Error here";
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 399);
            this.Controls.Add(this.ProteinErrorLabel);
            this.Controls.Add(this.FatErrorLabel);
            this.Controls.Add(this.CarbsErrorLabel);
            this.Controls.Add(this.CaloriesErrorLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.proteinTextBox);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbsTextBox);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddFoodForm";
            this.Text = "Add New Food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label CaloriesErrorLabel;
        private System.Windows.Forms.Label CarbsErrorLabel;
        private System.Windows.Forms.Label FatErrorLabel;
        private System.Windows.Forms.Label ProteinErrorLabel;
    }
}