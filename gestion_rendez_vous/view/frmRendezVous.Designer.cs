namespace gestion_rendez_vous.view
{
    partial class frmRendezVous
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
            this.dgrvlist = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_creneaux = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.soincbb = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ajouter_btn = new System.Windows.Forms.Button();
            this.fermer_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_creneaux)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvlist
            // 
            this.dgrvlist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvlist.Location = new System.Drawing.Point(478, 77);
            this.dgrvlist.Name = "dgrvlist";
            this.dgrvlist.Size = new System.Drawing.Size(400, 433);
            this.dgrvlist.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Identifiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nom Prenom Specialite";
            // 
            // dg_creneaux
            // 
            this.dg_creneaux.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_creneaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_creneaux.Location = new System.Drawing.Point(314, 78);
            this.dg_creneaux.Name = "dg_creneaux";
            this.dg_creneaux.Size = new System.Drawing.Size(147, 433);
            this.dg_creneaux.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Soin";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Cout";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Medecin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "Mode de paiement";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 421);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Numero de reference";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 69;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 449);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 70;
            // 
            // soincbb
            // 
            this.soincbb.FormattingEnabled = true;
            this.soincbb.Location = new System.Drawing.Point(11, 131);
            this.soincbb.Name = "soincbb";
            this.soincbb.Size = new System.Drawing.Size(219, 21);
            this.soincbb.TabIndex = 71;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 21);
            this.comboBox2.TabIndex = 72;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(11, 381);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(219, 21);
            this.comboBox3.TabIndex = 73;
            // 
            // ajouter_btn
            // 
            this.ajouter_btn.Location = new System.Drawing.Point(155, 487);
            this.ajouter_btn.Name = "ajouter_btn";
            this.ajouter_btn.Size = new System.Drawing.Size(75, 23);
            this.ajouter_btn.TabIndex = 74;
            this.ajouter_btn.Text = "Ajouter";
            this.ajouter_btn.UseVisualStyleBackColor = true;
            // 
            // fermer_btn
            // 
            this.fermer_btn.Location = new System.Drawing.Point(803, 39);
            this.fermer_btn.Name = "fermer_btn";
            this.fermer_btn.Size = new System.Drawing.Size(75, 23);
            this.fermer_btn.TabIndex = 75;
            this.fermer_btn.Text = "Femer";
            this.fermer_btn.UseVisualStyleBackColor = true;
            this.fermer_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Nombre de creneaux";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(281, 41);
            this.label16.TabIndex = 77;
            this.label16.Text = "Clinique Amitie";
            // 
            // frmRendezVous
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 522);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fermer_btn);
            this.Controls.Add(this.ajouter_btn);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.soincbb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgrvlist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_creneaux);
            this.Name = "frmRendezVous";
            this.Load += new System.EventHandler(this.frmRendezVous_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_creneaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NumeroOM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label identifiant_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NPpt_lbl;
        private System.Windows.Forms.DataGridView dgCreneaux;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.ComboBox cbbSoin;
        private System.Windows.Forms.ComboBox cbbMedecin;
        private System.Windows.Forms.ComboBox cbbModepaiement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dglisteRV;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DataGridView dgrvlist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_creneaux;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox soincbb;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button ajouter_btn;
        private System.Windows.Forms.Button fermer_btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}