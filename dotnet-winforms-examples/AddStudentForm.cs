using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
    public partial class AddStudentForm : Form
    {
        private NpgsqlConnection connection;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            connection = DatabaseManager.Instance.GetConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            string? firstName = textBoxName.Text;
            string? lastName = textBoxLastName.Text;
            string? phoneNumber = textBoxPhoneNumber.Text;

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.CommandText = "INSERT INTO students(first_name, last_name, phone_number) " +
                                  "VALUES (@firstName, @lastName, @phoneNumber)";

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine("Rows affected: " + rowsAffected);
            connection.Close();
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
