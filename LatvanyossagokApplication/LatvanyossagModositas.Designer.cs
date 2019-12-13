namespace LatvanyossagokApplication
{
    partial class LatvanyossagModositas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_latvanyossagModositas = new System.Windows.Forms.Label();
            this.tb_latvanyossagok_nev = new System.Windows.Forms.TextBox();
            this.lb_latvanyossagok_nev = new System.Windows.Forms.Label();
            this.tb_latvanyossagok_leiras = new System.Windows.Forms.TextBox();
            this.lb_latvanyossagok_leiras = new System.Windows.Forms.Label();
            this.lb_latvanyossagok_ar = new System.Windows.Forms.Label();
            this.nud_latvanyossagok_ar = new System.Windows.Forms.NumericUpDown();
            this.btn_latvanyossagok_fullModositas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_latvanyossagok_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_latvanyossagModositas
            // 
            this.lb_latvanyossagModositas.AutoSize = true;
            this.lb_latvanyossagModositas.Location = new System.Drawing.Point(10, 9);
            this.lb_latvanyossagModositas.Name = "lb_latvanyossagModositas";
            this.lb_latvanyossagModositas.Size = new System.Drawing.Size(132, 13);
            this.lb_latvanyossagModositas.TabIndex = 9;
            this.lb_latvanyossagModositas.Text = "Látványosság Módosítása";
            // 
            // tb_latvanyossagok_nev
            // 
            this.tb_latvanyossagok_nev.Location = new System.Drawing.Point(13, 51);
            this.tb_latvanyossagok_nev.Name = "tb_latvanyossagok_nev";
            this.tb_latvanyossagok_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_latvanyossagok_nev.TabIndex = 2;
            // 
            // lb_latvanyossagok_nev
            // 
            this.lb_latvanyossagok_nev.AutoSize = true;
            this.lb_latvanyossagok_nev.Location = new System.Drawing.Point(10, 35);
            this.lb_latvanyossagok_nev.Name = "lb_latvanyossagok_nev";
            this.lb_latvanyossagok_nev.Size = new System.Drawing.Size(30, 13);
            this.lb_latvanyossagok_nev.TabIndex = 8;
            this.lb_latvanyossagok_nev.Text = "Név:";
            // 
            // tb_latvanyossagok_leiras
            // 
            this.tb_latvanyossagok_leiras.Location = new System.Drawing.Point(13, 90);
            this.tb_latvanyossagok_leiras.Name = "tb_latvanyossagok_leiras";
            this.tb_latvanyossagok_leiras.Size = new System.Drawing.Size(100, 20);
            this.tb_latvanyossagok_leiras.TabIndex = 1;
            // 
            // lb_latvanyossagok_leiras
            // 
            this.lb_latvanyossagok_leiras.AutoSize = true;
            this.lb_latvanyossagok_leiras.Location = new System.Drawing.Point(10, 74);
            this.lb_latvanyossagok_leiras.Name = "lb_latvanyossagok_leiras";
            this.lb_latvanyossagok_leiras.Size = new System.Drawing.Size(40, 13);
            this.lb_latvanyossagok_leiras.TabIndex = 10;
            this.lb_latvanyossagok_leiras.Text = "Leírás:";
            // 
            // lb_latvanyossagok_ar
            // 
            this.lb_latvanyossagok_ar.AutoSize = true;
            this.lb_latvanyossagok_ar.Location = new System.Drawing.Point(10, 113);
            this.lb_latvanyossagok_ar.Name = "lb_latvanyossagok_ar";
            this.lb_latvanyossagok_ar.Size = new System.Drawing.Size(20, 13);
            this.lb_latvanyossagok_ar.TabIndex = 11;
            this.lb_latvanyossagok_ar.Text = "Ár:";
            // 
            // nud_latvanyossagok_ar
            // 
            this.nud_latvanyossagok_ar.Location = new System.Drawing.Point(13, 129);
            this.nud_latvanyossagok_ar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_latvanyossagok_ar.Name = "nud_latvanyossagok_ar";
            this.nud_latvanyossagok_ar.Size = new System.Drawing.Size(100, 20);
            this.nud_latvanyossagok_ar.TabIndex = 18;
            // 
            // btn_latvanyossagok_fullModositas
            // 
            this.btn_latvanyossagok_fullModositas.Location = new System.Drawing.Point(13, 155);
            this.btn_latvanyossagok_fullModositas.Name = "btn_latvanyossagok_fullModositas";
            this.btn_latvanyossagok_fullModositas.Size = new System.Drawing.Size(100, 23);
            this.btn_latvanyossagok_fullModositas.TabIndex = 17;
            this.btn_latvanyossagok_fullModositas.Text = "Módosítás";
            this.btn_latvanyossagok_fullModositas.UseVisualStyleBackColor = true;
            this.btn_latvanyossagok_fullModositas.Click += new System.EventHandler(this.btn_latvanyossagok_fullModositas_Click);
            // 
            // LatvanyossagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 191);
            this.Controls.Add(this.lb_latvanyossagModositas);
            this.Controls.Add(this.lb_latvanyossagok_nev);
            this.Controls.Add(this.lb_latvanyossagok_leiras);
            this.Controls.Add(this.lb_latvanyossagok_ar);
            this.Controls.Add(this.tb_latvanyossagok_nev);
            this.Controls.Add(this.tb_latvanyossagok_leiras);
            this.Controls.Add(this.nud_latvanyossagok_ar);
            this.Controls.Add(this.btn_latvanyossagok_fullModositas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LatvanyossagModositas";
            this.Text = "LatvanyossagModositas";
            ((System.ComponentModel.ISupportInitialize)(this.nud_latvanyossagok_ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_latvanyossagModositas;
        private System.Windows.Forms.TextBox tb_latvanyossagok_nev;
        private System.Windows.Forms.Label lb_latvanyossagok_nev;
        private System.Windows.Forms.TextBox tb_latvanyossagok_leiras;
        private System.Windows.Forms.Label lb_latvanyossagok_leiras;
        private System.Windows.Forms.Label lb_latvanyossagok_ar;
        private System.Windows.Forms.NumericUpDown nud_latvanyossagok_ar;
        private System.Windows.Forms.Button btn_latvanyossagok_fullModositas;
    }
}