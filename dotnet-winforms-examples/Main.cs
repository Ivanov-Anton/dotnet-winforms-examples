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
using System.Threading;

namespace dotnet_winforms_examples
{
    public partial class Main : Form
    {
        private NpgsqlConnection? connection;

        public Main(string flashMessage = "")
        {
            InitializeComponent();
            if (flashMessage.Length > 0)
            {
                flashMessageLabel.Text = flashMessage;
                flashMessageLabelRooms.Text = flashMessage;
                flashMessagePaymentsLabel.Text = flashMessage;
                // Set up the delays for the ToolTip.
                toolTipForFleshMessage.AutoPopDelay = 0;
                toolTipForFleshMessage.InitialDelay = 1000;
                toolTipForFleshMessage.ReshowDelay = 500;
                flashMessageLabel.MouseEnter += flashMessagelabelMouseEnterEvent;
                flashMessageLabel.MouseLeave += flashMessagelabelMouseLeaveEvent;
                string tollTipMessage = "Клацніть для того щоб приховати ваше повідомлення";
                toolTipForFleshMessage.SetToolTip(flashMessageLabel, tollTipMessage);
                toolTipForFleshMessage.SetToolTip(flashMessageLabelRooms, tollTipMessage);
                toolTipForFleshMessage.SetToolTip(flashMessagePaymentsLabel, tollTipMessage);
            }
        }

        private void flashMessagelabelMouseEnterEvent(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.DarkGreen;
            ((Label)sender).Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        private void flashMessagelabelMouseLeaveEvent(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.Green;
            ((Label)sender).Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadStudents();

            // rooms

            LoadRoomsData();

            // Add columns
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "id", DataPropertyName = "id", Width = 70 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Номер етажа", DataPropertyName = "floor", Width = 100 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Номер кімнати", DataPropertyName = "number", Width = 100 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Доступно місць", DataPropertyName = "available_places", Width = 110 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Всього місць", DataPropertyName = "places", Width = 100 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Комфорт", DataPropertyName = "comfort", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Балкон", DataPropertyName = "has_balcony", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Холодильник", DataPropertyName = "has_fridge", Width = 120 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Мікрохвилоьва пічь", DataPropertyName = "has_microwave", Width = 150 });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ціна", DataPropertyName = "price", Width = 120 });
            // Add action delete button column
            var actionRemoveButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Управління",
                Text = "Видалити",
                UseColumnTextForButtonValue = true
            };
            dataGridViewRooms.Columns.Add(actionRemoveButtonColumn);
            dataGridViewRooms.CellClick += dataGridViewRooms_RemoveCellClick;

            var addStudentColumnAction = new DataGridViewButtonColumn
            {
                HeaderText = "Управління",
                Text = "Додати студента",
                UseColumnTextForButtonValue = true
            };
            dataGridViewRooms.Columns.Add(addStudentColumnAction);
            dataGridViewRooms.CellClick += dataGridViewRooms_CellClickToAddStudent;


            // payments

