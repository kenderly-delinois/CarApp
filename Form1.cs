using CarApp.Services;
using Microsoft.Identity.Client;
using CarApp.Models;
using CarApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
namespace CarApp
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargrid.DataSource = crud.GetAllCars();
            btnsubmit.Enabled = false;
            btnupdate.Enabled = false;
            foreach (var item in crud.GetAllCars())
            {
                combomake.Items.Add(item.CarMake);
            }

            foreach (var item in crud.GetAllCars())
            {
                combomodel.Items.Add(item.CarModel);
            }
        }

        private void btnaddcar_Click(object sender, EventArgs e)
        {
            txtid.Text = (crud.GetMaxCarId() + 1).ToString();
            txtid.ReadOnly = true; // Read only 
            txtyear.Clear(); // Clear prire after search 
            txtprice.Clear(); // Clear prire after search 
            btnsubmit.Enabled = true;
            //combomake.SelectedIndex = -1; // clear all the selected 
            //combomake.SelectedIndex = -1; // clear all the selected 
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtid.Text) && !String.IsNullOrEmpty(txtvin.Text) && !string.IsNullOrEmpty(txtprice.Text))
            {
                var newcar = new Car
                {
                    CarId = int.Parse(txtid.Text),
                    CarVin = txtvin.Text,
                    CarMake = combomake.SelectedItem.ToString(),
                    CarModel = combomodel.SelectedItem.ToString(),
                    CarYear = int.Parse(txtyear.Text),
                    CarPrice = int.Parse(txtprice.Text),
                };
                crud.AddCar(newcar);
                MessageBox.Show("Car added successfully!");

            }
            btnsubmit.Enabled = false; // disable the submit button
            cargrid.DataSource = crud.GetAllCars(); // refresh the employee grid
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var id = cargrid.CurrentRow.Cells[0].Value;
            crud.DeleteCar((int)id);
            MessageBox.Show("Car deleted successfully");
            cargrid.DataSource = crud.GetAllCars();
        }

        private void btnselecttoupdate_Click(object sender, EventArgs e)
        {
            var id = cargrid.CurrentRow.Cells[0].Value; // get the id of the selected car
            var c = crud.FindCar((int)id); // find the cr by id
            txtid.Text = c.CarId.ToString(); // set the id
            txtid.ReadOnly = true; // make the id read-only
            txtvin.Text = c.CarVin.ToString(); // set the Vin
            combomake.SelectedItem = c.CarMake.ToString(); // set the salary
            combomodel.SelectedItem = c.CarModel.ToString(); // 
            txtyear.Text = c.CarYear.ToString();
            txtprice.Text = c.CarPrice.ToString();
            btnupdate.Enabled = true; // enable the update button
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text); // get the id from the text box
            var cartoupdate = crud.FindCar(id); // find the car by id
            cartoupdate.CarVin = txtvin.Text; // update the name
            cartoupdate.CarMake = combomake.SelectedItem.ToString();
            cartoupdate.CarModel = combomodel.SelectedItem.ToString();
            cartoupdate.CarYear = int.Parse(txtyear.Text); // update the year
            cartoupdate.CarPrice = double.Parse(txtprice.Text);
            crud.UpdateCar(id, cartoupdate); // update the Car
            MessageBox.Show("Car updated successfully!"); // show success message
            btnupdate.Enabled = false; // disable the update button
            cargrid.DataSource = crud.GetAllCars(); // refresh the car grid
        }
    }
}
