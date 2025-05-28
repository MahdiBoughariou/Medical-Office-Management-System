namespace GestionCabinetVf
{
    partial class ListeRdvsForm
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
            lblListeRdvs = new Label();
            lblRecherche = new Label();
            txtRecherche = new TextBox();
            btnRechercher = new Button();
            dgvListeRdvs = new DataGridView();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListeRdvs).BeginInit();
            SuspendLayout();
            // 
            // lblListeRdvs
            // 
            lblListeRdvs.AutoSize = true;
            lblListeRdvs.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListeRdvs.ForeColor = SystemColors.MenuHighlight;
            lblListeRdvs.Location = new Point(389, 40);
            lblListeRdvs.Name = "lblListeRdvs";
            lblListeRdvs.Size = new Size(326, 38);
            lblListeRdvs.TabIndex = 0;
            lblListeRdvs.Text = "Liste des rendez-vous";
            lblListeRdvs.Click += lblListeRdvs_Click;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Location = new Point(142, 151);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(284, 20);
            lblRecherche.TabIndex = 1;
            lblRecherche.Text = "Chercher rendez-vous par (nom ou date) :";
            lblRecherche.Click += lblRecherche_Click;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(476, 151);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(239, 27);
            txtRecherche.TabIndex = 2;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(777, 151);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(142, 29);
            btnRechercher.TabIndex = 3;
            btnRechercher.Text = "Chercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // dgvListeRdvs
            // 
            dgvListeRdvs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListeRdvs.Location = new Point(142, 212);
            dgvListeRdvs.Name = "dgvListeRdvs";
            dgvListeRdvs.RowHeadersWidth = 51;
            dgvListeRdvs.Size = new Size(777, 188);
            dgvListeRdvs.TabIndex = 4;
            dgvListeRdvs.CellContentClick += dgvListeRdvs_CellContentClick;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(142, 436);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(243, 29);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifer";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(676, 436);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(243, 29);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // ListeRdvsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 506);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(dgvListeRdvs);
            Controls.Add(btnRechercher);
            Controls.Add(txtRecherche);
            Controls.Add(lblRecherche);
            Controls.Add(lblListeRdvs);
            Name = "ListeRdvsForm";
            Text = "ListeRdvsForm";
            ((System.ComponentModel.ISupportInitialize)dgvListeRdvs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListeRdvs;
        private Label lblRecherche;
        private TextBox txtRecherche;
        private Button btnRechercher;
        private DataGridView dgvListeRdvs;
        private Button btnModifier;
        private Button btnSupprimer;
    }
}