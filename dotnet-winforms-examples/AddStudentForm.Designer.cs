namespace dotnet_winforms_examples
{
    partial class AddStudentForm
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBoxName = new System.Windows.Forms.TextBox();
            dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            textBoxFaculty = new System.Windows.Forms.TextBox();
            textBoxLastName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Button();
            saveStudentButton = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(dateTimePickerBirth);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxFaculty);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(saveStudentButton);
            groupBox1.Location = new System.Drawing.Point(24, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(756, 577);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додавання нового студента гуртожитку";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(274, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(400, 39);
            textBoxName.TabIndex = 12;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new System.Drawing.Point(274, 276);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new System.Drawing.Size(400, 39);
            dateTimePickerBirth.TabIndex = 11;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new System.Drawing.Point(274, 227);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new System.Drawing.Size(400, 39);
            textBoxPhoneNumber.TabIndex = 10;
            // 
            // textBoxFaculty
            // 
            textBoxFaculty.Location = new System.Drawing.Point(274, 178);
            textBoxFaculty.Name = "textBoxFaculty";
            textBoxFaculty.Size = new System.Drawing.Size(400, 39);
            textBoxFaculty.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new System.Drawing.Point(274, 130);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(400, 39);
            textBoxLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(60, 228);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(201, 32);
            label5.TabIndex = 6;
            label5.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(60, 274);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(210, 32);
            label4.TabIndex = 5;
            label4.Text = "Дата нарождення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 32);
            label3.TabIndex = 4;
            label3.Text = "Факультет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 32);
            label2.TabIndex = 3;
            label2.Text = "Прізвище";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(62, 90);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 32);
            label1.TabIndex = 2;
            label1.Text = "Імʼя";
            // 
            // closeButton
            // 
            closeButton.ForeColor = System.Drawing.Color.Red;
            closeButton.Location = new System.Drawing.Point(536, 446);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(138, 74);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // saveStudentButton
            // 
            saveStudentButton.Location = new System.Drawing.Point(62, 446);
            saveStudentButton.Name = "saveStudentButton";
            saveStudentButton.Size = new System.Drawing.Size(448, 74);
            saveStudentButton.TabIndex = 0;
            saveStudentButton.Text = "Додати студента";
            saveStudentButton.UseVisualStyleBackColor = true;
            saveStudentButton.Click += saveStudentButton_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(841, 657);
            Controls.Add(groupBox1);
            Name = "AddStudentForm";
            Text = "Вікно додавання нового студента";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveStudentButton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.TextBox textBoxLastName;
    }
}