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
    public partial class AddEmployee : Form
    {
        DataClass myClass = new DataClass();

        public AddEmployee()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Метод валидации формы (обязательные поля должны быть заполнены)
        /// </summary>
        /// <returns></returns>
        bool validForm()
        {
            if((tbLastName.Text != "") && (tbFirstName.Text != "") && (tbEmail.Text != "") && (tbPassword.Text != "") && (cbPost.SelectedItem != null))
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
        /// Подтверждение добавления сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!validForm()) { return; }

            try
            {
                myClass.executeQuery($"insert into LichnieDannie(Family, Imy, Otchestvo) values " +
                    $"('{tbLastName.Text}', '{tbFirstName.Text}', '{tbPatronymic.Text}'); " +
                    $"insert into Sotrudnik(Email, Password, IDLichnieDannie, IDDoljnost) values " +
                    $"('{tbEmail.Text}', '{tbPassword.Text}', " +
                    $"(select top (1) ID from LichnieDannie order by ID desc), " +
                    $"(select ID from Doljnost where Naimenovanie='{cbPost.SelectedItem.ToString()}'))");

                MessageBox.Show("Сотрудник успешно добавлен", "Успех");
                this.Close();
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Ошибка");
            }
        }

        /// <summary>
        /// При закрытии окна - открывается предыдущее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Employee form = (Employee)Application.OpenForms["Employee"];
            form.showDataEmployee();
            form.Show();
        }

        /// <summary>
        /// При загрузке формы - заполняется комбо-бокс с должностями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cbPost.DataSource = myClass.GetListItems("select Naimenovanie from Doljnost");
        }
    }
}
