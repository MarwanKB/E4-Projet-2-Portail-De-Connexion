namespace Generation_de_mot_de_passe
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_connexion = new System.Windows.Forms.Button();
            this.bt_creer = new System.Windows.Forms.Button();
            this.lb_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_connexion
            // 
            this.bt_connexion.Location = new System.Drawing.Point(89, 89);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(206, 57);
            this.bt_connexion.TabIndex = 0;
            this.bt_connexion.Text = "Connexion";
            this.bt_connexion.UseVisualStyleBackColor = true;
            this.bt_connexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_creer
            // 
            this.bt_creer.Location = new System.Drawing.Point(89, 184);
            this.bt_creer.Name = "bt_creer";
            this.bt_creer.Size = new System.Drawing.Size(206, 57);
            this.bt_creer.TabIndex = 1;
            this.bt_creer.Text = "Créer un compte";
            this.bt_creer.UseVisualStyleBackColor = true;
            this.bt_creer.Click += new System.EventHandler(this.bt_creer_Click);
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(40, 35);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(302, 21);
            this.lb_titre.TabIndex = 2;
            this.lb_titre.Text = "Bienvenue sur le portail d\'authentificaiton ";
            this.lb_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 296);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.bt_creer);
            this.Controls.Add(this.bt_connexion);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.Button bt_creer;
        private System.Windows.Forms.Label lb_titre;
    }
}

