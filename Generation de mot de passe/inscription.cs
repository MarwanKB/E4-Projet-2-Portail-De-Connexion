using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generation_de_mot_de_passe
{
    public partial class inscription : Form
    {
        public inscription()
        {
            InitializeComponent();
        }

        private void bt_inscription_Click(object sender, EventArgs e)
        {

            string pseudo = tb_id.Text;
            string mdp = tb_mdp.Text;
            var message = Encoding.ASCII.GetBytes(mdp);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += string.Format("{0:x2}", x);
            }
            
            if (tb_mdp.Text == tb_confirmation.Text)
            {
                MySqlConnection cnx = new MySqlConnection("server=localhost;uid=root;database=basemdp;port=3306;pwd=siojjr");
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO utilisateurs (pseudo, motDePasse) VALUES (@pseudo, @mdp) ", cnx);
                cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = pseudo;
                cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = message;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inscription Réussie");
                return;
                cnx.Close();
            }
            MessageBox.Show("Les mots de passes ne sont pas identiques");
            tb_id.Text = "";
            tb_mdp.Text = ""; 
            tb_confirmation.Text = "";
            return;
        }

        
    }
}
