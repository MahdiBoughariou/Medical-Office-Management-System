namespace GestionCabinetVf
{
    partial class SecretaireDashboard
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
            lblBienvenue = new Label();
            lblGestion = new Label();
            btnAjouterPatient = new Button();
            btnVoirPatients = new Button();
            btnVoirRdvs = new Button();
            btnDeconnexion = new Button();
            SuspendLayout();
            // 
            // lblBienvenue
            // 
            lblBienvenue.AutoSize = true;
            lblBienvenue.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenue.ForeColor = SystemColors.MenuHighlight;
            lblBienvenue.Location = new Point(390, 45);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(351, 38);
            lblBienvenue.TabIndex = 0;
            lblBienvenue.Text = "Bienvenue, Secrétaire !";
            lblBienvenue.Click += lblBienvenue_Click;
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblGestion.Location = new Point(390, 191);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(358, 32);
            lblGestion.TabIndex = 1;
            lblGestion.Text = "Gestion patient et rendez-vous";
            lblGestion.Click += lblGestion_Click;
            // 
            // btnAjouterPatient
            // 
            btnAjouterPatient.Location = new Point(390, 299);
            btnAjouterPatient.Name = "btnAjouterPatient";
            btnAjouterPatient.Size = new Size(351, 29);
            btnAjouterPatient.TabIndex = 2;
            btnAjouterPatient.Text = "Ajouter Patient";
            btnAjouterPatient.UseVisualStyleBackColor = true;
            btnAjouterPatient.Click += btnAjouterPatient_Click;
            // 
            // btnVoirPatients
            // 
            btnVoirPatients.Location = new Point(390, 359);
            btnVoirPatients.Name = "btnVoirPatients";
            btnVoirPatients.Size = new Size(351, 29);
            btnVoirPatients.TabIndex = 3;
            btnVoirPatients.Text = "Liste des patients";
            btnVoirPatients.UseVisualStyleBackColor = true;
            btnVoirPatients.Click += btnVoirPatients_Click;
            // 
            // btnVoirRdvs
            // 
            btnVoirRdvs.Location = new Point(390, 416);
            btnVoirRdvs.Name = "btnVoirRdvs";
            btnVoirRdvs.Size = new Size(351, 29);
            btnVoirRdvs.TabIndex = 4;
            btnVoirRdvs.Text = "Liste des rendez-vous";
            btnVoirRdvs.UseVisualStyleBackColor = true;
            btnVoirRdvs.Click += btnVoirRdvs_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.Red;
            btnDeconnexion.Location = new Point(1003, 517);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(117, 29);
            btnDeconnexion.TabIndex = 5;
            btnDeconnexion.TabStop = false;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // SecretaireDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 558);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnVoirRdvs);
            Controls.Add(btnVoirPatients);
            Controls.Add(btnAjouterPatient);
            Controls.Add(lblGestion);
            Controls.Add(lblBienvenue);
            Name = "SecretaireDashboard";
            Text = "SecretaireDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenue;
        private Label lblGestion;
        private Button btnAjouterPatient;
        private Button btnVoirPatients;
        private Button btnVoirRdvs;
        private Button btnDeconnexion;
    }
}