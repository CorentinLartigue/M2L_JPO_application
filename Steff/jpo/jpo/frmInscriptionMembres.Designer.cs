
namespace jpo
{
    partial class frmInscriptionMembres
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxInscrit = new System.Windows.Forms.ListBox();
            this.lbxNonInscrit = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.lbxActivité = new System.Windows.Forms.ListBox();
            this.clbCreneaux = new System.Windows.Forms.CheckedListBox();
            this.lblNonInscrit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActivité = new System.Windows.Forms.Label();
            this.cbxLigue = new System.Windows.Forms.ComboBox();
            this.lblLigue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inscription membres";
            // 
            // lbxInscrit
            // 
            this.lbxInscrit.FormattingEnabled = true;
            this.lbxInscrit.Location = new System.Drawing.Point(679, 136);
            this.lbxInscrit.Name = "lbxInscrit";
            this.lbxInscrit.Size = new System.Drawing.Size(158, 186);
            this.lbxInscrit.TabIndex = 6;
            // 
            // lbxNonInscrit
            // 
            this.lbxNonInscrit.FormattingEnabled = true;
            this.lbxNonInscrit.Location = new System.Drawing.Point(163, 145);
            this.lbxNonInscrit.Name = "lbxNonInscrit";
            this.lbxNonInscrit.Size = new System.Drawing.Size(169, 173);
            this.lbxNonInscrit.TabIndex = 7;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(706, 339);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(87, 56);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(523, 339);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(75, 56);
            this.btnDesinscrire.TabIndex = 9;
            this.btnDesinscrire.Text = "Desinscrire";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            // 
            // btnInscrire
            // 
            this.btnInscrire.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnInscrire.Location = new System.Drawing.Point(416, 339);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(84, 56);
            this.btnInscrire.TabIndex = 8;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            // 
            // lbxActivité
            // 
            this.lbxActivité.FormattingEnabled = true;
            this.lbxActivité.Location = new System.Drawing.Point(387, 136);
            this.lbxActivité.Name = "lbxActivité";
            this.lbxActivité.Size = new System.Drawing.Size(211, 121);
            this.lbxActivité.TabIndex = 11;
            // 
            // clbCreneaux
            // 
            this.clbCreneaux.FormattingEnabled = true;
            this.clbCreneaux.Items.AddRange(new object[] {
            "Matin",
            "Aprés-midi"});
            this.clbCreneaux.Location = new System.Drawing.Point(387, 284);
            this.clbCreneaux.Name = "clbCreneaux";
            this.clbCreneaux.Size = new System.Drawing.Size(211, 34);
            this.clbCreneaux.TabIndex = 5;
            // 
            // lblNonInscrit
            // 
            this.lblNonInscrit.AutoSize = true;
            this.lblNonInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonInscrit.Location = new System.Drawing.Point(204, 100);
            this.lblNonInscrit.Name = "lblNonInscrit";
            this.lblNonInscrit.Size = new System.Drawing.Size(85, 20);
            this.lblNonInscrit.TabIndex = 12;
            this.lblNonInscrit.Text = "Non Inscrit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inscription";
            // 
            // lblActivité
            // 
            this.lblActivité.AutoSize = true;
            this.lblActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivité.Location = new System.Drawing.Point(459, 100);
            this.lblActivité.Name = "lblActivité";
            this.lblActivité.Size = new System.Drawing.Size(57, 20);
            this.lblActivité.TabIndex = 14;
            this.lblActivité.Text = "Actvité";
            // 
            // cbxLigue
            // 
            this.cbxLigue.FormattingEnabled = true;
            this.cbxLigue.Location = new System.Drawing.Point(23, 219);
            this.cbxLigue.Name = "cbxLigue";
            this.cbxLigue.Size = new System.Drawing.Size(121, 21);
            this.cbxLigue.TabIndex = 15;
            // 
            // lblLigue
            // 
            this.lblLigue.AutoSize = true;
            this.lblLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigue.Location = new System.Drawing.Point(48, 174);
            this.lblLigue.Name = "lblLigue";
            this.lblLigue.Size = new System.Drawing.Size(48, 20);
            this.lblLigue.TabIndex = 16;
            this.lblLigue.Text = "Ligue";
            // 
            // frmInscriptionMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.lblLigue);
            this.Controls.Add(this.cbxLigue);
            this.Controls.Add(this.lblActivité);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNonInscrit);
            this.Controls.Add(this.lbxActivité);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.lbxNonInscrit);
            this.Controls.Add(this.lbxInscrit);
            this.Controls.Add(this.clbCreneaux);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmInscriptionMembres";
            this.Text = "frmInscriptionMembres";
            this.Load += new System.EventHandler(this.frmInscriptionMembres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxInscrit;
        private System.Windows.Forms.ListBox lbxNonInscrit;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.ListBox lbxActivité;
        private System.Windows.Forms.CheckedListBox clbCreneaux;
        private System.Windows.Forms.Label lblNonInscrit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblActivité;
        private System.Windows.Forms.ComboBox cbxLigue;
        private System.Windows.Forms.Label lblLigue;
    }
}