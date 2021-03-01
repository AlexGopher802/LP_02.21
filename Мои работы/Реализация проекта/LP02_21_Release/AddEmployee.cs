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

        bool validForm()
        {
            return true;
        }

        void clearForm()
        {

        }

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

                clearForm();
                MessageBox.Show("Сотрудник успешно добавлен", "Успех");
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Ошибка");
            }
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Employee form = (Employee)Application.OpenForms["Employee"];
            form.showDataEmployee();
            form.Show();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cbPost.DataSource = myClass.GetListItems("select Naimenovanie from Doljnost");
        }
    }
}
