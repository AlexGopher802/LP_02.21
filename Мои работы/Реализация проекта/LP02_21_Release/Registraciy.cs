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
    public partial class Registraciy : Form
    {
        DataClass myClass = new DataClass();

        public Registraciy()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(!validForm()) { return; }
            try
            {
                myClass.executeQuery($"insert into LichnieDannie(Family, Imy, Otchestvo) values " +
                $"('{tbLastName.Text}', '{tbFirstName.Text}', '{tbPatronymic.Text}'); " +
                $"insert into Klient(Email, Password, Telefon, NomerCarti, IDLichnieDannie) values " +
                $"('{tbEmail.Text}', '{tbPassword.Text}', '{tbPhone.Text}', '{tbCardNumber.Text}', " +
                $"(select top (1) ID from LichnieDannie order by ID desc))");

                MessageBox.Show("Пользователь добавлен", "Успех");
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Error");
            }
        }

        bool validForm()
        {
            return true;
        }

        private void Registraciy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Main"].Show();
        }
    }
}
