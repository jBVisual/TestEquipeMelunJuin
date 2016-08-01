using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnexionBancaire
{
    public partial class Login : Form
    {
        private string loginTextBox;
        private string passwordTextBox;
        private string login;
        private string nom;
        private string prenom;
        private string nomBD;
        private string prenomBD;
        private string loginBD;
        private string passwordBD;
        private bool ok;

        public Login()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            loginTextBox = textBoxLogin.Text;
            passwordTextBox = textBoxPass.Text;

            if (loginTextBox == "" && passwordTextBox == "")
            {
                MessageBox.Show("Entrez votre login et password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (loginTextBox == "")
            {
                MessageBox.Show("Entrez votre login aussi !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (passwordTextBox == "")
            {
                MessageBox.Show("Entrez votre password aussi !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                //On affecte l'endroit ou se trouve le DB dans chaineConnexion
                string chaineConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MOI\DOCUMENTS\IDENTIFIANTBANCAIRE.MDF;Integrated Security=True;Connect Timeout=30";

                //On crée une nouvelle connexion "con" à partir de SqlConnection 
                //en donnant en argument chaineConnexion, 
                //c'est à dire l'emplacement de la BD
                using (SqlConnection con = new SqlConnection(chaineConnexion))
                //con.Dispose();
                {
                    //Ouvre la connexion
                    //con.Open();
                    try
                    {
                        con.Open();
                        //On crée une requete nécessaire pour ensuite crée une SqlCommand
                        string maRequette = "SELECT * FROM TabLogin;";

                        //On crée une SqlCommand grâce à la connexion "con" et la requete "maRequete"
                        using (SqlCommand maCommande = new SqlCommand(maRequette, con))
                        {
                            //On affecte la commande sql crée à un objet SqlDataReader
                            SqlDataReader maLecture = maCommande.ExecuteReader();

                            //Boucle qui va permettre de lire l'objet SqlDataReader
                            //tant que la BD n'est pas vide/terminé
                            while (maLecture.Read())
                            {
                                loginBD = (string)maLecture["Login"];

                                passwordBD = (string)maLecture["Password"];
                                nomBD = (string)maLecture["Nom"];
                                prenomBD = (string)maLecture["Prenom"];

                                if(loginTextBox == loginBD && passwordTextBox == passwordBD)
                                {
                                    ok = true;
                                    login = loginBD;
                                    nom = nomBD;
                                    prenom = prenomBD;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error message :" + ex.Message);
                    }
                    con.Close();
                    if (ok)
                    {
                        Accueil accueil = new Accueil(login, nom, prenom);
                        accueil.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password ou Login incorrects !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }          
            }
        }
    }
}
