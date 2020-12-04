namespace ATM
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
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.CardReturnButton = new System.Windows.Forms.Button();
            this.GetCashButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardTypeLabel
            // 
            this.CardTypeLabel.AutoSize = true;
            this.CardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardTypeLabel.Location = new System.Drawing.Point(341, 14);
            this.CardTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardTypeLabel.Name = "CardTypeLabel";
            this.CardTypeLabel.Size = new System.Drawing.Size(154, 33);
            this.CardTypeLabel.TabIndex = 0;
            this.CardTypeLabel.Text = "Тип карты";
            // 
            // CardReturnButton
            // 
            this.CardReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardReturnButton.Location = new System.Drawing.Point(454, 286);
            this.CardReturnButton.Name = "CardReturnButton";
            this.CardReturnButton.Size = new System.Drawing.Size(219, 42);
            this.CardReturnButton.TabIndex = 1;
            this.CardReturnButton.Text = "Возврат карты";
            this.CardReturnButton.UseVisualStyleBackColor = true;
            this.CardReturnButton.Click += new System.EventHandler(this.CardReturnButton_Click);
            // 
            // GetCashButton
            // 
            this.GetCashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetCashButton.Location = new System.Drawing.Point(188, 286);
            this.GetCashButton.Name = "GetCashButton";
            this.GetCashButton.Size = new System.Drawing.Size(219, 42);
            this.GetCashButton.TabIndex = 2;
            this.GetCashButton.Text = "Выдача средств";
            this.GetCashButton.UseVisualStyleBackColor = true;
            this.GetCashButton.Click += new System.EventHandler(this.GetCashButton_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceLabel.Location = new System.Drawing.Point(335, 156);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(181, 32);
            this.BalanceLabel.TabIndex = 3;
            this.BalanceLabel.Text = "Баланс: ... р.";
            // 
            // MainForm
            // 
            this.AcceptButton = this.GetCashButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 445);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.GetCashButton);
            this.Controls.Add(this.CardReturnButton);
            this.Controls.Add(this.CardTypeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardTypeLabel;
        private System.Windows.Forms.Button CardReturnButton;
        private System.Windows.Forms.Button GetCashButton;
        private System.Windows.Forms.Label BalanceLabel;
    }
}