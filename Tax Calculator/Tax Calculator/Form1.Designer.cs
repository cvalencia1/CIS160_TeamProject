namespace Tax_Calculator
{
    partial class Form1
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
            this.income = new System.Windows.Forms.Label();
            this.txbIncome = new System.Windows.Forms.TextBox();
            this.txbTax = new System.Windows.Forms.TextBox();
            this.tax = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Location = new System.Drawing.Point(93, 60);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(123, 20);
            this.income.TabIndex = 0;
            this.income.Text = "Taxable income:";
            // 
            // txbIncome
            // 
            this.txbIncome.Location = new System.Drawing.Point(249, 57);
            this.txbIncome.Name = "txbIncome";
            this.txbIncome.Size = new System.Drawing.Size(150, 26);
            this.txbIncome.TabIndex = 1;
            // 
            // txbTax
            // 
            this.txbTax.Location = new System.Drawing.Point(249, 98);
            this.txbTax.Name = "txbTax";
            this.txbTax.ReadOnly = true;
            this.txbTax.Size = new System.Drawing.Size(150, 26);
            this.txbTax.TabIndex = 3;
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(93, 101);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(133, 20);
            this.tax.TabIndex = 2;
            this.tax.Text = "Income tax owed:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 28);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(351, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(469, 201);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbTax);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.txbIncome);
            this.Controls.Add(this.income);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label income;
        private System.Windows.Forms.TextBox txbIncome;
        private System.Windows.Forms.TextBox txbTax;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

