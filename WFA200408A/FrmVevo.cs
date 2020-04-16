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
    public partial class FrmVevo : Form
    {
        SqlConnection conn;

        public FrmVevo(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            rbIgen.Checked = true;
        }

        private void FrmVevo_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("SELECT nev FROM vevo;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbNev.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void cbNev_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbFoglalok.Text = "foglalózott hajók:\n";

            int id = cbNev.SelectedIndex + 1;
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT cim, megbizhato FROM vevo " +
                $"WHERE vevoid = {id};", conn);

            var r = cmd.ExecuteReader();

            r.Read();

            tbCim.Text = r.GetString(0);
            if (r.GetBoolean(1)) rbIgen.Checked = true;
            else rbNem.Checked = true;

            r.Close();

            cmd = new SqlCommand("SELECT tipus.nev, serules " +
                "FROM ufo INNER JOIN tipus ON ufo.tipus = tipus.tipusid " +
                $"WHERE foglalo = {id};", conn);

            r = cmd.ExecuteReader();

            while (r.Read())
            {
                rtbFoglalok.Text +=
                    $"{r[0]} {r[1]}%\n";
            }

            conn.Close();
        }
    }
}
