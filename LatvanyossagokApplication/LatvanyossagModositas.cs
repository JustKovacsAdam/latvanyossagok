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
    public partial class LatvanyossagModositas : Form
    {
        MySqlConnection conn;
        Latvanyossagok selectedLatvanyossag;
        internal LatvanyossagModositas(Latvanyossagok l)
        {
            selectedLatvanyossag = l;
            conn = new MySqlConnection("Server=localhost;Port=3307;Database=latvanyossagokdb;Uid=root;");
            conn.Open();
            InitializeComponent();


        }

        private void btn_latvanyossagok_fullModositas_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE
                                    latvanyossagok
                                SET 
                                    nev = @nev,
                                    leiras = @leiras,                            
                                    ar = @ar
                                WHERE id = @id
                                ";

            cmd.Parameters.AddWithValue("@nev", tb_latvanyossagok_nev.Text);
            cmd.Parameters.AddWithValue("@leiras", tb_latvanyossagok_leiras.Text);
            cmd.Parameters.AddWithValue("@ar", nud_latvanyossagok_ar.Value);
            cmd.Parameters.AddWithValue("@id", selectedLatvanyossag.Id);
            cmd.ExecuteNonQuery();

            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).LatvanyossagokListaz();

            this.Close();
        }

    }
}
