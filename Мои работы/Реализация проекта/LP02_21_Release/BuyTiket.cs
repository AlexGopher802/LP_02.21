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

        private void BuyTiket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Enter"].Show();
        }

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

        private void BuyTiket_Load(object sender, EventArgs e)
        {
            showDataFlights();
        }

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
            form.Show();

            /*
            try
            {
                myClass.executeQuery($"insert into Bilet(DateVormirovaniya, Summa, IDKlient, IDReis) values " +
                    $"(getdate(), {dataGridFlights.SelectedRows[0].Cells["Стоимость"].Value}, " +
                    $"{klientID}, {dataGridFlights.SelectedRows[0].Cells["ID"].Value})");

                MessageBox.Show("Билет успешно куплен", "Успех");
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "Ошибка");
            }
            */
        }
    }
}
