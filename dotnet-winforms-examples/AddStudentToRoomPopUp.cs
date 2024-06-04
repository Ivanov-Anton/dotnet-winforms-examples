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
    public partial class AddStudentToRoomPopUp : Form
    {
        private int idOfRoom;
        private int selectedStudentId;
        public AddStudentToRoomPopUp(int idOfRoom)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.idOfRoom = idOfRoom;
            LoadStudents();
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

        private string GenerateContractNumber()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letters = new string(Enumerable.Repeat(chars, 3)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            string numbers = random.Next(100, 1000).ToString();
            return $"{letters}-{numbers}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void LoadStudents()
        {
            try
            {
                using (NpgsqlConnection addStudentconnection = DatabaseManager.Instance.GetConnection())
                {
                    addStudentconnection.Open();
                    string query = "SELECT id, CONCAT(first_name, ' ', last_name) AS full_name FROM students";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, addStudentconnection))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            comboBoxStudents.Items.Add(new ComboboxItem { Text = fullName, Value = id });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem is ComboboxItem selectedItem)
            {
                selectedStudentId = (int)selectedItem.Value;
            }
        }

        private void addStudentToRoomButton_Click(object sender, EventArgs e)
        {
            string contractNumber = GenerateContractNumber();
            using (NpgsqlConnection connection = DatabaseManager.Instance.GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    command.CommandText = "INSERT INTO contracts(contract_number, date_of_entry, created_at, updated_at, room_id, student_id) " +
                                          "VALUES(@contract_number, NOW(), NOW(), NOW(), @room_id, @student_id)";

                    command.Parameters.AddWithValue("@contract_number", contractNumber);
                    command.Parameters.AddWithValue("@room_id", idOfRoom);
                    command.Parameters.AddWithValue("@student_id", selectedStudentId);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE rooms SET available_places = available_places - 1 WHERE id = @id";
                    command.Parameters.AddWithValue("@id", idOfRoom);
                }
            }

            this.Close();
            Main main = new Main("Студент успішно заерестрований в гуртожитку, номер контракту: " + contractNumber);
            main.Show();
        }
    }
}
