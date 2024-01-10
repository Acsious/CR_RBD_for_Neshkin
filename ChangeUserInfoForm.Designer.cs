namespace CR_RBD_for_Neshkin
{
    partial class ChangeUserInfoForm
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
            ApplyChangesButton = new Button();
            MiddleNameTextBox = new TextBox();
            label5 = new Label();
            FirstNameTextBox = new TextBox();
            label4 = new Label();
            SecondNameTextBox = new TextBox();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            LoginTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ApplyChangesButton
            // 
            ApplyChangesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ApplyChangesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ApplyChangesButton.Location = new Point(12, 375);
            ApplyChangesButton.Name = "ApplyChangesButton";
            ApplyChangesButton.Size = new Size(316, 57);
            ApplyChangesButton.TabIndex = 21;
            ApplyChangesButton.Text = "Принять изменения";
            ApplyChangesButton.UseVisualStyleBackColor = true;
            ApplyChangesButton.Click += ApplyChangesButton_Click;
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MiddleNameTextBox.Location = new Point(12, 322);
            MiddleNameTextBox.MaxLength = 40;
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(316, 23);
            MiddleNameTextBox.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 292);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 19;
            label5.Text = "Отчество";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FirstNameTextBox.Location = new Point(12, 248);
            FirstNameTextBox.MaxLength = 40;
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(316, 23);
            FirstNameTextBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 17;
            label4.Text = "Имя";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SecondNameTextBox.Location = new Point(12, 179);
            SecondNameTextBox.MaxLength = 40;
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(316, 23);
            SecondNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 15;
            label3.Text = "Фамилия";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(12, 110);
            PasswordTextBox.MaxLength = 40;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(316, 23);
            PasswordTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 13;
            label2.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.Location = new Point(12, 43);
            LoginTextBox.MaxLength = 40;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(316, 23);
            LoginTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 11;
            label1.Text = "Логин";
            // 
            // ChangeUserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(ApplyChangesButton);
            Controls.Add(MiddleNameTextBox);
            Controls.Add(label5);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(SecondNameTextBox);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(LoginTextBox);
            Controls.Add(label1);
            Name = "ChangeUserInfoForm";
            Text = "ChangeUserInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ApplyChangesButton;
        private TextBox MiddleNameTextBox;
        private Label label5;
        private TextBox FirstNameTextBox;
        private Label label4;
        private TextBox SecondNameTextBox;
        private Label label3;
        private TextBox PasswordTextBox;
        private Label label2;
        private TextBox LoginTextBox;
        private Label label1;
    }
}