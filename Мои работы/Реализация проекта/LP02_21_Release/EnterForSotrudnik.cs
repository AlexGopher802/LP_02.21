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
    public partial class EnterForSotrudnik : Form
    {
        DataClass myClass = new DataClass();

        public EnterForSotrudnik()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            DataSet ds = myClass.getData($"select * from Sotrudnik where Email='{tbEmail.Text}' and Password='{tbPassword.Text}'");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Неправильный логин и/или пароль", "Error");
            }
            else
            {
                this.Hide();
                new Sotrudnik().Show();
            }
        }

        private void EnterForSotrudnik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Main"].Show();
        }

        private void btnEntry_Click_1(object sender, EventArgs e)
        {
            DataSet ds = myClass.getData($"select * from Sotrudnik where Email='{tbEmail.Text}' and Password='{tbPassword.Text}'");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Неправильный логин и/или пароль", "Error");
            }
            else
            {
                this.Hide();
                Sotrudnik form = new Sotrudnik();
                form.Show();
            }
        }


    }
}
