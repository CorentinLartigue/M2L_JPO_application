
namespace jpo
{
    partial class frmInscriptionLigues
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
            this.lbStandLongueur = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbStandlargeur = new System.Windows.Forms.Label();
            this.lbStand = new System.Windows.Forms.Label();
            this.Présentoir = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscription ligues";
            // 
            // lbStandLongueur
            // 
            this.lbStandLongueur.AutoSize = true;
            this.lbStandLongueur.Location = new System.Drawing.Point(12, 125);
            this.lbStandLongueur.Name = "lbStandLongueur";
            this.lbStandLongueur.Size = new System.Drawing.Size(55, 13);
            this.lbStandLongueur.TabIndex = 2;
            this.lbStandLongueur.Text = "Longueur ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 125);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(70, 178);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // lbStandlargeur
            // 
            this.lbStandlargeur.AutoSize = true;
            this.lbStandlargeur.Location = new System.Drawing.Point(12, 180);
            this.lbStandlargeur.Name = "lbStandlargeur";
            this.lbStandlargeur.Size = new System.Drawing.Size(43, 13);
            this.lbStandlargeur.TabIndex = 5;
            this.lbStandlargeur.Text = "Largeur";
            // 
            // lbStand
            // 
            this.lbStand.AutoSize = true;
            this.lbStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStand.Location = new System.Drawing.Point(25, 85);
            this.lbStand.Name = "lbStand";
            this.lbStand.Size = new System.Drawing.Size(56, 20);
            this.lbStand.TabIndex = 6;
            this.lbStand.Text = "Stand ";
            // 
            // Présentoir
            // 
            this.Présentoir.FormattingEnabled = true;
            this.Présentoir.Items.AddRange(new object[] {
            "Présentoir ",
            "Panneau d\'affichage ",
            "Table",
            "Chaise ",
            "Comptoir",
            "Alimentation éléctrique  "});
            this.Présentoir.Location = new System.Drawing.Point(229, 125);
            this.Présentoir.Name = "Présentoir";
            this.Présentoir.Size = new System.Drawing.Size(179, 184);
            this.Présentoir.TabIndex = 7;
            this.Présentoir.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des Equipements";
            // 
            // frmInscriptionLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Présentoir);
            this.Controls.Add(this.lbStand);
            this.Controls.Add(this.lbStandlargeur);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbStandLongueur);
            this.Controls.Add(this.label1);
            this.Name = "frmInscriptionLigues";
            this.Text = "Inscription ligues";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStandLongueur;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lbStandlargeur;
        private System.Windows.Forms.Label lbStand;
        private System.Windows.Forms.CheckedListBox Présentoir;
        private System.Windows.Forms.Label label2;
    }
}