            LoadPaidPaymentsData();
            dataGridViewPaidPayments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "id", DataPropertyName = "id", Width = 40 });
            dataGridViewPaidPayments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "За який місяц платіж", DataPropertyName = "month", Width = 200 });
            dataGridViewPaidPayments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Статус", DataPropertyName = "status", Width = 150 });
            dataGridViewPaidPayments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Студент", DataPropertyName = "student_full_name", Width = 320 });
            dataGridViewPaidPayments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Сума", DataPropertyName = "monthly_amount", Width = 100 });
            dataGridViewPaidPayments.CellFormatting += dataGridViewPaidPayments_CellFormatting;
            // Add action button column
            var actionMarkAsPaidButton = new DataGridViewButtonColumn
            {
                HeaderText = "Управління",
                Text = "Помітити як сплачений",
                UseColumnTextForButtonValue = true,
                Width = 300
            };
            dataGridViewPaidPayments.Columns.Add(actionMarkAsPaidButton);
            dataGridViewPaidPayments.CellClick += dataGridViewPaidPayments_CellClick;

            //command.Dispose();
            connection.Close();
        }

        private void LoadStudents() 
        {
            connection = DatabaseManager.Instance.GetConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT first_name, last_name, phone_number, COALESCE(contracts.contract_number, 'без договору'), COALESCE(faculty, '') FROM students " +
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
        }

        private void dataGridViewRooms_RemoveCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                var id = dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                DeleteRowFromDatabase(id);
                flashMessageLabel.Text = "Кімната успішно видалена";
            }

        }

        private void dataGridViewRooms_CellClickToAddStudent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 11)
            {
                string id = dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                string price = dataGridViewRooms.Rows[e.RowIndex].Cells[9].Value.ToString();
                AddStudentToRoomPopUp form = new AddStudentToRoomPopUp(int.Parse(id), price);
                this.Hide();
                form.Show();
            }

        }

        private void DeleteRowFromDatabase(string id)
        {
            string query = "DELETE FROM rooms WHERE id = @Id"; // Adjust the table name and column name accordingly
            NpgsqlConnection connToDelete = DatabaseManager.Instance.GetConnection();

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
            LoadRoomsData();
        }

        private void LoadRoomsData()
        {
            NpgsqlConnection connectionRoom = DatabaseManager.Instance.GetConnection();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT id, floor, number, available_places, places, comfort, has_balcony, has_fridge, has_microwave, price FROM rooms;", connectionRoom);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridViewRooms.AutoGenerateColumns = false;
            dataGridViewRooms.DataSource = dataTable;
            dataGridViewRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewPaidPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var id = dataGridViewPaidPayments.Rows[e.RowIndex].Cells[0].Value.ToString();
                string query = "UPDATE payments SET status = 'Paid' WHERE id = @Id";
                NpgsqlConnection connToUpdatePayment = DatabaseManager.Instance.GetConnection();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connToUpdatePayment))
                {
                    command.Parameters.AddWithValue("@Id", int.Parse(id));
                    connToUpdatePayment.Open();
                    command.ExecuteNonQuery();
                    connToUpdatePayment.Close();
                }

                flashMessageLabel.Text = "Статус успішно змінено";
                // Refresh the DataGridView to reflect the changes
                dataGridViewPaidPayments.DataSource = null;
                LoadPaidPaymentsData();


            }
        }

        private void LoadPaidPaymentsData()
        {
            NpgsqlConnection connectionPaidPayments = DatabaseManager.Instance.GetConnection();
            string sql = "SELECT payments.id, " +
                         "TO_CHAR(month, 'mm-yyyy') AS month, " +
                         "status, " +
                         "CONCAT(students.last_name, ' ', students.first_name) AS student_full_name, " +
                         "payments.monthly_amount AS monthly_amount " +
                         "FROM payments " +
                         "INNER JOIN contracts ON contracts.id = payments.contract_id " +
                         "INNER JOIN students ON students.id = contracts.student_id";

            NpgsqlDataAdapter dataAdapterPayments = new NpgsqlDataAdapter(sql,
                                                                          connectionPaidPayments
                                                                         );
            DataTable dataTablePayments = new DataTable();
            dataAdapterPayments.Fill(dataTablePayments);
            dataGridViewPaidPayments.AutoGenerateColumns = false;
            dataGridViewPaidPayments.DataSource = dataTablePayments;
            dataGridViewPaidPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewPaidPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPaidPayments.Columns[e.ColumnIndex].DataPropertyName == "status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Pending")
                {
                    e.Value = "Очікується";
                    e.FormattingApplied = true;
                }

                if (status == "Paid")
                {
                    e.Value = "Cплачено";
                    e.FormattingApplied = true;
                }
            }
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadPaidPaymentsData();
        }

        private void flashMessageLabel_Click(object sender, EventArgs e)
        {
            flashMessageLabelRooms.Text = "";
            flashMessagePaymentsLabel.Text = "";
            flashMessageLabel.Text = "";
        }

        private void closeAllForms()
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            closeAllForms();
        }

        private void exitBtn2_Click(object sender, EventArgs e)
        {
            closeAllForms();
        }

        private void exitBtn3_Click(object sender, EventArgs e)
        {
            closeAllForms();
        }

        private void flashMessageLabelRooms_Click(object sender, EventArgs e)
        {
            flashMessageLabelRooms.Text = "";
            flashMessagePaymentsLabel.Text = "";
            flashMessageLabel.Text = "";
        }

        private void flashMessagePaymentsLabel_Click(object sender, EventArgs e)
        {
            flashMessagePaymentsLabel.Text = "";
            flashMessageLabel.Text = "";
            flashMessageLabelRooms.Text = "";
        }

        // update from Students page
        private void updateButton2_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

    
        // update from Rooms page
        private void updateButton3_Click(object sender, EventArgs e)
        {
            LoadRoomsData();
        }
    }
}
