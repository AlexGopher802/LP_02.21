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
    public partial class Flights : Form
    {
        DataClass myClass = new DataClass();
        string where = "";

        public Flights()
        {
            InitializeComponent();
        }

        public void showDataFlights()
        {
            dataGridFlights.DataSource = myClass.getData($"select " +
                $"Reis.MestoVilita as [Откуда], " +
                $"Reis.MestoPribitya as [Куда], " +
                $"Reis.DateVileta as [Когда], " +
                $"Reis.Czena as [Стоимость], " +
                $"Samolet.Naimenovanie as [Самолёт], " +
                $"Reis.ID " +
                $"from Reis " +
                $"left join Samolet on Reis.IDSamolet = Samolet.ID " +
                $"where 666=666 {where}").Tables[0];
            dataGridFlights.Columns[5].Visible = false;
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            showDataFlights();
        }

        private void Flights_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Sotrudnik"].Show();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddFlight().Show();
        }

        void filtredData()
        {
            if (tbFrom.Text != "")
            {
                where += $"and MestoVilita='{tbFrom.Text} '";
            }

            if (tbTo.Text != "")
            {
                where += $"and MestoPribitya='{tbTo.Text} '";
            }

            showDataFlights();
            where = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            filtredData();
        }
    }
}
