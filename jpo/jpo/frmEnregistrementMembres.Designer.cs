
namespace jpo
{
    partial class frmEnregistrementMembres
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lbxMembres = new System.Windows.Forms.ListBox();
            this.cbxLigue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enregistrement membres";
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAjouter.Location = new System.Drawing.Point(269, 323);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 56);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(526, 323);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 56);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(395, 323);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 56);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(382, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(382, 233);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(31, 15);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(382, 198);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(66, 15);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "Téléphone";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(382, 156);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(51, 15);
            this.lblPrenom.TabIndex = 9;
            this.lblPrenom.Text = "Prénom";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(469, 115);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(120, 20);
            this.tbxNom.TabIndex = 10;
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(469, 233);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(120, 20);
            this.tbxMail.TabIndex = 13;
            this.tbxMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMail_KeyPress);
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(469, 198);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(120, 20);
            this.tbxTelephone.TabIndex = 14;
            this.tbxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTelephone_KeyPress);
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(469, 156);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(120, 20);
            this.tbxPrenom.TabIndex = 15;
            this.tbxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrenom_KeyPress);
            // 
            // lbxMembres
            // 
            this.lbxMembres.FormattingEnabled = true;
            this.lbxMembres.Location = new System.Drawing.Point(43, 118);
            this.lbxMembres.Name = "lbxMembres";
            this.lbxMembres.Size = new System.Drawing.Size(208, 173);
            this.lbxMembres.TabIndex = 16;
            this.lbxMembres.SelectedIndexChanged += new System.EventHandler(this.lbxMembres_SelectedIndexChanged);
            // 
            // cbxLigue
            // 
            this.cbxLigue.FormattingEnabled = true;
            this.cbxLigue.Location = new System.Drawing.Point(43, 72);
            this.cbxLigue.Name = "cbxLigue";
            this.cbxLigue.Size = new System.Drawing.Size(208, 21);
            this.cbxLigue.TabIndex = 17;
            this.cbxLigue.SelectedIndexChanged += new System.EventHandler(this.cbxLigue_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ligue";
            // 
            // frmEnregistrementMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxLigue);
            this.Controls.Add(this.lbxMembres);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmEnregistrementMembres";
            this.Text = "Enregistrement membres";
            this.Load += new System.EventHandler(this.frmEnregistrementMembres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.ListBox lbxMembres;
        private System.Windows.Forms.ComboBox cbxLigue;
        private System.Windows.Forms.Label label2;
    }
}