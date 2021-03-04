using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LP02_21_Release
{
    public partial class Enter : Form
    {
        DataClass myClass = new DataClass();

        public Enter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntry_Click(object sender, EventArgs e)
        {
            DataSet ds = myClass.getData($"select * from Klient where Email='{tbEmail.Text}' and Password='{tbPassword.Text}'");
            if(ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Неправильный логин и/или пароль", "Error");
            }
            else
            {
                this.Hide();
                BuyTiket form = new BuyTiket();
                form.klientID = (int)ds.Tables[0].Rows[0].ItemArray[0];
                form.Show();
            }
        }

        /// <summary>
        /// При закрытии окна - открывается предыдущее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Main"].Show();
        }
    }
}
