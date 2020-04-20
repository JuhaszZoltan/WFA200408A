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

namespace WFA200408A
{
    public partial class FrmKereso : Form
    {
        private SqlConnection conn;
        public FrmKereso(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            tbJarmu.TextChanged += TbTextChanged;
            tbVevo.TextChanged += TbTextChanged;
        }

        private void TbTextChanged(object sender, EventArgs e)
        {
            Lekerdezes(tbJarmu.Text, tbVevo.Text);
        }

        public void Lekerdezes(string jNev, string vNev)
        {
            dgv.Rows.Clear();
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT tipus.nev, vevo.nev " +
                "FROM tipus " +
                "INNER JOIN ufo ON tipus.tipusid = ufo.tipus " +
                "INNER JOIN vevo ON ufo.foglalo = vevo.vevoid " +
                $"WHERE tipus.nev LIKE '{tbJarmu.Text}%' " +
                $"AND vevo.nev LIKE '{tbVevo.Text}%';", conn);

            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgv.Rows.Add(r[0], r[1]);
            }
            conn.Close();
        }

        private void FrmKereso_Load(object sender, EventArgs e)
        {
            Lekerdezes(null, null);
        }
    }
}
