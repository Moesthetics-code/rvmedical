namespace gestion_rendez_vous.view
{
    partial class frmMedecin
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
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtx_adresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Identifiant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NumeroOM = new System.Windows.Forms.TextBox();
            this.btn_choisir = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_agenda = new System.Windows.Forms.Button();
            this.cbbSpecialite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMedecin
            // 
            this.dgMedecin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedecin.Location = new System.Drawing.Point(411, 75);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.Size = new System.Drawing.Size(474, 443);
            this.dgMedecin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom Prenom";
            // 
            // txt_nom_prenom
            // 
            this.txt_nom_prenom.Location = new System.Drawing.Point(12, 75);
            this.txt_nom_prenom.Name = "txt_nom_prenom";
            this.txt_nom_prenom.Size = new System.Drawing.Size(254, 20);
            this.txt_nom_prenom.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adresse";
            // 
            // txtx_adresse
            // 
            this.txtx_adresse.Location = new System.Drawing.Point(12, 134);
            this.txtx_adresse.Name = "txtx_adresse";
            this.txtx_adresse.Size = new System.Drawing.Size(254, 20);
            this.txtx_adresse.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(254, 20);
            this.txt_email.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telephone";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(12, 257);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(254, 20);
            this.txt_tel.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Identifiant";
            // 
            // txt_Identifiant
            // 
            this.txt_Identifiant.Location = new System.Drawing.Point(12, 325);
            this.txt_Identifiant.Name = "txt_Identifiant";
            this.txt_Identifiant.Size = new System.Drawing.Size(254, 20);
            this.txt_Identifiant.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Specialite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Numero Ordre Medecin";
            // 
            // txt_NumeroOM
            // 
            this.txt_NumeroOM.Location = new System.Drawing.Point(12, 448);
            this.txt_NumeroOM.Name = "txt_NumeroOM";
            this.txt_NumeroOM.Size = new System.Drawing.Size(254, 20);
            this.txt_NumeroOM.TabIndex = 24;
            // 
            // btn_choisir
            // 
            this.btn_choisir.Location = new System.Drawing.Point(642, 51);
            this.btn_choisir.Name = "btn_choisir";
            this.btn_choisir.Size = new System.Drawing.Size(75, 23);
            this.btn_choisir.TabIndex = 27;
            this.btn_choisir.Text = "&Choisir";
            this.btn_choisir.UseVisualStyleBackColor = true;
            this.btn_choisir.Click += new System.EventHandler(this.btn_choisir_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(106, 485);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 29;
            this.btn_modifier.Text = "&Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(191, 485);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 30;
            this.btn_supprimer.Text = "&Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(15, 485);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 26;
            this.btn_ajouter.Text = "&Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_agenda
            // 
            this.btn_agenda.Location = new System.Drawing.Point(723, 51);
            this.btn_agenda.Name = "btn_agenda";
            this.btn_agenda.Size = new System.Drawing.Size(75, 23);
            this.btn_agenda.TabIndex = 33;
            this.btn_agenda.Text = "&Agenda";
            this.btn_agenda.UseVisualStyleBackColor = true;
            this.btn_agenda.Click += new System.EventHandler(this.btn_agenda_Click);
            // 
            // cbbSpecialite
            // 
            this.cbbSpecialite.FormattingEnabled = true;
            this.cbbSpecialite.Location = new System.Drawing.Point(12, 384);
            this.cbbSpecialite.Name = "cbbSpecialite";
            this.cbbSpecialite.Size = new System.Drawing.Size(254, 21);
            this.cbbSpecialite.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(489, 71);
            this.label5.TabIndex = 54;
            this.label5.Text = "Clinique Amitie";
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(804, 51);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 55;
            this.btn_fermer.Text = "&Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbSpecialite);
            this.Controls.Add(this.btn_agenda);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_choisir);
            this.Controls.Add(this.txt_NumeroOM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Identifiant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtx_adresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom_prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMedecin);
            this.Name = "frmMedecin";
            this.Text = " Medecin";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMedecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtx_adresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Identifiant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NumeroOM;
        private System.Windows.Forms.Button btn_choisir;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_agenda;
        private System.Windows.Forms.ComboBox cbbSpecialite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_fermer;
    }
}