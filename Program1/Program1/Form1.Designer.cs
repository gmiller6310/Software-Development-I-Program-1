namespace Program1
{
    partial class program1Form
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
            this.enterSquareFeetLabel = new System.Windows.Forms.Label();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.enterCoatNumberLabel = new System.Windows.Forms.Label();
            this.paintCoatTextBox = new System.Windows.Forms.TextBox();
            this.enterPaintPriceLabel = new System.Windows.Forms.Label();
            this.paintPriceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalSquareFeetLabel = new System.Windows.Forms.Label();
            this.totalSquareFeetOutputLabel = new System.Windows.Forms.Label();
            this.totalPaintGallonsLabel = new System.Windows.Forms.Label();
            this.totalPaintGallonsOutputLabel = new System.Windows.Forms.Label();
            this.hoursOfLaborLabel = new System.Windows.Forms.Label();
            this.hoursOfLaborOutputLabel = new System.Windows.Forms.Label();
            this.costOfPaintLabel = new System.Windows.Forms.Label();
            this.costOfPaintOutputLabel = new System.Windows.Forms.Label();
            this.costOfLaborLabel = new System.Windows.Forms.Label();
            this.costOfLaborOutputLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterSquareFeetLabel
            // 
            this.enterSquareFeetLabel.AutoSize = true;
            this.enterSquareFeetLabel.Location = new System.Drawing.Point(179, 15);
            this.enterSquareFeetLabel.Name = "enterSquareFeetLabel";
            this.enterSquareFeetLabel.Size = new System.Drawing.Size(195, 13);
            this.enterSquareFeetLabel.TabIndex = 0;
            this.enterSquareFeetLabel.Text = "Square feet of wall space to be painted:";
            // 
            // squareFeetTextBox
            // 
            this.squareFeetTextBox.Location = new System.Drawing.Point(400, 12);
            this.squareFeetTextBox.Name = "squareFeetTextBox";
            this.squareFeetTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareFeetTextBox.TabIndex = 1;
            // 
            // enterCoatNumberLabel
            // 
            this.enterCoatNumberLabel.AutoSize = true;
            this.enterCoatNumberLabel.Location = new System.Drawing.Point(131, 50);
            this.enterCoatNumberLabel.Name = "enterCoatNumberLabel";
            this.enterCoatNumberLabel.Size = new System.Drawing.Size(243, 13);
            this.enterCoatNumberLabel.TabIndex = 2;
            this.enterCoatNumberLabel.Text = "Number of coats of paint desired (Whole Number):";
            // 
            // paintCoatTextBox
            // 
            this.paintCoatTextBox.Location = new System.Drawing.Point(400, 47);
            this.paintCoatTextBox.Name = "paintCoatTextBox";
            this.paintCoatTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintCoatTextBox.TabIndex = 3;
            // 
            // enterPaintPriceLabel
            // 
            this.enterPaintPriceLabel.AutoSize = true;
            this.enterPaintPriceLabel.Location = new System.Drawing.Point(235, 84);
            this.enterPaintPriceLabel.Name = "enterPaintPriceLabel";
            this.enterPaintPriceLabel.Size = new System.Drawing.Size(139, 13);
            this.enterPaintPriceLabel.TabIndex = 4;
            this.enterPaintPriceLabel.Text = "Price of the paint per gallon:";
            // 
            // paintPriceTextBox
            // 
            this.paintPriceTextBox.Location = new System.Drawing.Point(400, 81);
            this.paintPriceTextBox.Name = "paintPriceTextBox";
            this.paintPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintPriceTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 50);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalSquareFeetLabel
            // 
            this.totalSquareFeetLabel.AutoSize = true;
            this.totalSquareFeetLabel.Location = new System.Drawing.Point(12, 135);
            this.totalSquareFeetLabel.Name = "totalSquareFeetLabel";
            this.totalSquareFeetLabel.Size = new System.Drawing.Size(155, 13);
            this.totalSquareFeetLabel.TabIndex = 7;
            this.totalSquareFeetLabel.Text = "Total square feet to be painted:";
            // 
            // totalSquareFeetOutputLabel
            // 
            this.totalSquareFeetOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquareFeetOutputLabel.Location = new System.Drawing.Point(173, 134);
            this.totalSquareFeetOutputLabel.Name = "totalSquareFeetOutputLabel";
            this.totalSquareFeetOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSquareFeetOutputLabel.TabIndex = 8;
            // 
            // totalPaintGallonsLabel
            // 
            this.totalPaintGallonsLabel.AutoSize = true;
            this.totalPaintGallonsLabel.Location = new System.Drawing.Point(279, 135);
            this.totalPaintGallonsLabel.Name = "totalPaintGallonsLabel";
            this.totalPaintGallonsLabel.Size = new System.Drawing.Size(199, 13);
            this.totalPaintGallonsLabel.TabIndex = 9;
            this.totalPaintGallonsLabel.Text = "Total number of gallons of paint required:";
            // 
            // totalPaintGallonsOutputLabel
            // 
            this.totalPaintGallonsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPaintGallonsOutputLabel.Location = new System.Drawing.Point(484, 134);
            this.totalPaintGallonsOutputLabel.Name = "totalPaintGallonsOutputLabel";
            this.totalPaintGallonsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPaintGallonsOutputLabel.TabIndex = 10;
            // 
            // hoursOfLaborLabel
            // 
            this.hoursOfLaborLabel.AutoSize = true;
            this.hoursOfLaborLabel.Location = new System.Drawing.Point(25, 167);
            this.hoursOfLaborLabel.Name = "hoursOfLaborLabel";
            this.hoursOfLaborLabel.Size = new System.Drawing.Size(142, 13);
            this.hoursOfLaborLabel.TabIndex = 11;
            this.hoursOfLaborLabel.Text = "Total hours of labor required:";
            // 
            // hoursOfLaborOutputLabel
            // 
            this.hoursOfLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOfLaborOutputLabel.Location = new System.Drawing.Point(173, 167);
            this.hoursOfLaborOutputLabel.Name = "hoursOfLaborOutputLabel";
            this.hoursOfLaborOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.hoursOfLaborOutputLabel.TabIndex = 12;
            // 
            // costOfPaintLabel
            // 
            this.costOfPaintLabel.AutoSize = true;
            this.costOfPaintLabel.Location = new System.Drawing.Point(365, 167);
            this.costOfPaintLabel.Name = "costOfPaintLabel";
            this.costOfPaintLabel.Size = new System.Drawing.Size(113, 13);
            this.costOfPaintLabel.TabIndex = 13;
            this.costOfPaintLabel.Text = "Total cost of the paint:";
            // 
            // costOfPaintOutputLabel
            // 
            this.costOfPaintOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfPaintOutputLabel.Location = new System.Drawing.Point(484, 167);
            this.costOfPaintOutputLabel.Name = "costOfPaintOutputLabel";
            this.costOfPaintOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.costOfPaintOutputLabel.TabIndex = 14;
            // 
            // costOfLaborLabel
            // 
            this.costOfLaborLabel.AutoSize = true;
            this.costOfLaborLabel.Location = new System.Drawing.Point(54, 203);
            this.costOfLaborLabel.Name = "costOfLaborLabel";
            this.costOfLaborLabel.Size = new System.Drawing.Size(113, 13);
            this.costOfLaborLabel.TabIndex = 15;
            this.costOfLaborLabel.Text = "Total cost of the labor:";
            // 
            // costOfLaborOutputLabel
            // 
            this.costOfLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfLaborOutputLabel.Location = new System.Drawing.Point(173, 203);
            this.costOfLaborOutputLabel.Name = "costOfLaborOutputLabel";
            this.costOfLaborOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.costOfLaborOutputLabel.TabIndex = 16;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(348, 203);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(130, 13);
            this.totalCostLabel.TabIndex = 17;
            this.totalCostLabel.Text = "Total cost of the paint job:";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(484, 202);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutputLabel.TabIndex = 18;
            // 
            // program1Form
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 264);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.costOfLaborOutputLabel);
            this.Controls.Add(this.costOfLaborLabel);
            this.Controls.Add(this.costOfPaintOutputLabel);
            this.Controls.Add(this.costOfPaintLabel);
            this.Controls.Add(this.hoursOfLaborOutputLabel);
            this.Controls.Add(this.hoursOfLaborLabel);
            this.Controls.Add(this.totalPaintGallonsOutputLabel);
            this.Controls.Add(this.totalPaintGallonsLabel);
            this.Controls.Add(this.totalSquareFeetOutputLabel);
            this.Controls.Add(this.totalSquareFeetLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.paintPriceTextBox);
            this.Controls.Add(this.enterPaintPriceLabel);
            this.Controls.Add(this.paintCoatTextBox);
            this.Controls.Add(this.enterCoatNumberLabel);
            this.Controls.Add(this.squareFeetTextBox);
            this.Controls.Add(this.enterSquareFeetLabel);
            this.Name = "program1Form";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterSquareFeetLabel;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.Label enterCoatNumberLabel;
        private System.Windows.Forms.TextBox paintCoatTextBox;
        private System.Windows.Forms.Label enterPaintPriceLabel;
        private System.Windows.Forms.TextBox paintPriceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalSquareFeetLabel;
        private System.Windows.Forms.Label totalSquareFeetOutputLabel;
        private System.Windows.Forms.Label totalPaintGallonsLabel;
        private System.Windows.Forms.Label totalPaintGallonsOutputLabel;
        private System.Windows.Forms.Label hoursOfLaborLabel;
        private System.Windows.Forms.Label hoursOfLaborOutputLabel;
        private System.Windows.Forms.Label costOfPaintLabel;
        private System.Windows.Forms.Label costOfPaintOutputLabel;
        private System.Windows.Forms.Label costOfLaborLabel;
        private System.Windows.Forms.Label costOfLaborOutputLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
    }
}

