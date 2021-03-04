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
    public partial class TiketConfirm : Form
    {
        public int reisID = 0;
        public int klientID = 0;
        DataClass myClass = new DataClass();

        public TiketConfirm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При загрузке окна - заполняем форму информацией о клиенте и рейсе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TiketConfirm_Load(object sender, EventArgs e)
        {
            tbLastName.Text = dataGridFIO.Rows[0].Cells["Family"].Value.ToString();
            tbFirstName.Text = dataGridFIO.Rows[0].Cells["Imy"].Value.ToString();
            tbPatronymic.Text = dataGridFIO.Rows[0].Cells["Otchestvo"].Value.ToString();
            tbFrom.Text = dataGridReis.Rows[0].Cells["MestoVilita"].Value.ToString();
            tbTo.Text = dataGridReis.Rows[0].Cells["MestoPribitya"].Value.ToString();
            tbDate.Text = dataGridReis.Rows[0].Cells["DateVileta"].Value.ToString();
            tbSumma.Text = dataGridReis.Rows[0].Cells["Czena"].Value.ToString();

            int quantityPlace = (int)myClass.getData($"select KolVoMest from Samolet where ID=(select IDSamolet from Reis where ID={reisID})").Tables[0].Rows[0].ItemArray[0];
            int quantityTickets = myClass.getData($"select * from Bilet where IDReis={reisID}").Tables[0].Rows.Count;
            tbQuantityFree.Text = (quantityPlace - quantityTickets).ToString();
        }

        /// <summary>
        /// При закрытии окно - открываем предыдущее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TiketConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["BuyTiket"].Show();
        }

        /// <summary>
        /// Если есть свободные места на самолёте - оформляет билет и заносит его в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(tbQuantityFree.Text != "0")
            {
                try
                {
                    myClass.executeQuery($"insert into Bilet(DateVormirovaniya, Summa, IDKlient, IDReis) values " +
                        $"('{DateTime.Now}', {tbSumma.Text}, {klientID}, {reisID})");
                    MessageBox.Show("Билет куплен", "Успех");
                    this.Close();
                }
                catch(Exception excep)
                {
                    MessageBox.Show(excep.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Свободных мест нету.", "Ошибка");
            }
        }
    }
}
