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
    public partial class FrmVizsgak : Form
    {
        SqlConnection conn;
        public FrmVizsgak(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void FrmVizsgakLoad(object sender, EventArgs e)
        {
            CbFeltolt();
            DgvBetolt(null);
        }

        private void DgvBetolt(string nyelv)
        {
            dgvVizsgak.Rows.Clear();

            conn.Open();

            var r = new SqlCommand(
                "SELECT idopont, nyelv, szint " +
                "FROM vizsgak " +
                "INNER JOIN nyelvek ON nyelvid = id " +
                $"WHERE nyelv LIKE '{nyelv}%';", conn)
                .ExecuteReader();

            while (r.Read())
            {
                dgvVizsgak.Rows.Add(
                    r.GetDateTime(0).ToString("yyyy-MM-dd HH:mm"),
                    r[1], r[2]);
            }

            conn.Close();
        }

        private void CbFeltolt()
        {
            conn.Open();
            var r = new SqlCommand(
                "SELECT DISTINCT nyelv FROM nyelvek;", conn)
                .ExecuteReader();
            while (r.Read()) cbNyelvek.Items.Add(r[0]);
            conn.Close();
        }

        private void CbNyelvekSelectedValueChanged(object sender, EventArgs e)
        {
            DgvBetolt(cbNyelvek.SelectedItem.ToString());
        }
    }
}
