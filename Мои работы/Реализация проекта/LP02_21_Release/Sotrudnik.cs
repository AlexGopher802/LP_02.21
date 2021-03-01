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
    public partial class Sotrudnik : Form
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        private void Sotrudnik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["EnterForSotrudnik"].Show();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Flights().Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employee().Show();
        }

        private void btnTikets_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tikets().Show();
        }
    }
}
