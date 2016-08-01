using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConnexionBancaire
{
    public partial class Accueil : Form
    {
        private string id;
        private string nom =" ";
        private string prenom =" ";


        public Accueil(string id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            InitializeComponent();
            
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

