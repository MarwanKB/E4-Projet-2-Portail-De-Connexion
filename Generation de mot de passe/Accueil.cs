using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generation_de_mot_de_passe
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connexion Connect = new connexion();
            Connect.ShowDialog(this);
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {
            inscription inscrit = new inscription();
            inscrit.ShowDialog(this);
        }
    }
}
