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
    public partial class Form1 : Form
    {

        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Port=3307;Database=latvanyossagokdb;Uid=root;");
            conn.Open();

            VarosokListaz();

        }

        public void VarosokListaz()
        {

            lib_varosok.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT 
                                        id,nev,lakossag 
                                    FROM 
                                        varosok
                                    ORDER BY 
                                        nev";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    

                    var varosok = new Varosok(id, nev, lakossag);

                    lib_varosok.Items.Add(varosok);

                }
            }

        }
        

        public void LatvanyossagokListaz()
        {

            lib_latvanyossagok.Items.Clear();
            var command = conn.CreateCommand();
            var selectedVaros = (Varosok)lib_varosok.SelectedItem;
            command.CommandText = @"SELECT 
                                        id,nev,leiras,ar,varos_id FROM latvanyossagok
                                    WHERE 
                                        varos_id = " + selectedVaros.Id + @" 
                                    ORDER BY 
                                        nev";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var varos_id = reader.GetInt32("varos_id");

                    var latvanyossagok = new Latvanyossagok(id, nev, leiras, ar, varos_id);

                    lib_latvanyossagok.Items.Add(latvanyossagok);

                }
            }

        }

        private void btn_varosok_hozzaAd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_varosok_nev.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO 
                                    varosok(nev,lakossag)
                                VALUES
                                    (@nev,@lakossag)";

            cmd.Parameters.AddWithValue("@nev", tb_varosok_nev.Text);
            cmd.Parameters.AddWithValue("@lakossag", nud_varosok_lakossag.Value);

            cmd.ExecuteNonQuery();

            VarosokListaz();
        }

        private void btn_latvanyossagok_hozzaAd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_latvanyossagok_nev.Text) || string.IsNullOrWhiteSpace(tb_latvanyossagok_leiras.Text) || lib_varosok.SelectedItem == null )
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            var selectedVaros = (Varosok)lib_varosok.SelectedItem;

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO 
                                    latvanyossagok(nev,leiras,ar,varos_id)
                                VALUES
                                    (@nev,@leiras,@ar,@varos_id)";

            cmd.Parameters.AddWithValue("@nev", tb_latvanyossagok_nev.Text);
            cmd.Parameters.AddWithValue("@leiras", tb_latvanyossagok_leiras.Text);
            cmd.Parameters.AddWithValue("@ar", nud_latvanyossagok_ar.Value);
            cmd.Parameters.AddWithValue("@varos_id", selectedVaros.Id);
            cmd.ExecuteNonQuery();

            LatvanyossagokListaz();
        }

        private void lib_varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            LatvanyossagokListaz();

            var varos = (Varosok)lib_varosok.SelectedItem;
            tb_varosok_nev.Text = varos.Nev;
            nud_varosok_lakossag.Value = varos.Lakossag;
        }



        private void btn_varosok_modositas_Click(object sender, EventArgs e)
        {
            if (lib_varosok.SelectedItem == null)
            {
                MessageBox.Show("Válasszon ki egy várost!");
                return;
            }

            var selectedVaros = (Varosok)lib_varosok.SelectedItem;
            VarosModositas vm = new VarosModositas(selectedVaros);
            vm.Show();
        }

        private void btn_varosok_torles_Click(object sender, EventArgs e)
        {
            if (lib_varosok.SelectedItem == null)
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez");
                return;
            }
            clearLatvanyossagok();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM 
                                    varosok 
                                WHERE 
                                    id = @id";

            var varos = (Varosok)lib_varosok.SelectedItem;

            cmd.Parameters.AddWithValue("@id", varos.Id);
            cmd.ExecuteNonQuery();

            VarosokListaz();
            lib_latvanyossagok.Items.Clear();

        }

        private void btn_latvanyossagok_modositas_Click(object sender, EventArgs e)
        {
            if (lib_latvanyossagok.SelectedItem == null)
            {
                MessageBox.Show("Válasszon ki egy látványosságot!");
                return;
            }

            var selectedLatvanyossag = (Latvanyossagok)lib_latvanyossagok.SelectedItem;
            LatvanyossagModositas lm = new LatvanyossagModositas(selectedLatvanyossag);
            lm.Show();
        }


        private void btn_latvanyossagok_torles_Click(object sender, EventArgs e)
        {
            if (lib_latvanyossagok.SelectedItem == null)
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM 
                                    latvanyossagok 
                                WHERE 
                                    id = @id";

            var latvanyossag = (Latvanyossagok)lib_latvanyossagok.SelectedItem;

            cmd.Parameters.AddWithValue("@id", latvanyossag.Id);

            cmd.ExecuteNonQuery();
            LatvanyossagokListaz();
        }

        private void clearLatvanyossagok()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM 
                                    latvanyossagok 
                                WHERE 
                                    varos_id = @id";

            var varos = (Varosok)lib_varosok.SelectedItem;

            cmd.Parameters.AddWithValue("@id", varos.Id);
            cmd.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
