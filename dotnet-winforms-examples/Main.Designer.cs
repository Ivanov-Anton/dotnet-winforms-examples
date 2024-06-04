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
            tabControlRooms = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            addStudentButton = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBoxOfRooms = new System.Windows.Forms.GroupBox();
            addNewRoomButton = new System.Windows.Forms.Button();
            dataGridViewRooms = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            updateButton = new System.Windows.Forms.Button();
            dataGridViewPaidPayments = new System.Windows.Forms.DataGridView();
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
            tabControlRooms.Size = new System.Drawing.Size(1922, 1101);
            tabControlRooms.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(74, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1844, 1093);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Студенти";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addStudentButton);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new System.Drawing.Point(28, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1771, 1021);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список студентів";
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new System.Drawing.Point(1212, 47);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new System.Drawing.Size(293, 46);
            addStudentButton.TabIndex = 1;
            addStudentButton.Text = "Додати студента";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(30, 47);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1152, 940);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBoxOfRooms);
            tabPage2.Location = new System.Drawing.Point(74, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1844, 1093);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Кімнати";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxOfRooms
            // 
            groupBoxOfRooms.Controls.Add(addNewRoomButton);
            groupBoxOfRooms.Controls.Add(dataGridViewRooms);
            groupBoxOfRooms.Location = new System.Drawing.Point(24, 22);
            groupBoxOfRooms.Name = "groupBoxOfRooms";
            groupBoxOfRooms.Size = new System.Drawing.Size(1812, 1026);
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
            dataGridViewRooms.Size = new System.Drawing.Size(1548, 895);
            dataGridViewRooms.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new System.Drawing.Point(74, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(1844, 1093);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Помісячні Сплати";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(updateButton);
            groupBox2.Controls.Add(dataGridViewPaidPayments);
            groupBox2.Location = new System.Drawing.Point(20, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1792, 1035);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Помісячні сплати за житло в гуртожитку";
            // 
            // updateButton
            // 
            updateButton.BackgroundImage = Properties.Resources.refresh_icon1;
            updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            updateButton.Location = new System.Drawing.Point(1432, 49);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(278, 81);
            updateButton.TabIndex = 1;
            updateButton.Text = "     Оновити";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridViewPaidPayments
            // 
            dataGridViewPaidPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaidPayments.Location = new System.Drawing.Point(23, 49);
            dataGridViewPaidPayments.Name = "dataGridViewPaidPayments";
            dataGridViewPaidPayments.RowHeadersWidth = 82;
            dataGridViewPaidPayments.RowTemplate.Height = 41;
            dataGridViewPaidPayments.Size = new System.Drawing.Size(1382, 956);
            dataGridViewPaidPayments.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1922, 1101);
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
    }
}