using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200408A
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;

        public FrmMain()
        {
            AppDomain.CurrentDomain.SetData(
                "DataDirectory",
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly()
                    .Location)
                .Replace(@"bin\Debug", "Res"));

            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFilename=|DataDirectory|hasznaltufo.mdf;");

            InitializeComponent();
            this.Icon = Properties.Resources.ufo;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT tipus.nev, tipus.alapar, ufo.lopott, ufo.serules " +
                "FROM ufo INNER JOIN tipus ON ufo.tipus = tipus.tipusid;", conn);

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                int s = r.GetInt32(3);

                string allapot;

                     if (s < 25) allapot = "hibátlan";
                else if (s < 50) allapot = "újszerű";
                else if (s < 66) allapot = "megkímélt";
                else allapot = "alkatrésznek";


                dgv.Rows.Add(
                        //név
                        r[0],
                        //ár
                        Math.Round((r.GetInt32(1) - ((r.GetInt32(1) / 100F) * r.GetInt32(3)))
                        * (r.GetBoolean(2) ? 0.8 : 1)) + " CP",
                        //állapot
                        allapot);
            }

            conn.Close();
        }

        private void VevokTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmVevo(conn);
            frm.ShowDialog();
        }

        private void KeresoTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmKereso(conn);
            frm.ShowDialog();
        }
    }
}
