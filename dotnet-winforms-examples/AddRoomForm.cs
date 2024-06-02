﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace dotnet_winforms_examples
{
    public partial class AddRoomForm : Form
    {
        NpgsqlConnection connection;

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // todo to remove
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            connection = DatabaseManager.Instance.GetConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            string capycityPlaces = textBoxPlaces.Text;
            string lavelComfort = textBoxLavelComfort.Text;
            string floorNumber = textBoxNumberFloor.Text;
            string hasBalcony = textBoxBalcony.Text;
            string hasFridge = textBoxFridge.Text;
            string hasMicrowave = textBoxMicrowawe.Text;
            string numberOfRoom = textBoxNumberOfRoom.Text;
            string price = textBoxPrice.Text;

            command.Parameters.AddWithValue("@capycityPlaces", capycityPlaces);
            command.Parameters.AddWithValue("@lavelComfort", lavelComfort);
            command.Parameters.AddWithValue("@floorNumber", floorNumber);
            command.Parameters.AddWithValue("@hasBalcony", hasBalcony);
            command.Parameters.AddWithValue("@hasFridge", hasFridge);
            command.Parameters.AddWithValue("@hasMicrowave", hasMicrowave);
            command.Parameters.AddWithValue("@numberOfRoom", numberOfRoom);
            command.Parameters.AddWithValue("@price", price);

            command.CommandText = "INSERT INTO rooms(places, comfort, floor, has_balcony, has_fridge, has_microwave, number, price) " +
                                  "VALUES (@capycityPlaces, @lavelComfort, @floorNumber, @hasBalcony, @hasFridge, @hasMicrowave, @numberOfRoom, @price)";

            int rowsAffected = command.ExecuteNonQuery();
            MessageBox.Show(rowsAffected.ToString());
            connection.Close();
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}