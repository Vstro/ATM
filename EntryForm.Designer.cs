namespace ATM
{
    partial class EntryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.PincodeTextBox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.Pincodelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(166, 100);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(251, 20);
            this.CardNumberTextBox.TabIndex = 0;
            this.CardNumberTextBox.TextChanged += new System.EventHandler(this.CardNumberTextBox_TextChanged);
            // 
            // PincodeTextBox
            // 
            this.PincodeTextBox.Location = new System.Drawing.Point(230, 170);
            this.PincodeTextBox.MaxLength = 4;
            this.PincodeTextBox.Name = "PincodeTextBox";
            this.PincodeTextBox.PasswordChar = '*';
            this.PincodeTextBox.Size = new System.Drawing.Size(115, 20);
            this.PincodeTextBox.TabIndex = 1;
            this.PincodeTextBox.UseSystemPasswordChar = true;
            this.PincodeTextBox.WordWrap = false;
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(230, 230);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(115, 27);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "Input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(226, 73);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(119, 24);
            this.CardNumberLabel.TabIndex = 3;
            this.CardNumberLabel.Text = "CardNumber";
            // 
            // Pincodelabel
            // 
            this.Pincodelabel.AutoSize = true;
            this.Pincodelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pincodelabel.Location = new System.Drawing.Point(250, 143);
            this.Pincodelabel.Name = "Pincodelabel";
            this.Pincodelabel.Size = new System.Drawing.Size(80, 24);
            this.Pincodelabel.TabIndex = 4;
            this.Pincodelabel.Text = "Pincode";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 331);
            this.Controls.Add(this.Pincodelabel);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.PincodeTextBox);
            this.Controls.Add(this.CardNumberTextBox);
            this.Name = "EntryForm";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.TextBox PincodeTextBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label Pincodelabel;
    }
}

