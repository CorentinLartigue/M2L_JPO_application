using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jpo
{
    public partial class frmEnregistrementLigues : Form
    {

        public frmEnregistrementLigues()
        {
            InitializeComponent();

        }

        private void frmEnregistrementLigues_Load(object sender, EventArgs e)
        {
            /*
            // TODO: cette ligne de code charge les données dans la table 'jpoDataSet.LIGUES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            OleDbCommand uneCommande2 = new OleDbCommand("select nomLigue from LIGUES");
            this.lIGUESTableAdapter.Fill(this.jpoDataSet.LIGUES);
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                /*DbConnex.connexionBase();
            }
            OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");
            while (drLigues.Read())
            {
                MessageBox.Show(drLigues.GetString(1));
            }
            DbConnex.connexionClose();
            */

            tbxNom.MaxLength = 30;
            tbxCP.MaxLength = 5;
            tbxVille.MaxLength = 30;
            tbxAddr.MaxLength = 30;
            tbxDis.MaxLength = 30;

            
        }


        #region Keypress
        private void tbxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void tbxCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
        private void tbxVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void tbxDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        #endregion




        private void btnAjout_Validating(object sender, CancelEventArgs e)
        {
            
            try{
                //connexion à la base de données
                OleDbConnection uneConnexion2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=F:\BTS SIO\Première Année\AP 2022-2023\AP 2.2 - M2L JPO\ap-2.2-m2l-jpo\jpo\jpo.accdb");
                OleDbCommand uneCommande2 = new OleDbCommand("select * from LIGUES");
                uneCommande2.Connection = uneConnexion2;
                this.lIGUESTableAdapter.Fill(this.jpoDataSet.LIGUES);
                uneConnexion2.Open();
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");
                while (drLigues.Read())
                {

                    lboxInscrit.Items.Add(drLigues.GetString(1));
                    tbxCP.Text = drLigues.GetString(3);
                    tbxVille.Text = drLigues.GetString(4);
                    tbxDis.Text = drLigues.GetString(5);
                    
                }
                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            

        }
        private void lboxInscrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxInscrit.SelectedIndex != -1)
            {
                // Récupérer le nom sélectionné dans la ListBox
                string nomSelectionne = lboxInscrit.SelectedItem.ToString();
                // Afficher le nom dans le TextBox
                tbxNom.Text = nomSelectionne;
             
            }
        }
    }
}
