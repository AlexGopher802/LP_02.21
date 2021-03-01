using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP02_21_Release
{
    public partial class AddFlight : Form
    {
        DataClass myClass = new DataClass();

        public AddFlight()
        {
            InitializeComponent();
        }

        private void AddFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flights form = (Flights)Application.OpenForms["Flights"];
            form.showDataFlights();
            form.Show();
        }

        bool validForm()
        {
            return true;
        }

        void clearForm()
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!validForm()) { return; }

            try
            {
                myClass.executeQuery($"insert into Reis(MestoVilita, MestoPribitya, DateVileta, Czena, IDSamolet) values " +
                    $"('{tbFrom.Text}', '{tbTo.Text}', '{dateTimePicker.Value}', {tbCost.Text}, " +
                    $"(select ID from Samolet where Naimenovanie='{cbAircrafts.SelectedItem}'))");

                clearForm();
                MessageBox.Show("Рейс успешно добавлен", "Успех");
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Ошибка");
            }
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {
            cbAircrafts.DataSource = myClass.GetListItems("select Naimenovanie from Samolet");
        }
    }
}
