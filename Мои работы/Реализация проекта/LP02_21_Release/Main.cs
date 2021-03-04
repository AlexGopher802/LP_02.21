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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызов формы авторизации для клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Enter().Show();
        }

        /// <summary>
        /// Вызов формы регистрации для клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registraciy().Show();
        }

        /// <summary>
        /// Вызов формы авторизации для сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntryEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EnterForSotrudnik().Show();
        }
    }
}
