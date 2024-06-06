using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
    public partial class AddStudentForm : Form
    {
        private NpgsqlConnection? connection;

        public AddStudentForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_NOCLOSE;
                return createParams;
            }
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
            Main main = new Main("Новий студент гуртожитку успішно стровено");
            main.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
