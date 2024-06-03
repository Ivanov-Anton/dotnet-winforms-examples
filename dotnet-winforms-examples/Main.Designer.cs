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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            addStudentButton = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBoxOfRooms = new System.Windows.Forms.GroupBox();
            dataGridViewRooms = new System.Windows.Forms.DataGridView();
            addNewRoomButton = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxOfRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.HotTrack = true;
            tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabControl1.ItemSize = new System.Drawing.Size(20, 70);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new System.Drawing.Point(15, 3);
            tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1922, 1101);
            tabControl1.TabIndex = 0;
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
            groupBoxOfRooms.Size = new System.Drawing.Size(1750, 1026);
            groupBoxOfRooms.TabIndex = 0;
            groupBoxOfRooms.TabStop = false;
            groupBoxOfRooms.Text = "Інформація кімнат гуртожитку";
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new System.Drawing.Point(19, 48);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 82;
            dataGridViewRooms.RowTemplate.Height = 41;
            dataGridViewRooms.Size = new System.Drawing.Size(1346, 895);
            dataGridViewRooms.TabIndex = 1;
            // 
            // addNewRoomButton
            // 
            addNewRoomButton.Location = new System.Drawing.Point(1403, 48);
            addNewRoomButton.Name = "addNewRoomButton";
            addNewRoomButton.Size = new System.Drawing.Size(242, 46);
            addNewRoomButton.TabIndex = 2;
            addNewRoomButton.Text = "Додати кімнату";
            addNewRoomButton.UseVisualStyleBackColor = true;
            addNewRoomButton.Click += addNewRoomButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1922, 1101);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBoxOfRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox groupBoxOfRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button addNewRoomButton;
    }
}