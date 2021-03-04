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

        /// <summary>
        /// Метод регистрации нового клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                MessageBox.Show("Вы успешно зарегестрировались", "Успех");
                this.Close();
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Ошибка");
            }
        }

        /// <summary>
        /// Метод валидации формы (обязательные поля должны быть заполнены)
        /// </summary>
        /// <returns></returns>
        bool validForm()
        {
            if ((tbLastName.Text != "") && (tbFirstName.Text != "") && (tbEmail.Text != "") && (tbPassword.Text != "") && (tbPasswordConfirm.Text != ""))
            {
                if (tbPassword.Text == tbPasswordConfirm.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод", "Ошибка");
                return false;
            }
        }

        /// <summary>
        /// При закрытии окна - открывается предыдущее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registraciy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Main"].Show();
        }
    }
}
