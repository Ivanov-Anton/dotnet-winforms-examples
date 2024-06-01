
namespace dotnet_winforms_examples
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
            label1 = new System.Windows.Forms.Label();
            navigationBarExampleButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(385, 410);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(250, 32);
            label1.TabIndex = 1;
            label1.Text = "Ласкаво просимо до ";
            label1.Click += label1_Click;
            // 
            // navigationBarExampleButton
            // 
            navigationBarExampleButton.Location = new System.Drawing.Point(291, 588);
            navigationBarExampleButton.Margin = new System.Windows.Forms.Padding(6);
            navigationBarExampleButton.Name = "navigationBarExampleButton";
            navigationBarExampleButton.Size = new System.Drawing.Size(435, 84);
            navigationBarExampleButton.TabIndex = 6;
            navigationBarExampleButton.Text = "Завантажити застосунок";
            navigationBarExampleButton.UseVisualStyleBackColor = true;
            navigationBarExampleButton.Click += NavigationBarExampleButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(206, 471);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(659, 32);
            label2.TabIndex = 7;
            label2.Text = "Інформаційної системи поселення студентів у гуртожиток";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1025, 960);
            Controls.Add(label2);
            Controls.Add(navigationBarExampleButton);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Form1";
            Text = "Welcome form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button navigationBarExampleButton;
        private System.Windows.Forms.Label label2;
    }
}

