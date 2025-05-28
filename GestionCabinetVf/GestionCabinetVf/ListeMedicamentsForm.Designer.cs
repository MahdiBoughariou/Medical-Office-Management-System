namespace GestionCabinetVf
{
    partial class ListeMedicamentsForm
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
            lblListeMedicaments = new Label();
            dgvMedicaments = new DataGridView();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            SuspendLayout();
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Location = new Point(42, 135);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(161, 20);
            lblRecherche.TabIndex = 0;
            lblRecherche.Text = "Chercher médicament :";
            lblRecherche.Click += lblRecherche_Click;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(344, 135);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(318, 27);
            txtRecherche.TabIndex = 1;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(834, 135);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(251, 29);
            btnRechercher.TabIndex = 2;
            btnRechercher.Text = "Chercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // lblListeMedicaments
            // 
            lblListeMedicaments.AutoSize = true;
            lblListeMedicaments.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListeMedicaments.ForeColor = SystemColors.MenuHighlight;
            lblListeMedicaments.Location = new Point(404, 46);
            lblListeMedicaments.Name = "lblListeMedicaments";
            lblListeMedicaments.Size = new Size(344, 38);
            lblListeMedicaments.TabIndex = 3;
            lblListeMedicaments.Text = "Liste des médicaments";
            lblListeMedicaments.Click += lblListeMedicaments_Click;
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Location = new Point(42, 191);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(1043, 188);
            dgvMedicaments.TabIndex = 4;
            dgvMedicaments.CellContentClick += dgvMedicaments_CellContentClick;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(42, 428);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(251, 29);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(834, 428);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(251, 29);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // ListeMedicamentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 503);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(dgvMedicaments);
            Controls.Add(lblListeMedicaments);
            Controls.Add(btnRechercher);
            Controls.Add(txtRecherche);
            Controls.Add(lblRecherche);
            Name = "ListeMedicamentsForm";
            Text = "ListeMedicamentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecherche;
        private TextBox txtRecherche;
        private Button btnRechercher;
        private Label lblListeMedicaments;
        private DataGridView dgvMedicaments;
        private Button btnModifier;
        private Button btnSupprimer;
    }
}