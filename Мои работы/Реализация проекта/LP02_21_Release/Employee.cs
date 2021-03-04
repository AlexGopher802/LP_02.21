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
    public partial class Employee : Form
    {
        DataClass myClass = new DataClass();

        public Employee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При закрытии формы - открывается предыдущая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Sotrudnik"].Show();
        }

        /// <summary>
        /// Вызов формы добавления нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddEmployee().Show();
        }

        /// <summary>
        /// Метод отображения информации о сотрудниках в таблицу
        /// </summary>
        public void showDataEmployee()
        {
            dataGridEmployees.DataSource = myClass.getData($"select " +
                $"LichnieDannie.Family as [Фамилия], " +
                $"LichnieDannie.Imy as [Имя], " +
                $"LichnieDannie.Otchestvo as [Отчество], " +
                $"Sotrudnik.Email as [Почта], " +
                $"Sotrudnik.Password as [Пароль], " +
                $"Doljnost.Naimenovanie as [Должность], " +
                $"Sotrudnik.ID as [id] " +
                $"from Sotrudnik " +
                $"left join LichnieDannie on Sotrudnik.IDLichnieDannie = LichnieDannie.ID " +
                $"left join Doljnost on Sotrudnik.IDDoljnost = Doljnost.ID ").Tables[0];
            dataGridEmployees.Columns[6].Visible = false;
        }

        /// <summary>
        /// При открытии окна - загружается таблица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Employee_Load(object sender, EventArgs e)
        {
            showDataEmployee();
        }

        /// <summary>
        /// Метод удаления выбранного сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if(dataGridEmployees.SelectedRows.Count == 0) { MessageBox.Show("Ничего не выбрано", "Ошибка"); return; }

            myClass.executeQuery($"delete from Sotrudnik where ID={dataGridEmployees.SelectedRows[0].Cells["ID"].Value} ");
            showDataEmployee();
            MessageBox.Show("Сотрудник успешно удалён", "Успех");
        }
    }
}
