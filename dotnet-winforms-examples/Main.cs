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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace dotnet_winforms_examples
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT first_name, last_name, phone_number, contracts.contract_number, faculty FROM students " +
                                    "LEFT JOIN contracts ON contracts.student_id = students.id;";
            NpgsqlDataReader reader = command.ExecuteReader();

            listView1.View = View.Details;
            ColumnHeader columnHeaderFirstName = new ColumnHeader();
            columnHeaderFirstName.Text = "Імʼя";
            columnHeaderFirstName.Width = 160;

            listView1.Columns.Add(columnHeaderFirstName);
            ColumnHeader columnHeaderLastName = new ColumnHeader();
            columnHeaderLastName.Text = "Прізвище";
            columnHeaderLastName.Width = 200;
            listView1.Columns.Add(columnHeaderLastName);


            ColumnHeader columnHeaderPhoneNumber = new ColumnHeader();
            columnHeaderPhoneNumber.Text = "Номер телефона";
            columnHeaderPhoneNumber.Width = 230;
            listView1.Columns.Add(columnHeaderPhoneNumber);

            ColumnHeader columnHeaderContractNumber = new ColumnHeader();
            columnHeaderContractNumber.Text = "Номер договора";
            columnHeaderContractNumber.Width = 230;
            listView1.Columns.Add(columnHeaderContractNumber);

            ColumnHeader columnHeaderFaculty = new ColumnHeader();
            columnHeaderFaculty.Text = "Факультет";
            columnHeaderFaculty.Width = 250;
            listView1.Columns.Add(columnHeaderFaculty);



            while (reader.Read())
            {
                listView1.Items.Add(new ListViewItem(new[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) }));
            }

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                //dataGridView1.DataSource = dt;
            }
            command.Dispose();
            connection.Close();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
            this.Hide();
        }
    }
}
