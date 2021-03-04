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

        /// <summary>
        /// При закрытии окна - открывается предыдущее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sotrudnik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["EnterForSotrudnik"].Show();
        }

        /// <summary>
        /// Вызов формы просмотра списка рейсов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Flights().Show();
        }

        /// <summary>
        /// Вызов формы просмотра списка сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employee().Show();
        }

        /// <summary>
        /// Вызов формы просмотра списка билетов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTikets_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tikets().Show();
        }
    }
}
