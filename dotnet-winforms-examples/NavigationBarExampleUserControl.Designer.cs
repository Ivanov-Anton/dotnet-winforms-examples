
namespace dotnet_winforms_examples
{
	partial class NavigationBarExampleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            view3Button = new System.Windows.Forms.Button();
            view2Button = new System.Windows.Forms.Button();
            view1Button = new System.Windows.Forms.Button();
            homeButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            splitContainer1.Panel1.Controls.Add(view3Button);
            splitContainer1.Panel1.Controls.Add(view2Button);
            splitContainer1.Panel1.Controls.Add(view1Button);
            splitContainer1.Panel1.Controls.Add(homeButton);
            splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            splitContainer1.Size = new System.Drawing.Size(1207, 905);
            splitContainer1.SplitterDistance = 313;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 0;
            // 
            // view3Button
            // 
            view3Button.BackColor = System.Drawing.SystemColors.ControlLight;
            view3Button.Dock = System.Windows.Forms.DockStyle.Top;
            view3Button.FlatAppearance.BorderSize = 0;
            view3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            view3Button.Location = new System.Drawing.Point(0, 447);
            view3Button.Margin = new System.Windows.Forms.Padding(0);
            view3Button.Name = "view3Button";
            view3Button.Size = new System.Drawing.Size(313, 149);
            view3Button.TabIndex = 3;
            view3Button.Text = "View 3";
            view3Button.UseVisualStyleBackColor = false;
            view3Button.Click += Button_Click;
            // 
            // view2Button
            // 
            view2Button.BackColor = System.Drawing.SystemColors.ControlLight;
            view2Button.Dock = System.Windows.Forms.DockStyle.Top;
            view2Button.FlatAppearance.BorderSize = 0;
            view2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            view2Button.Location = new System.Drawing.Point(0, 298);
            view2Button.Margin = new System.Windows.Forms.Padding(0);
            view2Button.Name = "view2Button";
            view2Button.Size = new System.Drawing.Size(313, 149);
            view2Button.TabIndex = 2;
            view2Button.Text = "View 2";
            view2Button.UseVisualStyleBackColor = false;
            view2Button.Click += Button_Click;
            // 
            // view1Button
            // 
            view1Button.BackColor = System.Drawing.SystemColors.ControlLight;
            view1Button.Dock = System.Windows.Forms.DockStyle.Top;
            view1Button.FlatAppearance.BorderSize = 0;
            view1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            view1Button.Location = new System.Drawing.Point(0, 149);
            view1Button.Margin = new System.Windows.Forms.Padding(0);
            view1Button.Name = "view1Button";
            view1Button.Size = new System.Drawing.Size(313, 149);
            view1Button.TabIndex = 1;
            view1Button.Text = "View 1";
            view1Button.UseVisualStyleBackColor = false;
            view1Button.Click += Button_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            homeButton.Location = new System.Drawing.Point(0, 0);
            homeButton.Margin = new System.Windows.Forms.Padding(0);
            homeButton.Name = "homeButton";
            homeButton.Size = new System.Drawing.Size(313, 149);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += Button_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(363, 448);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "Home Screen";
            label1.Click += label1_Click;
            // 
            // NavigationBarExampleUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            Name = "NavigationBarExampleUserControl";
            Size = new System.Drawing.Size(1207, 905);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button view3Button;
		private System.Windows.Forms.Button view2Button;
		private System.Windows.Forms.Button view1Button;
		private System.Windows.Forms.Button homeButton;
		private System.Windows.Forms.Label label1;
	}
}
