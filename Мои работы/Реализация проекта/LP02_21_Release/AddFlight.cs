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

        /// <summary>
        /// При закрытии окна - открывается предыдущее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flights form = (Flights)Application.OpenForms["Flights"];
            form.showDataFlights();
            form.Show();
        }

        /// <summary>
        /// Метод валидации формы (обязательные поля должны быть заполнены)
        /// </summary>
        /// <returns></returns>
        bool validForm()
        {
            if((tbFrom.Text != "") && (tbTo.Text != "") && (tbCost.Text != "") && (cbAircrafts.SelectedItem != null))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Некорректный ввод", "Ошибка");
                return false;
            }
        }

        /// <summary>
        /// Подтверждение добавления нового рейса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!validForm()) { return; }

            try
            {
                myClass.executeQuery($"insert into Reis(MestoVilita, MestoPribitya, DateVileta, Czena, IDSamolet) values " +
                    $"('{tbFrom.Text}', '{tbTo.Text}', '{dateTimePicker.Value}', {tbCost.Text}, " +
                    $"(select ID from Samolet where Naimenovanie='{cbAircrafts.SelectedItem}'))");

                MessageBox.Show("Рейс успешно добавлен", "Успех");
                this.Close();
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Ошибка");
            }
        }

        /// <summary>
        /// При открытии формы - загружается список самолётов в комбо-бокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFlight_Load(object sender, EventArgs e)
        {
            cbAircrafts.DataSource = myClass.GetListItems("select Naimenovanie from Samolet");
        }
    }
}
