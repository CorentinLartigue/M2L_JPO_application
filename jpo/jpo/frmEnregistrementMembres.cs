using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpo
{
    public partial class frmEnregistrementMembres : Form
    {
        public frmEnregistrementMembres()
        {
            InitializeComponent();
        }

        private void frmEnregistrementMembres_Load(object sender, EventArgs e)
        {
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }
            OleDbDataReader drLigues = DbConnex.GetDataReader("select * from LIGUES ");
            while (drLigues.Read())
            {
                cbxLigue.Items.Add(drLigues.GetValue(1).ToString());
            }
            DbConnex.connexionClose();
        }

        private void tbxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lbxMembres.Items.Add(lblNom.Text);
        }

        private void cbxLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxMembres.Items.Clear();
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }
            OleDbDataReader drMembres = DbConnex.GetDataReader("select * from membre");
            OleDbDataReader drLigues = DbConnex.GetDataReader("select * from LIGUES ");
            while (drLigues.Read())
            {
                while (drMembres.Read())
                {
                    if (drLigues.GetString(0) == drMembres.GetString(5))
                    {
                        lbxMembres.Items.Add(drMembres.GetString(1));
                    }
                }
            }
            DbConnex.connexionClose();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void lbxMembres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}