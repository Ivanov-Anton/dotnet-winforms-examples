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
        private NpgsqlConnection? connection;

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            connection = DatabaseManager.Instance.GetConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT first_name, last_name, phone_number, COALESCE(contracts.contract_number, 'без контракту'), COALESCE(faculty, '') FROM students " +
                                  "LEFT JOIN contracts ON contracts.student_id = students.id;";
            NpgsqlDataReader reader = command.ExecuteReader();

            listView1.View = View.Details;
            listView1.MultiSelect = true;
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

            // rooms

            LoadData();

            // Add columns
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "id", DataPropertyName = "id", Width = 40 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Номер етажа", DataPropertyName = "floor", Width = 100 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Номер кімнати", DataPropertyName = "number", Width = 100 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Доступно місць", DataPropertyName = "available_places", Width = 100 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Всього місць", DataPropertyName = "places" });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Комфорт", DataPropertyName = "comfort", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Балкон", DataPropertyName = "has_balcony", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Холодильник", DataPropertyName = "has_fridge", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Мікрохвилоьва пічь", DataPropertyName = "has_microwave", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ціна", DataPropertyName = "price", Width = 120 });
            // Add action button column
            var actionButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Управління",
                Text = "Видалити",
                UseColumnTextForButtonValue = true
            };
            dataGridViewRooms.Columns.Add(actionButtonColumn);
           
            dataGridViewRooms.CellClick += dataGridViewRooms_CellClick;


            command.Dispose();
            connection.Close();
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                var id = dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString();

                DeleteRowFromDatabase(id);
            }
            
        }

        private void DeleteRowFromDatabase(string id)
        {
            string query = "DELETE FROM rooms WHERE id = @Id"; // Adjust the table name and column name accordingly
            NpgsqlConnection connToDelete = DatabaseManager.Instance.GetUniiqueConnection();

            using (NpgsqlCommand command = new NpgsqlCommand(query, connToDelete))
            {
                command.Parameters.AddWithValue("@Id", int.Parse(id));
                connToDelete.Open();
                command.ExecuteNonQuery();
                connToDelete.Close();
            }

            // Refresh the DataGridView to reflect the changes
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Clear and reload the DataGridView data
            dataGridViewRooms.DataSource = null;
            LoadData();
        }

        private void LoadData()
        {
            NpgsqlConnection connectionRoom = DatabaseManager.Instance.GetUniiqueConnection();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT id, floor, number, available_places, places, comfort, has_balcony, has_fridge, has_microwave, price FROM rooms;", connectionRoom);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridViewRooms.AutoGenerateColumns = false;
            dataGridViewRooms.DataSource = dataTable;
            dataGridViewRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
            this.Hide();
        }

        private void addNewRoomButton_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            form.Show();
            this.Hide();
        }
    }
}
