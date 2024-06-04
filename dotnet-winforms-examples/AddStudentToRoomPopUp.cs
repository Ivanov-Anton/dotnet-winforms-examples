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
                MessageBox.Show("save");
            }
        }
    }
}
