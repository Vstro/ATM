namespace ATM
{
    partial class GetCashForm
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
            this.CashSumLabel = new System.Windows.Forms.Label();
            this.GetCashButton = new System.Windows.Forms.Button();
            this.CashSumTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.AvailableBanknotesLabel = new System.Windows.Forms.Label();
            this.OutOfMoneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CashSumLabel
            // 
            this.CashSumLabel.AutoSize = true;
            this.CashSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashSumLabel.Location = new System.Drawing.Point(239, 94);
            this.CashSumLabel.Name = "CashSumLabel";
            this.CashSumLabel.Size = new System.Drawing.Size(239, 32);
            this.CashSumLabel.TabIndex = 0;
            this.CashSumLabel.Text = "Сумма к выдаче:";
            // 
            // GetCashButton
            // 
            this.GetCashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetCashButton.Location = new System.Drawing.Point(439, 285);
            this.GetCashButton.Name = "GetCashButton";
            this.GetCashButton.Size = new System.Drawing.Size(156, 46);
            this.GetCashButton.TabIndex = 1;
            this.GetCashButton.Text = "Получить";
            this.GetCashButton.UseVisualStyleBackColor = true;
            this.GetCashButton.Click += new System.EventHandler(this.GetCashButton_Click);
            // 
            // CashSumTextBox
            // 
            this.CashSumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashSumTextBox.Location = new System.Drawing.Point(476, 91);
            this.CashSumTextBox.MaxLength = 10;
            this.CashSumTextBox.Name = "CashSumTextBox";
            this.CashSumTextBox.Size = new System.Drawing.Size(120, 39);
            this.CashSumTextBox.TabIndex = 2;
            this.CashSumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashSumTextBox.TextChanged += new System.EventHandler(this.CashSumTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(245, 285);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 46);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AvailableBanknotesLabel
            // 
            this.AvailableBanknotesLabel.AutoSize = true;
            this.AvailableBanknotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableBanknotesLabel.Location = new System.Drawing.Point(136, 188);
            this.AvailableBanknotesLabel.Name = "AvailableBanknotesLabel";
            this.AvailableBanknotesLabel.Size = new System.Drawing.Size(300, 32);
            this.AvailableBanknotesLabel.TabIndex = 4;
            this.AvailableBanknotesLabel.Text = "Купюры в наличии: ...";
            this.AvailableBanknotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AvailableBanknotesLabel.UseMnemonic = false;
            // 
            // OutOfMoneyLabel
            // 
            this.OutOfMoneyLabel.AutoSize = true;
            this.OutOfMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutOfMoneyLabel.ForeColor = System.Drawing.Color.Red;
            this.OutOfMoneyLabel.Location = new System.Drawing.Point(202, 39);
            this.OutOfMoneyLabel.Name = "OutOfMoneyLabel";
            this.OutOfMoneyLabel.Size = new System.Drawing.Size(441, 32);
            this.OutOfMoneyLabel.TabIndex = 5;
            this.OutOfMoneyLabel.Text = "На счёте недостаточно средств!";
            this.OutOfMoneyLabel.Visible = false;
            // 
            // GetCashForm
            // 
            this.AcceptButton = this.GetCashButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 445);
            this.Controls.Add(this.OutOfMoneyLabel);
            this.Controls.Add(this.AvailableBanknotesLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CashSumTextBox);
            this.Controls.Add(this.GetCashButton);
            this.Controls.Add(this.CashSumLabel);
            this.Name = "GetCashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CashSumLabel;
        private System.Windows.Forms.Button GetCashButton;
        private System.Windows.Forms.TextBox CashSumTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AvailableBanknotesLabel;
        private System.Windows.Forms.Label OutOfMoneyLabel;
    }
}