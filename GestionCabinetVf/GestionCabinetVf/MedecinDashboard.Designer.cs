namespace GestionCabinetVf
{
    partial class MedecinDashboard
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
            lblGestionPatient = new Label();
            btnAjouterPatient = new Button();
            btnVoirPatients = new Button();
            lblGestionMedicament = new Label();
            btnAjouterMedicament = new Button();
            btnVoirMedicaments = new Button();
            lblGestionConsultation = new Label();
            btnCreerConsultation = new Button();
            btnVoirConsultations = new Button();
            btnVoirRdvs = new Button();
            btnDeconnexion = new Button();
            SuspendLayout();
            // 
            // lblBienvenue
            // 
            lblBienvenue.AutoSize = true;
            lblBienvenue.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenue.ForeColor = SystemColors.MenuHighlight;
            lblBienvenue.Location = new Point(387, 39);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(322, 38);
            lblBienvenue.TabIndex = 0;
            lblBienvenue.Text = "Bienvenue, Docteur !";
            lblBienvenue.Click += lblBienvenue_Click;
            // 
            // lblGestionPatient
            // 
            lblGestionPatient.AutoSize = true;
            lblGestionPatient.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGestionPatient.Location = new Point(65, 187);
            lblGestionPatient.Name = "lblGestionPatient";
            lblGestionPatient.Size = new Size(188, 32);
            lblGestionPatient.TabIndex = 1;
            lblGestionPatient.Text = "Gestion patient";
            lblGestionPatient.Click += lblGestionPatient_Click;
            // 
            // btnAjouterPatient
            // 
            btnAjouterPatient.Location = new Point(65, 257);
            btnAjouterPatient.Name = "btnAjouterPatient";
            btnAjouterPatient.Size = new Size(246, 29);
            btnAjouterPatient.TabIndex = 2;
            btnAjouterPatient.Text = "Ajouter patient";
            btnAjouterPatient.UseVisualStyleBackColor = true;
            btnAjouterPatient.Click += btnAjouterPatient_Click;
            // 
            // btnVoirPatients
            // 
            btnVoirPatients.Location = new Point(65, 308);
            btnVoirPatients.Name = "btnVoirPatients";
            btnVoirPatients.Size = new Size(246, 29);
            btnVoirPatients.TabIndex = 3;
            btnVoirPatients.Text = "Voir liste des patients";
            btnVoirPatients.UseVisualStyleBackColor = true;
            btnVoirPatients.Click += btnVoirPatients_Click;
            // 
            // lblGestionMedicament
            // 
            lblGestionMedicament.AutoSize = true;
            lblGestionMedicament.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGestionMedicament.Location = new Point(414, 187);
            lblGestionMedicament.Name = "lblGestionMedicament";
            lblGestionMedicament.Size = new Size(246, 32);
            lblGestionMedicament.TabIndex = 4;
            lblGestionMedicament.Text = "Gestion médicament";
            lblGestionMedicament.Click += lblGestionMedicament_Click;
            // 
            // btnAjouterMedicament
            // 
            btnAjouterMedicament.Location = new Point(414, 257);
            btnAjouterMedicament.Name = "btnAjouterMedicament";
            btnAjouterMedicament.Size = new Size(246, 29);
            btnAjouterMedicament.TabIndex = 5;
            btnAjouterMedicament.Text = "Ajouter médicament";
            btnAjouterMedicament.UseVisualStyleBackColor = true;
            btnAjouterMedicament.Click += btnAjouterMedicament_Click;
            // 
            // btnVoirMedicaments
            // 
            btnVoirMedicaments.Location = new Point(414, 308);
            btnVoirMedicaments.Name = "btnVoirMedicaments";
            btnVoirMedicaments.Size = new Size(246, 29);
            btnVoirMedicaments.TabIndex = 6;
            btnVoirMedicaments.Text = "Voir liste des médicaments";
            btnVoirMedicaments.UseVisualStyleBackColor = true;
            btnVoirMedicaments.Click += btnVoirMedicaments_Click;
            // 
            // lblGestionConsultation
            // 
            lblGestionConsultation.AutoSize = true;
            lblGestionConsultation.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGestionConsultation.Location = new Point(817, 187);
            lblGestionConsultation.Name = "lblGestionConsultation";
            lblGestionConsultation.Size = new Size(251, 32);
            lblGestionConsultation.TabIndex = 7;
            lblGestionConsultation.Text = "Gestion consultation";
            lblGestionConsultation.Click += lblGestionConsultation_Click;
            // 
            // btnCreerConsultation
            // 
            btnCreerConsultation.Location = new Point(817, 257);
            btnCreerConsultation.Name = "btnCreerConsultation";
            btnCreerConsultation.Size = new Size(246, 29);
            btnCreerConsultation.TabIndex = 8;
            btnCreerConsultation.Text = "Créer Consultation";
            btnCreerConsultation.UseVisualStyleBackColor = true;
            btnCreerConsultation.Click += btnCreerConsultation_Click;
            // 
            // btnVoirConsultations
            // 
            btnVoirConsultations.Location = new Point(817, 308);
            btnVoirConsultations.Name = "btnVoirConsultations";
            btnVoirConsultations.Size = new Size(246, 29);
            btnVoirConsultations.TabIndex = 9;
            btnVoirConsultations.Text = "Voir liste des consultations";
            btnVoirConsultations.UseVisualStyleBackColor = true;
            btnVoirConsultations.Click += btnVoirConsultations_Click;
            // 
            // btnVoirRdvs
            // 
            btnVoirRdvs.Location = new Point(65, 360);
            btnVoirRdvs.Name = "btnVoirRdvs";
            btnVoirRdvs.Size = new Size(246, 29);
            btnVoirRdvs.TabIndex = 10;
            btnVoirRdvs.Text = "Voir liste des rendez-vous";
            btnVoirRdvs.UseVisualStyleBackColor = true;
            btnVoirRdvs.Click += btnVoirRdvs_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.Red;
            btnDeconnexion.Location = new Point(1013, 461);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(117, 29);
            btnDeconnexion.TabIndex = 11;
            btnDeconnexion.TabStop = false;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // MedecinDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 502);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnVoirRdvs);
            Controls.Add(btnVoirConsultations);
            Controls.Add(btnCreerConsultation);
            Controls.Add(lblGestionConsultation);
            Controls.Add(btnVoirMedicaments);
            Controls.Add(btnAjouterMedicament);
            Controls.Add(lblGestionMedicament);
            Controls.Add(btnVoirPatients);
            Controls.Add(btnAjouterPatient);
            Controls.Add(lblGestionPatient);
            Controls.Add(lblBienvenue);
            Name = "MedecinDashboard";
            Text = "MedecinDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenue;
        private Label lblGestionPatient;
        private Button btnAjouterPatient;
        private Button btnVoirPatients;
        private Label lblGestionMedicament;
        private Button btnAjouterMedicament;
        private Button btnVoirMedicaments;
        private Label lblGestionConsultation;
        private Button btnCreerConsultation;
        private Button btnVoirConsultations;
        private Button btnVoirRdvs;
        private Button btnDeconnexion;
    }
}