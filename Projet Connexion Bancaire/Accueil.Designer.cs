namespace ConnexionBancaire
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
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.buttonCreerCompte = new System.Windows.Forms.Button();
            this.buttonOperationDepot = new System.Windows.Forms.Button();
            this.buttonAfficherCompte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAfficherTous = new System.Windows.Forms.Button();
            this.buttonVirementUnCompte = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.Location = new System.Drawing.Point(29, 9);
            this.labelBienvenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Text = "Bienvenue " + nom + " " + prenom;
            this.labelBienvenue.Size = new System.Drawing.Size(0, 20);
            this.labelBienvenue.TabIndex = 0;
            // 
            // buttonCreerCompte
            // 
            this.buttonCreerCompte.Location = new System.Drawing.Point(33, 55);
            this.buttonCreerCompte.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreerCompte.Name = "buttonCreerCompte";
            this.buttonCreerCompte.Size = new System.Drawing.Size(143, 27);
            this.buttonCreerCompte.TabIndex = 1;
            this.buttonCreerCompte.Text = "Créer un comte";
            this.buttonCreerCompte.UseVisualStyleBackColor = true;
            // 
            // buttonOperationDepot
            // 
            this.buttonOperationDepot.Location = new System.Drawing.Point(305, 55);
            this.buttonOperationDepot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOperationDepot.Name = "buttonOperationDepot";
            this.buttonOperationDepot.Size = new System.Drawing.Size(154, 27);
            this.buttonOperationDepot.TabIndex = 2;
            this.buttonOperationDepot.Text = "Operation de dépôt";
            this.buttonOperationDepot.UseVisualStyleBackColor = true;
            // 
            // buttonAfficherCompte
            // 
            this.buttonAfficherCompte.Location = new System.Drawing.Point(32, 119);
            this.buttonAfficherCompte.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAfficherCompte.Name = "buttonAfficherCompte";
            this.buttonAfficherCompte.Size = new System.Drawing.Size(144, 27);
            this.buttonAfficherCompte.TabIndex = 3;
            this.buttonAfficherCompte.Text = "Afficher un compte";
            this.buttonAfficherCompte.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Opération de retrait";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAfficherTous
            // 
            this.buttonAfficherTous.Location = new System.Drawing.Point(26, 202);
            this.buttonAfficherTous.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAfficherTous.Name = "buttonAfficherTous";
            this.buttonAfficherTous.Size = new System.Drawing.Size(150, 28);
            this.buttonAfficherTous.TabIndex = 5;
            this.buttonAfficherTous.Text = "Afficher tous les compte";
            this.buttonAfficherTous.UseVisualStyleBackColor = true;
            // 
            // buttonVirementUnCompte
            // 
            this.buttonVirementUnCompte.Location = new System.Drawing.Point(301, 202);
            this.buttonVirementUnCompte.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVirementUnCompte.Name = "buttonVirementUnCompte";
            this.buttonVirementUnCompte.Size = new System.Drawing.Size(158, 28);
            this.buttonVirementUnCompte.TabIndex = 6;
            this.buttonVirementUnCompte.Text = "Virement vers un compte";
            this.buttonVirementUnCompte.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(202, 289);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(82, 30);
            this.buttonQuitter.TabIndex = 7;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 353);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonVirementUnCompte);
            this.Controls.Add(this.buttonAfficherTous);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAfficherCompte);
            this.Controls.Add(this.buttonOperationDepot);
            this.Controls.Add(this.buttonCreerCompte);
            this.Controls.Add(this.labelBienvenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Accueil";
            this.Text = "Gestion Bancaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Button buttonCreerCompte;
        private System.Windows.Forms.Button buttonOperationDepot;
        private System.Windows.Forms.Button buttonAfficherCompte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAfficherTous;
        private System.Windows.Forms.Button buttonVirementUnCompte;
        private System.Windows.Forms.Button buttonQuitter;
    }
}

