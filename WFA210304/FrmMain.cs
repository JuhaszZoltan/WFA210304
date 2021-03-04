using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210304
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;

        public FrmMain()
        {
            conn = new SqlConnection(
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = nyelviskola;");

            InitializeComponent();
        }

        private void FrmMainLoad(object sender, EventArgs e)
        {
            Keres(null);
        }

        private void Keres(string kulcsszo)
        {
            dgvVizsgazok.Rows.Clear();

            conn.Open();

            var r = new SqlCommand(
                "SELECT jelentkezesek.sorsz, nev, nyelv, szint " +
                "FROM jelentkezesek " +
                "LEFT JOIN vizsgak ON vizsga = vizsgak.sorsz " +
                "LEFT JOIN nyelvek ON nyelvid = id " +
                $"WHERE nev LIKE '{kulcsszo}%';", conn)
                .ExecuteReader();

            while (r.Read())
            {
                dgvVizsgazok.Rows.Add(r[0], r[1], r[2], r[3]);
            }

            conn.Close();
        }

        private void TsmiVizsgakClick(object sender, EventArgs e)
        {
            var frm = new FrmVizsgak(conn);
            frm.ShowDialog();
        }

        private void TbKeresoTextChanged(object sender, EventArgs e)
        {
            Keres(tbKereso.Text);
        }

        private void DgvVizsgazokCellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvVizsgazok.SelectedRows[0].Cells[0].Value.ToString();
            var frm = new FrmVizsgazo(conn, id);
            frm.ShowDialog();
            Keres(tbKereso.Text);
        }

        private void TsmiUjVizsgazoClick(object sender, EventArgs e)
        {
            var frm = new FrmVizsgazo(conn);
            frm.ShowDialog();
            Keres(tbKereso.Text);
        }
    }
}
