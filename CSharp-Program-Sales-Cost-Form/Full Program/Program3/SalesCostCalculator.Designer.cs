namespace Program3
{
    partial class SalesCostCalculator
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
            this.stateLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.productTxtBox = new System.Windows.Forms.TextBox();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.initCostLbl = new System.Windows.Forms.Label();
            this.discCostLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.initCostOutLbl = new System.Windows.Forms.Label();
            this.discCostOutLbl = new System.Windows.Forms.Label();
            this.taxOutLbl = new System.Windows.Forms.Label();
            this.totalCostOutLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(70, 16);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(35, 13);
            this.stateLbl.TabIndex = 0;
            this.stateLbl.Text = "State:";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(58, 43);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(47, 13);
            this.productLbl.TabIndex = 1;
            this.productLbl.Text = "Product:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(56, 68);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 2;
            this.quantityLbl.Text = "Quantity:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(118, 103);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "KY",
            "OH",
            "IN",
            "IL"});
            this.stateComboBox.Location = new System.Drawing.Point(108, 13);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 4;
            // 
            // productTxtBox
            // 
            this.productTxtBox.Location = new System.Drawing.Point(108, 40);
            this.productTxtBox.Name = "productTxtBox";
            this.productTxtBox.Size = new System.Drawing.Size(100, 20);
            this.productTxtBox.TabIndex = 5;
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Location = new System.Drawing.Point(108, 65);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTxtBox.TabIndex = 6;
            // 
            // initCostLbl
            // 
            this.initCostLbl.AutoSize = true;
            this.initCostLbl.Location = new System.Drawing.Point(44, 147);
            this.initCostLbl.Name = "initCostLbl";
            this.initCostLbl.Size = new System.Drawing.Size(58, 13);
            this.initCostLbl.TabIndex = 7;
            this.initCostLbl.Text = "Initial Cost:";
            // 
            // discCostLbl
            // 
            this.discCostLbl.AutoSize = true;
            this.discCostLbl.Location = new System.Drawing.Point(14, 178);
            this.discCostLbl.Name = "discCostLbl";
            this.discCostLbl.Size = new System.Drawing.Size(88, 13);
            this.discCostLbl.TabIndex = 8;
            this.discCostLbl.Text = "Discounted Cost:";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(74, 212);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(28, 13);
            this.taxLbl.TabIndex = 9;
            this.taxLbl.Text = "Tax:";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(44, 246);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(58, 13);
            this.totalCostLbl.TabIndex = 10;
            this.totalCostLbl.Text = "Total Cost:";
            // 
            // initCostOutLbl
            // 
            this.initCostOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initCostOutLbl.Location = new System.Drawing.Point(108, 146);
            this.initCostOutLbl.Name = "initCostOutLbl";
            this.initCostOutLbl.Size = new System.Drawing.Size(100, 18);
            this.initCostOutLbl.TabIndex = 11;
            // 
            // discCostOutLbl
            // 
            this.discCostOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discCostOutLbl.Location = new System.Drawing.Point(108, 177);
            this.discCostOutLbl.Name = "discCostOutLbl";
            this.discCostOutLbl.Size = new System.Drawing.Size(100, 18);
            this.discCostOutLbl.TabIndex = 12;
            // 
            // taxOutLbl
            // 
            this.taxOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutLbl.Location = new System.Drawing.Point(108, 211);
            this.taxOutLbl.Name = "taxOutLbl";
            this.taxOutLbl.Size = new System.Drawing.Size(100, 18);
            this.taxOutLbl.TabIndex = 13;
            // 
            // totalCostOutLbl
            // 
            this.totalCostOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutLbl.Location = new System.Drawing.Point(108, 245);
            this.totalCostOutLbl.Name = "totalCostOutLbl";
            this.totalCostOutLbl.Size = new System.Drawing.Size(100, 18);
            this.totalCostOutLbl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 306);
            this.Controls.Add(this.totalCostOutLbl);
            this.Controls.Add(this.taxOutLbl);
            this.Controls.Add(this.discCostOutLbl);
            this.Controls.Add(this.initCostOutLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.discCostLbl);
            this.Controls.Add(this.initCostLbl);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.productTxtBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.stateLbl);
            this.Name = "Form1";
            this.Text = "Sales Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox productTxtBox;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label initCostLbl;
        private System.Windows.Forms.Label discCostLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label initCostOutLbl;
        private System.Windows.Forms.Label discCostOutLbl;
        private System.Windows.Forms.Label taxOutLbl;
        private System.Windows.Forms.Label totalCostOutLbl;
    }
}

