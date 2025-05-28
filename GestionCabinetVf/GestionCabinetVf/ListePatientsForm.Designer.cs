namespace GestionCabinetVf
{
    partial class ListePatientsForm
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
            lblRecherche = new Label();
            txtRecherche = new TextBox();
            btnRechercher = new Button();
            lblListePatients = new Label();
            dgvPatients = new DataGridView();
            btnModifierPatient = new Button();
            btnSupprimerPatient = new Button();
            btnRdv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Location = new Point(50, 139);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(268, 20);
            lblRecherche.TabIndex = 0;
            lblRecherche.Text = "Chercher patient par (nom/téléphone) :";
            lblRecherche.Click += lblRecherche_Click;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(429, 139);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(269, 27);
            txtRecherche.TabIndex = 1;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(838, 139);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(267, 29);
            btnRechercher.TabIndex = 2;
            btnRechercher.Text = "Chercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // lblListePatients
            // 
            lblListePatients.AutoSize = true;
            lblListePatients.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListePatients.ForeColor = SystemColors.MenuHighlight;
            lblListePatients.Location = new Point(430, 45);
            lblListePatients.Name = "lblListePatients";
            lblListePatients.Size = new Size(267, 38);
            lblListePatients.TabIndex = 3;
            lblListePatients.Text = "Liste des patients";
            lblListePatients.Click += lblListePatients_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(50, 186);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(1055, 188);
            dgvPatients.TabIndex = 4;
            dgvPatients.CellContentClick += dgvPatients_CellContentClick;
            // 
            // btnModifierPatient
            // 
            btnModifierPatient.Location = new Point(50, 410);
            btnModifierPatient.Name = "btnModifierPatient";
            btnModifierPatient.Size = new Size(267, 29);
            btnModifierPatient.TabIndex = 5;
            btnModifierPatient.Text = "Modifier";
            btnModifierPatient.UseVisualStyleBackColor = true;
            btnModifierPatient.Click += btnModifierPatient_Click;
            // 
            // btnSupprimerPatient
            // 
            btnSupprimerPatient.Location = new Point(429, 410);
            btnSupprimerPatient.Name = "btnSupprimerPatient";
            btnSupprimerPatient.Size = new Size(267, 29);
            btnSupprimerPatient.TabIndex = 6;
            btnSupprimerPatient.Text = "Supprimer";
            btnSupprimerPatient.UseVisualStyleBackColor = true;
            btnSupprimerPatient.Click += btnSupprimerPatient_Click;
            // 
            // btnRdv
            // 
            btnRdv.Location = new Point(838, 410);
            btnRdv.Name = "btnRdv";
            btnRdv.Size = new Size(267, 29);
            btnRdv.TabIndex = 7;
            btnRdv.Text = "Rendez-vous";
            btnRdv.UseVisualStyleBackColor = true;
            btnRdv.Click += btnRdv_Click;
            // 
            // ListePatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 503);
            Controls.Add(btnRdv);
            Controls.Add(btnSupprimerPatient);
            Controls.Add(btnModifierPatient);
            Controls.Add(dgvPatients);
            Controls.Add(lblListePatients);
            Controls.Add(btnRechercher);
            Controls.Add(txtRecherche);
            Controls.Add(lblRecherche);
            Name = "ListePatientsForm";
            Text = "ListePatientsForm";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecherche;
        private TextBox txtRecherche;
        private Button btnRechercher;
        private Label lblListePatients;
        private DataGridView dgvPatients;
        private Button btnModifierPatient;
        private Button btnSupprimerPatient;
        private Button btnRdv;
    }
}