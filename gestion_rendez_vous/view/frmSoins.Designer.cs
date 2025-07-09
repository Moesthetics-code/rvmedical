namespace gestion_rendez_vous.view
{
    partial class frmSoins
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
            this.dgSoins = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomSoin = new System.Windows.Forms.TextBox();
            this.txt_coutSoin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_libelleSoin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSoins
            // 
            this.dgSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoins.Location = new System.Drawing.Point(311, 12);
            this.dgSoins.Name = "dgSoins";
            this.dgSoins.Size = new System.Drawing.Size(477, 413);
            this.dgSoins.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Soin";
            // 
            // txt_nomSoin
            // 
            this.txt_nomSoin.Location = new System.Drawing.Point(15, 148);
            this.txt_nomSoin.Name = "txt_nomSoin";
            this.txt_nomSoin.Size = new System.Drawing.Size(204, 20);
            this.txt_nomSoin.TabIndex = 2;
            // 
            // txt_coutSoin
            // 
            this.txt_coutSoin.Location = new System.Drawing.Point(15, 228);
            this.txt_coutSoin.Name = "txt_coutSoin";
            this.txt_coutSoin.Size = new System.Drawing.Size(204, 20);
            this.txt_coutSoin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cout Soin";
            // 
            // txt_libelleSoin
            // 
            this.txt_libelleSoin.Location = new System.Drawing.Point(15, 302);
            this.txt_libelleSoin.Name = "txt_libelleSoin";
            this.txt_libelleSoin.Size = new System.Drawing.Size(204, 20);
            this.txt_libelleSoin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libelle";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(12, 390);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 35);
            this.btn_ajouter.TabIndex = 7;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // frmSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_libelleSoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_coutSoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomSoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSoins);
            this.Name = "frmSoins";
            this.Text = "frmSoins";
            this.Load += new System.EventHandler(this.frmSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSoins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomSoin;
        private System.Windows.Forms.TextBox txt_coutSoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_libelleSoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ajouter;
    }
}