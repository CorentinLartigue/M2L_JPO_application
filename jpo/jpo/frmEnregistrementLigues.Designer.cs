
namespace jpo
{
    partial class frmEnregistrementLigues
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
            this.components = new System.ComponentModel.Container();
            this.btnAjout = new System.Windows.Forms.Button();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxAddr = new System.Windows.Forms.TextBox();
            this.tbxCP = new System.Windows.Forms.TextBox();
            this.tbxDis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxInscrit = new System.Windows.Forms.ListBox();
            this.libInscrit = new System.Windows.Forms.Label();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.jpoDataSet = new jpo.jpoDataSet();
            this.lIGUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIGUESTableAdapter = new jpo.jpoDataSetTableAdapters.LIGUESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jpoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGUESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjout
            // 
            this.btnAjout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAjout.Location = new System.Drawing.Point(284, 426);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(110, 44);
            this.btnAjout.TabIndex = 2;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Validating += new System.ComponentModel.CancelEventHandler(this.btnAjout_Validating);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(434, 106);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(157, 20);
            this.tbxNom.TabIndex = 3;
            this.tbxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNom_KeyPress);
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(434, 235);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(157, 20);
            this.tbxVille.TabIndex = 4;
            this.tbxVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVille_KeyPress);
            // 
            // tbxAddr
            // 
            this.tbxAddr.Location = new System.Drawing.Point(434, 153);
            this.tbxAddr.Name = "tbxAddr";
            this.tbxAddr.Size = new System.Drawing.Size(157, 20);
            this.tbxAddr.TabIndex = 4;
            // 
            // tbxCP
            // 
            this.tbxCP.Location = new System.Drawing.Point(434, 198);
            this.tbxCP.Name = "tbxCP";
            this.tbxCP.Size = new System.Drawing.Size(157, 20);
            this.tbxCP.TabIndex = 5;
            this.tbxCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCP_KeyPress);
            // 
            // tbxDis
            // 
            this.tbxDis.Location = new System.Drawing.Point(434, 276);
            this.tbxDis.Name = "tbxDis";
            this.tbxDis.Size = new System.Drawing.Size(157, 20);
            this.tbxDis.TabIndex = 6;
            this.tbxDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDis_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(321, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(321, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresse";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label38.Location = new System.Drawing.Point(321, 200);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 18);
            this.label38.TabIndex = 45;
            this.label38.Text = "Code Postal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(195, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enregistrement ligues";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(321, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(321, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Discipline";
            // 
            // lboxInscrit
            // 
            this.lboxInscrit.FormattingEnabled = true;
            this.lboxInscrit.Location = new System.Drawing.Point(12, 106);
            this.lboxInscrit.Name = "lboxInscrit";
            this.lboxInscrit.Size = new System.Drawing.Size(237, 303);
            this.lboxInscrit.TabIndex = 51;
            this.lboxInscrit.SelectedIndexChanged += new System.EventHandler(this.lboxInscrit_SelectedIndexChanged);
            // 
            // libInscrit
            // 
            this.libInscrit.AutoSize = true;
            this.libInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libInscrit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.libInscrit.Location = new System.Drawing.Point(33, 72);
            this.libInscrit.Name = "libInscrit";
            this.libInscrit.Size = new System.Drawing.Size(214, 20);
            this.libInscrit.TabIndex = 48;
            this.libInscrit.Text = "Listes des Ligues Enregistrer";
            // 
            // btnSupp
            // 
            this.btnSupp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSupp.Location = new System.Drawing.Point(148, 426);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(110, 44);
            this.btnSupp.TabIndex = 52;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModif.Location = new System.Drawing.Point(12, 426);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(110, 44);
            this.btnModif.TabIndex = 53;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;

            // 
            // lIGUESBindingSource
            // 
            this.lIGUESBindingSource.DataMember = "LIGUES";
            this.lIGUESBindingSource.DataSource = this.jpoDataSet;
            // 
            // lIGUESTableAdapter
            // 
            this.lIGUESTableAdapter.ClearBeforeFill = true;
            // 
            // frmEnregistrementLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1093, 625);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.lboxInscrit);
            this.Controls.Add(this.libInscrit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDis);
            this.Controls.Add(this.tbxCP);
            this.Controls.Add(this.tbxAddr);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label1);
            this.Name = "frmEnregistrementLigues";
            this.Load += new System.EventHandler(this.frmEnregistrementLigues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jpoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGUESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxAddr;
        private System.Windows.Forms.TextBox tbxCP;
        private System.Windows.Forms.TextBox tbxDis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxInscrit;
        private System.Windows.Forms.Label libInscrit;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModif;
        private jpoDataSet jpoDataSet;
        private System.Windows.Forms.BindingSource lIGUESBindingSource;
        private jpoDataSetTableAdapters.LIGUESTableAdapter lIGUESTableAdapter;
    }
}