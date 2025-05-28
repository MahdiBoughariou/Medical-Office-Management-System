namespace GestionCabinetVf
{
    partial class ListeConsultationsForm
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
            lblListeConsultations = new Label();
            lblRecherche = new Label();
            txtRechercher = new TextBox();
            btnRechercher = new Button();
            dgvConsultations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).BeginInit();
            SuspendLayout();
            // 
            // lblListeConsultations
            // 
            lblListeConsultations.AutoSize = true;
            lblListeConsultations.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListeConsultations.ForeColor = SystemColors.MenuHighlight;
            lblListeConsultations.Location = new Point(376, 42);
            lblListeConsultations.Name = "lblListeConsultations";
            lblListeConsultations.Size = new Size(352, 38);
            lblListeConsultations.TabIndex = 0;
            lblListeConsultations.Text = "Liste des Consultations";
            lblListeConsultations.Click += lblListeConsultations_Click;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Location = new Point(48, 125);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(291, 20);
            lblRecherche.TabIndex = 1;
            lblRecherche.Text = "Chercher consultation par nom du patient :";
            lblRecherche.Click += lblRecherche_Click;
            // 
            // txtRechercher
            // 
            txtRechercher.Location = new Point(436, 121);
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(292, 27);
            txtRechercher.TabIndex = 2;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(856, 121);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(229, 29);
            btnRechercher.TabIndex = 3;
            btnRechercher.Text = "Chercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // dgvConsultations
            // 
            dgvConsultations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultations.Location = new Point(48, 177);
            dgvConsultations.Name = "dgvConsultations";
            dgvConsultations.RowHeadersWidth = 51;
            dgvConsultations.Size = new Size(1037, 282);
            dgvConsultations.TabIndex = 4;
            dgvConsultations.CellContentClick += dgvConsultations_CellContentClick;
            // 
            // ListeConsultationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 503);
            Controls.Add(dgvConsultations);
            Controls.Add(btnRechercher);
            Controls.Add(txtRechercher);
            Controls.Add(lblRecherche);
            Controls.Add(lblListeConsultations);
            Name = "ListeConsultationsForm";
            Text = "ListeConsultationsForm";
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListeConsultations;
        private Label lblRecherche;
        private TextBox txtRechercher;
        private Button btnRechercher;
        private DataGridView dgvConsultations;
    }
}