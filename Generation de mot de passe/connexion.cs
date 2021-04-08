using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generation_de_mot_de_passe
{
    public partial class connexion : Form
    {

        static string Cryptage(string saisie)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(saisie));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public connexion()
        {
            InitializeComponent();
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_motdepasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_identifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_connect_Click(object sender, EventArgs e)

        {
            string pseudo = tb_identifiant.Text;
            string mdp = tb_motdepasse.Text;
            //var message = Encoding.ASCII.GetBytes(mdp);
            //SHA256Managed hashString = new SHA256Managed();
            //string hex = "";
            //var hashValue = hashString.ComputeHash(message);
            //foreach (byte x in hashValue)
            //{
            //    hex += string.Format("{0:x2}", x);
            //}
            Cryptage(mdp);
            MySqlConnection cnx = new MySqlConnection("server=localhost;uid=root;database=basemdp;port=3306;pwd=siojjr");
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from utilisateurs where motDePasse = @password",cnx);
            //cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = pseudo;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = mdp;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[2].ToString() == mdp && (rdr[1].ToString() == pseudo))
                {
                    MessageBox.Show("Connexion Réussie");
                    return;
                }
            }
            MessageBox.Show("Connexion échouée");
            tb_motdepasse.Text = "";
            tb_identifiant.Text = "";
            return;
            cnx.Close();
        }
    }
}
