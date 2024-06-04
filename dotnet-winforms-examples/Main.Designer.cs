namespace dotnet_winforms_examples
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            tabControlRooms = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            flashMessageLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            updateButton2 = new System.Windows.Forms.Button();
            addStudentButton = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            exitBtn = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            flashMessageLabelRooms = new System.Windows.Forms.Label();
            exitBtn2 = new System.Windows.Forms.Button();
            groupBoxOfRooms = new System.Windows.Forms.GroupBox();
            addNewRoomButton = new System.Windows.Forms.Button();
            dataGridViewRooms = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            flashMessagePaymentsLabel = new System.Windows.Forms.Label();
            exitBtn3 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            updateButton = new System.Windows.Forms.Button();
            dataGridViewPaidPayments = new System.Windows.Forms.DataGridView();
            toolTipForFleshMessage = new System.Windows.Forms.ToolTip(components);
            updateButton3 = new System.Windows.Forms.Button();
            tabControlRooms.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxOfRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaidPayments).BeginInit();
            SuspendLayout();
            // 
            // tabControlRooms
            // 
            tabControlRooms.Alignment = System.Windows.Forms.TabAlignment.Left;
            tabControlRooms.Controls.Add(tabPage1);
            tabControlRooms.Controls.Add(tabPage2);
            tabControlRooms.Controls.Add(tabPage3);
            tabControlRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlRooms.HotTrack = true;
            tabControlRooms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabControlRooms.ItemSize = new System.Drawing.Size(20, 70);
            tabControlRooms.Location = new System.Drawing.Point(0, 0);
            tabControlRooms.Multiline = true;
            tabControlRooms.Name = "tabControlRooms";
            tabControlRooms.Padding = new System.Drawing.Point(15, 3);
            tabControlRooms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tabControlRooms.SelectedIndex = 0;
            tabControlRooms.Size = new System.Drawing.Size(1941, 1055);
            tabControlRooms.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flashMessageLabel);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(exitBtn);
            tabPage1.Location = new System.Drawing.Point(74, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1863, 1047);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Студенти";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flashMessageLabel
            // 
            flashMessageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            flashMessageLabel.ForeColor = System.Drawing.Color.DarkGreen;
            flashMessageLabel.Location = new System.Drawing.Point(28, 19);
            flashMessageLabel.Name = "flashMessageLabel";
            flashMessageLabel.Size = new System.Drawing.Size(1771, 41);
            flashMessageLabel.TabIndex = 2;
            flashMessageLabel.Click += flashMessageLabel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(updateButton2);
            groupBox1.Controls.Add(addStudentButton);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new System.Drawing.Point(28, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1771, 896);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список студентів.";
            // 
            // updateButton2
            // 
            updateButton2.Location = new System.Drawing.Point(1212, 115);
            updateButton2.Name = "updateButton2";
            updateButton2.Size = new System.Drawing.Size(400, 46);
            updateButton2.TabIndex = 2;
            updateButton2.Text = "Оновитии";
            updateButton2.UseVisualStyleBackColor = true;
            updateButton2.Click += updateButton2_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new System.Drawing.Point(1212, 47);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new System.Drawing.Size(400, 46);
            addStudentButton.TabIndex = 1;
            addStudentButton.Text = "Додати студента";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(30, 47);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1152, 821);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exitBtn.ForeColor = System.Drawing.Color.Red;
            exitBtn.Location = new System.Drawing.Point(1572, 973);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new System.Drawing.Size(227, 46);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Закрити програму";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flashMessageLabelRooms);
            tabPage2.Controls.Add(exitBtn2);
            tabPage2.Controls.Add(groupBoxOfRooms);
            tabPage2.Location = new System.Drawing.Point(74, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1863, 1047);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Кімнати";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flashMessageLabelRooms
            // 
            flashMessageLabelRooms.ForeColor = System.Drawing.Color.Green;
            flashMessageLabelRooms.Location = new System.Drawing.Point(30, 19);
            flashMessageLabelRooms.Name = "flashMessageLabelRooms";
            flashMessageLabelRooms.Size = new System.Drawing.Size(1800, 45);
            flashMessageLabelRooms.TabIndex = 5;
            flashMessageLabelRooms.Click += flashMessageLabelRooms_Click;
            // 
            // exitBtn2
            // 
            exitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exitBtn2.ForeColor = System.Drawing.Color.Red;
            exitBtn2.Location = new System.Drawing.Point(1609, 980);
            exitBtn2.Name = "exitBtn2";
            exitBtn2.Size = new System.Drawing.Size(227, 46);
            exitBtn2.TabIndex = 4;
            exitBtn2.Text = "Закрити програму";
            exitBtn2.UseVisualStyleBackColor = true;
            exitBtn2.Click += exitBtn2_Click;
            // 
            // groupBoxOfRooms
            // 
            groupBoxOfRooms.Controls.Add(updateButton3);
            groupBoxOfRooms.Controls.Add(addNewRoomButton);
            groupBoxOfRooms.Controls.Add(dataGridViewRooms);
            groupBoxOfRooms.Location = new System.Drawing.Point(24, 55);
            groupBoxOfRooms.Name = "groupBoxOfRooms";
            groupBoxOfRooms.Size = new System.Drawing.Size(1812, 902);
            groupBoxOfRooms.TabIndex = 0;
            groupBoxOfRooms.TabStop = false;
            groupBoxOfRooms.Text = "Інформація кімнат гуртожитку";
            // 
            // addNewRoomButton
            // 
            addNewRoomButton.Location = new System.Drawing.Point(1591, 48);
            addNewRoomButton.Name = "addNewRoomButton";
            addNewRoomButton.Size = new System.Drawing.Size(196, 46);
            addNewRoomButton.TabIndex = 2;
            addNewRoomButton.Text = "Додати кімнату";
            addNewRoomButton.UseVisualStyleBackColor = true;
            addNewRoomButton.Click += addNewRoomButton_Click;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new System.Drawing.Point(19, 48);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 82;
            dataGridViewRooms.RowTemplate.Height = 41;
            dataGridViewRooms.Size = new System.Drawing.Size(1548, 822);
            dataGridViewRooms.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(flashMessagePaymentsLabel);
            tabPage3.Controls.Add(exitBtn3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new System.Drawing.Point(74, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(1863, 1047);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Помісячні Сплати";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // flashMessagePaymentsLabel
            // 
            flashMessagePaymentsLabel.ForeColor = System.Drawing.Color.Green;
            flashMessagePaymentsLabel.Location = new System.Drawing.Point(29, 20);
            flashMessagePaymentsLabel.Name = "flashMessagePaymentsLabel";
            flashMessagePaymentsLabel.Size = new System.Drawing.Size(1783, 42);
            flashMessagePaymentsLabel.TabIndex = 6;
            flashMessagePaymentsLabel.Click += flashMessagePaymentsLabel_Click;
            // 
            // exitBtn3
            // 
            exitBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exitBtn3.ForeColor = System.Drawing.Color.Red;
            exitBtn3.Location = new System.Drawing.Point(1585, 988);
            exitBtn3.Name = "exitBtn3";
            exitBtn3.Size = new System.Drawing.Size(227, 46);
            exitBtn3.TabIndex = 5;
            exitBtn3.Text = "Закрити програму";
            exitBtn3.UseVisualStyleBackColor = true;
            exitBtn3.Click += exitBtn3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(updateButton);
            groupBox2.Controls.Add(dataGridViewPaidPayments);
            groupBox2.Location = new System.Drawing.Point(20, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1792, 938);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Помісячні сплати за житло в гуртожитку";
            // 
            // updateButton
            // 
            updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            updateButton.Location = new System.Drawing.Point(1432, 49);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(278, 81);
            updateButton.TabIndex = 1;
            updateButton.Text = "Оновити";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridViewPaidPayments
            // 
            dataGridViewPaidPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaidPayments.Location = new System.Drawing.Point(23, 49);
            dataGridViewPaidPayments.Name = "dataGridViewPaidPayments";
            dataGridViewPaidPayments.ReadOnly = true;
            dataGridViewPaidPayments.RowHeadersWidth = 82;
            dataGridViewPaidPayments.RowTemplate.Height = 41;
            dataGridViewPaidPayments.Size = new System.Drawing.Size(1382, 868);
            dataGridViewPaidPayments.TabIndex = 0;
            // 
            // updateButton3
            // 
            updateButton3.Location = new System.Drawing.Point(1591, 112);
            updateButton3.Name = "updateButton3";
            updateButton3.Size = new System.Drawing.Size(196, 46);
            updateButton3.TabIndex = 3;
            updateButton3.Text = "Оновити";
            updateButton3.UseVisualStyleBackColor = true;
            updateButton3.Click += updateButton3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1941, 1055);
            ControlBox = false;
            Controls.Add(tabControlRooms);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            tabControlRooms.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBoxOfRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaidPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TabControl tabControlRooms;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox groupBoxOfRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button addNewRoomButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPaidPayments;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label flashMessageLabel;
        private System.Windows.Forms.ToolTip toolTipForFleshMessage;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button exitBtn2;
        private System.Windows.Forms.Button exitBtn3;
        private System.Windows.Forms.Label flashMessageLabelRooms;
        private System.Windows.Forms.Label flashMessagePaymentsLabel;
        private System.Windows.Forms.Button updateButton2;
        private System.Windows.Forms.Button updateButton3;
    }
}
