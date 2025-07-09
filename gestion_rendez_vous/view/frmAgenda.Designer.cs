namespace gestion_rendez_vous.view
{
    partial class frmAgenda
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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_choisir = new System.Windows.Forms.Button();
            this.txt_creneau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_lieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_heurefin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_heuredebut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAgence = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.lbl_medecin = new System.Windows.Forms.Label();
            this.lbl_idmedecin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgence)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(10, 465);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 65;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(189, 465);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 69;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(101, 465);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 68;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_choisir
            // 
            this.btn_choisir.Location = new System.Drawing.Point(729, 63);
            this.btn_choisir.Name = "btn_choisir";
            this.btn_choisir.Size = new System.Drawing.Size(75, 23);
            this.btn_choisir.TabIndex = 66;
            this.btn_choisir.Text = "Choisir";
            this.btn_choisir.UseVisualStyleBackColor = true;
            this.btn_choisir.Click += new System.EventHandler(this.btn_choisir_Click);
            // 
            // txt_creneau
            // 
            this.txt_creneau.Location = new System.Drawing.Point(10, 397);
            this.txt_creneau.Name = "txt_creneau";
            this.txt_creneau.Size = new System.Drawing.Size(254, 20);
            this.txt_creneau.TabIndex = 62;
            this.txt_creneau.TextChanged += new System.EventHandler(this.txt_Specialite_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 70;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_lieu
            // 
            this.txt_lieu.Location = new System.Drawing.Point(10, 336);
            this.txt_lieu.Name = "txt_lieu";
            this.txt_lieu.Size = new System.Drawing.Size(254, 20);
            this.txt_lieu.TabIndex = 59;
            this.txt_lieu.TextChanged += new System.EventHandler(this.txt_Identifiant_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Lieu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_heurefin
            // 
            this.txt_heurefin.Location = new System.Drawing.Point(10, 275);
            this.txt_heurefin.Name = "txt_heurefin";
            this.txt_heurefin.Size = new System.Drawing.Size(254, 20);
            this.txt_heurefin.TabIndex = 60;
            this.txt_heurefin.TextChanged += new System.EventHandler(this.txt_tel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Heure Fin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_heuredebut
            // 
            this.txt_heuredebut.Location = new System.Drawing.Point(10, 214);
            this.txt_heuredebut.Name = "txt_heuredebut";
            this.txt_heuredebut.Size = new System.Drawing.Size(254, 20);
            this.txt_heuredebut.TabIndex = 58;
            this.txt_heuredebut.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Heure Debut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_titre
            // 
            this.txt_titre.Location = new System.Drawing.Point(10, 92);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(254, 20);
            this.txt_titre.TabIndex = 54;
            this.txt_titre.TextChanged += new System.EventHandler(this.txt_nom_prenom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Titre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgAgence
            // 
            this.dgAgence.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAgence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgence.GridColor = System.Drawing.SystemColors.Control;
            this.dgAgence.Location = new System.Drawing.Point(409, 92);
            this.dgAgence.Name = "dgAgence";
            this.dgAgence.Size = new System.Drawing.Size(474, 426);
            this.dgAgence.TabIndex = 53;
            this.dgAgence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedecin_CellContentClick);
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(13, 153);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(251, 20);
            this.txtDate.TabIndex = 71;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(810, 63);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 72;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // lbl_medecin
            // 
            this.lbl_medecin.AutoSize = true;
            this.lbl_medecin.Location = new System.Drawing.Point(12, 435);
            this.lbl_medecin.Name = "lbl_medecin";
            this.lbl_medecin.Size = new System.Drawing.Size(0, 13);
            this.lbl_medecin.TabIndex = 73;
            // 
            // lbl_idmedecin
            // 
            this.lbl_idmedecin.AutoSize = true;
            this.lbl_idmedecin.Location = new System.Drawing.Point(107, 368);
            this.lbl_idmedecin.Name = "lbl_idmedecin";
            this.lbl_idmedecin.Size = new System.Drawing.Size(47, 13);
            this.lbl_idmedecin.TabIndex = 74;
            this.lbl_idmedecin.Text = "Creneau";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(489, 71);
            this.label5.TabIndex = 75;
            this.label5.Text = "Clinique Amitie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Creneau";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 530);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_idmedecin);
            this.Controls.Add(this.lbl_medecin);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_choisir);
            this.Controls.Add(this.txt_creneau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_lieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_heurefin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_heuredebut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAgence);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_choisir;
        private System.Windows.Forms.TextBox txt_creneau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_lieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_heurefin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_heuredebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAgence;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label lbl_medecin;
        private System.Windows.Forms.Label lbl_idmedecin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}