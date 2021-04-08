namespace Generation_de_mot_de_passe
{
    partial class inscription
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_confirmation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_inscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSCRIPTION ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PSEUDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MOT DE PASSE";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(130, 112);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(135, 20);
            this.tb_id.TabIndex = 3;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(130, 157);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(135, 20);
            this.tb_mdp.TabIndex = 4;
            this.tb_mdp.UseSystemPasswordChar = true;
            // 
            // tb_confirmation
            // 
            this.tb_confirmation.Location = new System.Drawing.Point(130, 196);
            this.tb_confirmation.Name = "tb_confirmation";
            this.tb_confirmation.Size = new System.Drawing.Size(135, 20);
            this.tb_confirmation.TabIndex = 6;
            this.tb_confirmation.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmation MDP";
            // 
            // bt_inscription
            // 
            this.bt_inscription.Location = new System.Drawing.Point(87, 253);
            this.bt_inscription.Name = "bt_inscription";
            this.bt_inscription.Size = new System.Drawing.Size(170, 43);
            this.bt_inscription.TabIndex = 7;
            this.bt_inscription.Text = "S\'inscrire";
            this.bt_inscription.UseVisualStyleBackColor = true;
            this.bt_inscription.Click += new System.EventHandler(this.bt_inscription_Click);
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 320);
            this.Controls.Add(this.bt_inscription);
            this.Controls.Add(this.tb_confirmation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inscription";
            this.Text = "inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_confirmation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_inscription;
    }
}