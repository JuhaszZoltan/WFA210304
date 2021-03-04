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
    public partial class FrmVizsgazo : Form
    {
        SqlConnection conn;
        string id;

        public FrmVizsgazo(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            btnMod.Enabled = false;
            btnTorles.Enabled = false;
            SetId();
        }
        public FrmVizsgazo(SqlConnection conn, string id)
        {
            this.conn = conn;
            this.id = id;
            InitializeComponent();
            btnUj.Enabled = false;
            TbsKitolt();
        }

        private void SetId()
        {
            conn.Open();

            var r = new SqlCommand(
                "SELECT MAX(sorsz) FROM jelentkezesek;", conn)
                .ExecuteReader();
            r.Read();
            id =  (r.GetInt32(0) + 1).ToString();
            tbId.Text = $"{id}";
            conn.Close();
        }
        private void TbsKitolt()
        {
            tbId.Text = $"{id}";

            conn.Open();

            var r = new SqlCommand(
                "SELECT nev, mobil, szulev " +
                "FROM jelentkezesek " +
                $"WHERE sorsz = {id};", conn)
                .ExecuteReader();

            r.Read();

            tbNev.Text = r.GetString(0);
            tbMobil.Text = r.GetString(1);
            tbSzul.Text = r.GetInt32(2).ToString();

            conn.Close();
        }

        private void BtnUjClick(object sender, EventArgs e)
        {
            if(Vizsgalat(MsgMegerosites(
                "Biztosan rögzíted az új vizsgázót?")))
            {
                conn.Open();
                new SqlCommand(
                    "INSERT INTO jelentkezesek (sorsz, nev, mobil, szulev) VALUES " +
                    $"({id}, '{tbNev.Text}', '{tbMobil.Text}', {tbSzul.Text});", conn)
                    .ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }

        private void BtnModClick(object sender, EventArgs e)
        {
            

            if (Vizsgalat(MsgMegerosites(
                "Biztosan módosítani kívánod a vizsgázó adatait?")))
            {
                conn.Open();
                new SqlCommand(
                    "UPDATE jelentkezesek SET " +
                    $"nev = '{tbNev.Text}', " +
                    $"mobil = '{tbMobil.Text}', " +
                    $"szulev = {tbSzul.Text} " +
                    $"WHERE sorsz = {id};", conn)
                    .ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }

        private void BtnTorlesClick(object sender, EventArgs e)
        {
            if(MsgMegerosites("Biztosan törlöd a vizsgázót?") == DialogResult.Yes)
            {
                conn.Open();
                new SqlCommand(
                    "DELETE FROM jelentkezesek " +
                    $"WHERE sorsz = {id};", conn)
                    .ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }

        private DialogResult MsgMegerosites(string szoveg) =>
            MessageBox.Show(
                $"{szoveg}",
                "MEGERŐSÍTÉS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        private bool Vizsgalat(DialogResult res) => 
            res == DialogResult.Yes
            && !string.IsNullOrEmpty(tbNev.Text)
            && !string.IsNullOrEmpty(tbMobil.Text)
            && int.TryParse(tbSzul.Text, out int _);
    }
}
