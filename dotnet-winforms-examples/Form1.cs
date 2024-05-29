using System;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NavigationBarExampleButton_Click(object sender, EventArgs e)
        {
            Form form = new() { Width = Width, Height = Height };
            NavigationBarExampleUserControl navigationBarExampleUserControl = new();
            navigationBarExampleUserControl.Dock = DockStyle.Fill;
            form.Controls.Add(navigationBarExampleUserControl);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
