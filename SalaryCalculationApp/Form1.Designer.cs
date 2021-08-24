
namespace SalaryCalculationApp
{
    partial class SalaryCalculationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.basicSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HouseRentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.calculateTotalSalaryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculateTotalSalaryButton);
            this.groupBox1.Controls.Add(this.totalSalaryTextBox);
            this.groupBox1.Controls.Add(this.medicalAllowanceTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HouseRentTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.basicSalaryTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // basicSalaryTextBox
            // 
            this.basicSalaryTextBox.Location = new System.Drawing.Point(247, 51);
            this.basicSalaryTextBox.Name = "basicSalaryTextBox";
            this.basicSalaryTextBox.Size = new System.Drawing.Size(200, 22);
            this.basicSalaryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "House Rent";
            // 
            // HouseRentTextBox
            // 
            this.HouseRentTextBox.Location = new System.Drawing.Point(247, 79);
            this.HouseRentTextBox.Name = "HouseRentTextBox";
            this.HouseRentTextBox.Size = new System.Drawing.Size(200, 22);
            this.HouseRentTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "% of Basic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "% of Basic";
            // 
            // medicalAllowanceTextBox
            // 
            this.medicalAllowanceTextBox.Location = new System.Drawing.Point(247, 107);
            this.medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            this.medicalAllowanceTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicalAllowanceTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Salary";
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Location = new System.Drawing.Point(247, 185);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.ReadOnly = true;
            this.totalSalaryTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalSalaryTextBox.TabIndex = 4;
            // 
            // calculateTotalSalaryButton
            // 
            this.calculateTotalSalaryButton.Location = new System.Drawing.Point(247, 136);
            this.calculateTotalSalaryButton.Name = "calculateTotalSalaryButton";
            this.calculateTotalSalaryButton.Size = new System.Drawing.Size(200, 32);
            this.calculateTotalSalaryButton.TabIndex = 3;
            this.calculateTotalSalaryButton.Text = "Calculate Total Salary";
            this.calculateTotalSalaryButton.UseVisualStyleBackColor = true;
            this.calculateTotalSalaryButton.Click += new System.EventHandler(this.calculateTotalSalaryButton_Click);
            // 
            // SalaryCalculationUI
            // 
            this.AcceptButton = this.calculateTotalSalaryButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 364);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryCalculationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox basicSalaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateTotalSalaryButton;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
        private System.Windows.Forms.TextBox medicalAllowanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HouseRentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

