namespace CR_RBD_for_Neshkin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numPassedCadetsPerInstructor = new Button();
            numCorrectAnswersOnTicketsPerCadetButton = new Button();
            DeleteSignUpButton = new Button();
            MakeSignUpButton = new Button();
            ChangeUserInfoButton = new Button();
            SuspendLayout();
            // 
            // numPassedCadetsPerInstructor
            // 
            numPassedCadetsPerInstructor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numPassedCadetsPerInstructor.Location = new Point(12, 298);
            numPassedCadetsPerInstructor.Name = "numPassedCadetsPerInstructor";
            numPassedCadetsPerInstructor.Size = new Size(446, 65);
            numPassedCadetsPerInstructor.TabIndex = 9;
            numPassedCadetsPerInstructor.Text = "Просмотреть кол-во допущенных к экзамену курсантов по инструкторам";
            numPassedCadetsPerInstructor.UseVisualStyleBackColor = true;
            numPassedCadetsPerInstructor.Click += numPassedCadetsPerInstructor_Click;
            // 
            // numCorrectAnswersOnTicketsPerCadetButton
            // 
            numCorrectAnswersOnTicketsPerCadetButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numCorrectAnswersOnTicketsPerCadetButton.Location = new Point(14, 212);
            numCorrectAnswersOnTicketsPerCadetButton.Name = "numCorrectAnswersOnTicketsPerCadetButton";
            numCorrectAnswersOnTicketsPerCadetButton.Size = new Size(446, 64);
            numCorrectAnswersOnTicketsPerCadetButton.TabIndex = 8;
            numCorrectAnswersOnTicketsPerCadetButton.Text = "Просмотреть кол-во правильно решённых \r\nбилетов по курсантам";
            numCorrectAnswersOnTicketsPerCadetButton.UseVisualStyleBackColor = true;
            numCorrectAnswersOnTicketsPerCadetButton.Click += numCorrectAnswersOnTicketsPerCadetButton_Click;
            // 
            // DeleteSignUpButton
            // 
            DeleteSignUpButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSignUpButton.Location = new Point(12, 147);
            DeleteSignUpButton.Name = "DeleteSignUpButton";
            DeleteSignUpButton.Size = new Size(446, 43);
            DeleteSignUpButton.TabIndex = 7;
            DeleteSignUpButton.Text = "Отменить запись на занятие";
            DeleteSignUpButton.UseVisualStyleBackColor = true;
            DeleteSignUpButton.Click += DeleteSignUpButton_Click;
            // 
            // MakeSignUpButton
            // 
            MakeSignUpButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MakeSignUpButton.Location = new Point(12, 78);
            MakeSignUpButton.Name = "MakeSignUpButton";
            MakeSignUpButton.Size = new Size(446, 43);
            MakeSignUpButton.TabIndex = 6;
            MakeSignUpButton.Text = "Записать на занятие";
            MakeSignUpButton.UseVisualStyleBackColor = true;
            MakeSignUpButton.Click += MakeSignUpButton_Click;
            // 
            // ChangeUserInfoButton
            // 
            ChangeUserInfoButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeUserInfoButton.Location = new Point(12, 12);
            ChangeUserInfoButton.Name = "ChangeUserInfoButton";
            ChangeUserInfoButton.Size = new Size(446, 43);
            ChangeUserInfoButton.TabIndex = 5;
            ChangeUserInfoButton.Text = "Изменить личную информацию";
            ChangeUserInfoButton.UseVisualStyleBackColor = true;
            ChangeUserInfoButton.Click += ChangeUserInfoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 375);
            Controls.Add(numPassedCadetsPerInstructor);
            Controls.Add(numCorrectAnswersOnTicketsPerCadetButton);
            Controls.Add(DeleteSignUpButton);
            Controls.Add(MakeSignUpButton);
            Controls.Add(ChangeUserInfoButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button numPassedCadetsPerInstructor;
        private Button numCorrectAnswersOnTicketsPerCadetButton;
        private Button DeleteSignUpButton;
        private Button MakeSignUpButton;
        private Button ChangeUserInfoButton;
    }
}