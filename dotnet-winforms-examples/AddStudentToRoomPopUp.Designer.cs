namespace dotnet_winforms_examples
{
    partial class AddStudentToRoomPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>comboBoxStudents
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
            button1 = new System.Windows.Forms.Button();
            comboBoxStudents = new System.Windows.Forms.ComboBox();
            addStudentToRoomButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(559, 328);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(183, 79);
            button1.TabIndex = 0;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new System.Drawing.Point(57, 66);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new System.Drawing.Size(242, 40);
            comboBoxStudents.TabIndex = 1;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // addStudentToRoomButton
            // 
            addStudentToRoomButton.Location = new System.Drawing.Point(57, 328);
            addStudentToRoomButton.Name = "addStudentToRoomButton";
            addStudentToRoomButton.Size = new System.Drawing.Size(446, 79);
            addStudentToRoomButton.TabIndex = 2;
            addStudentToRoomButton.Text = "Додати студента до кімнати";
            addStudentToRoomButton.UseVisualStyleBackColor = true;
            addStudentToRoomButton.Click += addStudentToRoomButton_Click;
            // 
            // AddStudentToRoomPopUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(addStudentToRoomButton);
            Controls.Add(comboBoxStudents);
            Controls.Add(button1);
            Name = "AddStudentToRoomPopUp";
            Text = "AddStudentToRoomPopUp";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Button addStudentToRoomButton;
    }
}