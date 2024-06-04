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
    public partial class AddRoomForm : Form
    {
        private NpgsqlConnection? connection;

        public AddRoomForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

            int capacityPlaces = int.Parse(textBoxPlaces.Text);
            string lavelComfort = textBoxLavelComfort.Text;
            int floorNumber = int.Parse(textBoxNumberFloor.Text);
            bool hasBalcony = checkBoxBalcony.Checked;
            bool hasFridge = checkBoxFridge.Checked;
            bool hasMicrowave = checkBoxMicrowawe.Checked;
            int numberOfRoom = int.Parse(textBoxNumberOfRoom.Text);
            float price = float.Parse(textBoxPrice.Text);

            command.Parameters.AddWithValue("@capacityPlaces", capacityPlaces);
            command.Parameters.AddWithValue("@lavelComfort", lavelComfort);
            command.Parameters.AddWithValue("@floorNumber", floorNumber);
            command.Parameters.AddWithValue("@hasBalcony", hasBalcony);
            command.Parameters.AddWithValue("@hasFridge", hasFridge);
            command.Parameters.AddWithValue("@hasMicrowave", hasMicrowave);
            command.Parameters.AddWithValue("@numberOfRoom", numberOfRoom);
            command.Parameters.AddWithValue("@price", price);

            command.CommandText = "INSERT INTO rooms(places, comfort, floor, has_balcony, has_fridge, has_microwave, number, price, available_places) " +
                                  "VALUES (@capacityPlaces, @lavelComfort, @floorNumber, @hasBalcony, @hasFridge, @hasMicrowave, @numberOfRoom, @price, @capacityPlaces)";

            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
            Main main = new Main("Ваша кімната успішно збережена");
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
