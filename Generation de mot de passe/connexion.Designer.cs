namespace Generation_de_mot_de_passe
{
    partial class connexion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.tb_motdepasse = new System.Windows.Forms.TextBox();
            this.bt_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrer vos identifiants :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identifiant";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot De Passe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(103, 129);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(100, 20);
            this.tb_identifiant.TabIndex = 3;
            this.tb_identifiant.TextChanged += new System.EventHandler(this.tb_identifiant_TextChanged);
            // 
            // tb_motdepasse
            // 
            this.tb_motdepasse.Location = new System.Drawing.Point(103, 180);
            this.tb_motdepasse.Name = "tb_motdepasse";
            this.tb_motdepasse.Size = new System.Drawing.Size(100, 20);
            this.tb_motdepasse.TabIndex = 4;
            this.tb_motdepasse.UseSystemPasswordChar = true;
            this.tb_motdepasse.TextChanged += new System.EventHandler(this.tb_motdepasse_TextChanged);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(90, 236);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(124, 34);
            this.bt_connect.TabIndex = 5;
            this.bt_connect.Text = "Connexion";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 282);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.tb_motdepasse);
            this.Controls.Add(this.tb_identifiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "connexion";
            this.Text = "connexion";
            this.Load += new System.EventHandler(this.connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.TextBox tb_motdepasse;
        private System.Windows.Forms.Button bt_connect;
    }
}