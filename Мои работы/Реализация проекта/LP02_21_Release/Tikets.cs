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
    public partial class Tikets : Form
    {
        DataClass myClass = new DataClass();

        public Tikets()
        {
            InitializeComponent();
        }

        private void Tikets_Load(object sender, EventArgs e)
        {
            dataGridTikets.DataSource = myClass.getData($"select " +
                $"Reis.MestoVilita as [Откуда], " +
                $"Reis.MestoPribitya as [Куда], " +
                $"Reis.DateVileta as [Дата вылета], " +
                $"LichnieDannie.Family as [Фамилия], " +
                $"LichnieDannie.Imy as [Имя], " +
                $"Bilet.Summa as [Стоимость], " +
                $"Bilet.DateVormirovaniya as [Дата оформления] " +
                $"from Bilet " +
                $"left join Klient on Bilet.IDKlient = Klient.ID " +
                $"left join LichnieDannie on Klient.IDLichnieDannie = LichnieDannie.ID " +
                $"left join Reis on Bilet.IDReis = Reis.ID ").Tables[0];
        }

        private void Tikets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Sotrudnik"].Show();
        }
    }
}
