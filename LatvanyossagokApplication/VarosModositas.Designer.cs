namespace LatvanyossagokApplication
{
    partial class VarosModositas
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
            this.lb_varosModositas = new System.Windows.Forms.Label();
            this.tb_varosok_nev = new System.Windows.Forms.TextBox();
            this.lb_varosok_nev = new System.Windows.Forms.Label();
            this.lb_varosok_lakossag = new System.Windows.Forms.Label();
            this.nud_varosok_lakossag = new System.Windows.Forms.NumericUpDown();
            this.btn_varosok_fullModositas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_varosok_lakossag)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_varosModositas
            // 
            this.lb_varosModositas.AutoSize = true;
            this.lb_varosModositas.Location = new System.Drawing.Point(10, 9);
            this.lb_varosModositas.Name = "lb_varosModositas";
            this.lb_varosModositas.Size = new System.Drawing.Size(132, 13);
            this.lb_varosModositas.TabIndex = 9;
            this.lb_varosModositas.Text = "Látványosság Módosítása";
            // 
            // tb_varosok_nev
            // 
            this.tb_varosok_nev.Location = new System.Drawing.Point(13, 51);
            this.tb_varosok_nev.Name = "tb_varosok_nev";
            this.tb_varosok_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_varosok_nev.TabIndex = 2;
            // 
            // lb_varosok_nev
            // 
            this.lb_varosok_nev.AutoSize = true;
            this.lb_varosok_nev.Location = new System.Drawing.Point(10, 35);
            this.lb_varosok_nev.Name = "lb_varosok_nev";
            this.lb_varosok_nev.Size = new System.Drawing.Size(30, 13);
            this.lb_varosok_nev.TabIndex = 8;
            this.lb_varosok_nev.Text = "Név:";
            // 
            // lb_varosok_lakossag
            // 
            this.lb_varosok_lakossag.AutoSize = true;
            this.lb_varosok_lakossag.Location = new System.Drawing.Point(10, 74);
            this.lb_varosok_lakossag.Name = "lb_varosok_lakossag";
            this.lb_varosok_lakossag.Size = new System.Drawing.Size(56, 13);
            this.lb_varosok_lakossag.TabIndex = 11;
            this.lb_varosok_lakossag.Text = "Lakosság:";
            // 
            // nud_varosok_lakossag
            // 
            this.nud_varosok_lakossag.Location = new System.Drawing.Point(13, 90);
            this.nud_varosok_lakossag.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_varosok_lakossag.Name = "nud_varosok_lakossag";
            this.nud_varosok_lakossag.Size = new System.Drawing.Size(100, 20);
            this.nud_varosok_lakossag.TabIndex = 18;
            // 
            // btn_varosok_fullModositas
            // 
            this.btn_varosok_fullModositas.Location = new System.Drawing.Point(13, 116);
            this.btn_varosok_fullModositas.Name = "btn_varosok_fullModositas";
            this.btn_varosok_fullModositas.Size = new System.Drawing.Size(100, 23);
            this.btn_varosok_fullModositas.TabIndex = 17;
            this.btn_varosok_fullModositas.Text = "Módosítás";
            this.btn_varosok_fullModositas.UseVisualStyleBackColor = true;
            this.btn_varosok_fullModositas.Click += new System.EventHandler(this.btn_varosok_fullModositas_Click);
            // 
            // VarosModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 148);
            this.Controls.Add(this.lb_varosModositas);
            this.Controls.Add(this.lb_varosok_nev);
            this.Controls.Add(this.tb_varosok_nev);
            this.Controls.Add(this.lb_varosok_lakossag);
            this.Controls.Add(this.nud_varosok_lakossag);
            this.Controls.Add(this.btn_varosok_fullModositas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VarosModositas";
            this.Text = "varosModositas";
            ((System.ComponentModel.ISupportInitialize)(this.nud_varosok_lakossag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_varosModositas;
        private System.Windows.Forms.TextBox tb_varosok_nev;
        private System.Windows.Forms.Label lb_varosok_nev;
        private System.Windows.Forms.Label lb_varosok_lakossag;
        private System.Windows.Forms.NumericUpDown nud_varosok_lakossag;
        private System.Windows.Forms.Button btn_varosok_fullModositas;
    }
}