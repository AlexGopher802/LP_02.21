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
    public partial class BuyTiket : Form
    {
        DataClass myClass = new DataClass();
        string where = "";
        public int klientID = 0;

        public BuyTiket()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При закрытии формы - переходим на предыдущее окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyTiket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Enter"].Show();
        }

        /// <summary>
        /// Метод отображения информации о рейсах в таблицу
        /// </summary>
        void showDataFlights()
        {
            dataGridFlights.DataSource = myClass.getData($"select " +
                $"Reis.MestoVilita as [Откуда], " +
                $"Reis.MestoPribitya as [Куда], " +
                $"Reis.DateVileta as [Когда], " +
                $"Reis.Czena as [Стоимость], " +
                $"Samolet.Naimenovanie as [Самолёт], " +
                $"Reis.ID as [ID] " +
                $"from Reis " +
                $"left join Samolet on Reis.IDSamolet = Samolet.ID " +
                $"where 666=666 {where}").Tables[0];
            dataGridFlights.Columns[5].Visible = false;
        }

        /// <summary>
        /// При загрузке окна - заполняем таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyTiket_Load(object sender, EventArgs e)
        {
            showDataFlights();
        }

        /// <summary>
        /// Метод фильтрации рейсов по городу отправки и городу прибытия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(tbFrom.Text != "")
            {
                where += $"and MestoVilita='{tbFrom.Text} '";
            }

            if (tbTo.Text != "")
            {
                where += $"and MestoPribitya='{tbTo.Text} '";
            }

            showDataFlights();
            where = "";
        }

        /// <summary>
        /// Вызывает форму подтверждения оформления билета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dataGridFlights.SelectedRows.Count == 0) { MessageBox.Show("Ничего не выбрано", "Ошибка"); return; }

            this.Hide();
            TiketConfirm form = new TiketConfirm();
            form.dataGridFIO.DataSource = myClass.getData($"select " +
                $"LichnieDannie.Family as [Family], " +
                $"LichnieDannie.Imy as [Imy], " +
                $"LichnieDannie.Otchestvo as [Otchestvo] " +
                $"from Klient " +
                $"left join LichnieDannie on Klient.IDLichnieDannie = LichnieDannie.ID " +
                $"where Klient.ID={klientID}").Tables[0];
            
            form.dataGridReis.DataSource = myClass.getData($"select " +
                $"MestoVilita as [MestoVilita], " +
                $"MestoPribitya as [MestoPribitya], " +
                $"DateVileta as [DateVileta], " +
                $"Czena as [Czena] " +
                $"from Reis " +
                $"where ID={dataGridFlights.SelectedRows[0].Cells["ID"].Value}").Tables[0];
            form.reisID = (int)dataGridFlights.SelectedRows[0].Cells["ID"].Value;

            form.klientID = klientID;
            form.Show();
        }
    }
}
