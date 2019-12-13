using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class VarosModositas : Form
    {
        MySqlConnection conn;
        Varosok selectedVaros;

        internal VarosModositas(Varosok v)
        {
            selectedVaros = v;
            conn = new MySqlConnection("Server=localhost;Port=3307;Database=latvanyossagokdb;Uid=root;");
            conn.Open();
            InitializeComponent();
        }

        private void btn_varosok_fullModositas_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE
                                    varosok
                                SET 
                                    nev = @nev,                        
                                    lakossag = @lakossag
                                WHERE id = @id
                                ";

            cmd.Parameters.AddWithValue("@nev", tb_varosok_nev.Text);
            cmd.Parameters.AddWithValue("@lakossag", nud_varosok_lakossag.Value);
            cmd.Parameters.AddWithValue("@id", selectedVaros.Id);
            cmd.ExecuteNonQuery();

            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).VarosokListaz();

            this.Close();
        }
    }
}
