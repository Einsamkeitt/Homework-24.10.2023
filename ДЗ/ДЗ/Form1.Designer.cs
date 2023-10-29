namespace ДЗ
{
    partial class Form1
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
            this.logButton = new System.Windows.Forms.Button();
            this.callTypeComboBox = new System.Windows.Forms.ComboBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.callLogListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(472, 313);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(155, 28);
            this.logButton.TabIndex = 0;
            this.logButton.Text = "Выполнить";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // callTypeComboBox
            // 
            this.callTypeComboBox.FormattingEnabled = true;
            this.callTypeComboBox.Location = new System.Drawing.Point(415, 12);
            this.callTypeComboBox.Name = "callTypeComboBox";
            this.callTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.callTypeComboBox.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(405, 230);
            this.phoneNumberTextBox.Multiline = true;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(222, 42);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // callLogListBox
            // 
            this.callLogListBox.FormattingEnabled = true;
            this.callLogListBox.Location = new System.Drawing.Point(12, 12);
            this.callLogListBox.Name = "callLogListBox";
            this.callLogListBox.Size = new System.Drawing.Size(387, 329);
            this.callLogListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 356);
            this.Controls.Add(this.callLogListBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.callTypeComboBox);
            this.Controls.Add(this.logButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.ComboBox callTypeComboBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ListBox callLogListBox;
    }
}

