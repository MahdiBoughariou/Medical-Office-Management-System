namespace GestionCabinetVf
{
    partial class AjouterOrdonnanceForm
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
            label1 = new Label();
            lblRecherche = new Label();
            txtRecherche = new TextBox();
            btnRechercher = new Button();
            dgvMedicaments = new DataGridView();
            lblDose = new Label();
            txtDose = new TextBox();
            btnAjouterMedicament = new Button();
            lstMedicamentsAjoutes = new ListBox();
            btnEnregistrerOrdonnance = new Button();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(428, 42);
            label1.Name = "label1";
            label1.Size = new Size(344, 38);
            label1.TabIndex = 0;
            label1.Text = "Créer une ordonnance";
            label1.Click += label1_Click;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.ForeColor = Color.Black;
            lblRecherche.Location = new Point(49, 121);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(161, 20);
            lblRecherche.TabIndex = 1;
            lblRecherche.Text = "Chercher médicament :";
            lblRecherche.Click += lblRecherche_Click;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(243, 121);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(227, 27);
            txtRecherche.TabIndex = 2;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // btnRechercher
            // 
            btnRechercher.ForeColor = Color.Black;
            btnRechercher.Location = new Point(511, 121);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(152, 29);
            btnRechercher.TabIndex = 3;
            btnRechercher.Text = "Chercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Location = new Point(49, 172);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(614, 188);
            dgvMedicaments.TabIndex = 4;
            dgvMedicaments.CellContentClick += dgvMedicaments_CellContentClick;
            // 
            // lblDose
            // 
            lblDose.AutoSize = true;
            lblDose.Location = new Point(49, 401);
            lblDose.Name = "lblDose";
            lblDose.Size = new Size(102, 20);
            lblDose.TabIndex = 5;
            lblDose.Text = "Dose par jour:";
            lblDose.Click += lblDose_Click;
            // 
            // txtDose
            // 
            txtDose.Location = new Point(243, 401);
            txtDose.Name = "txtDose";
            txtDose.Size = new Size(227, 27);
            txtDose.TabIndex = 6;
            txtDose.TextChanged += txtDose_TextChanged;
            // 
            // btnAjouterMedicament
            // 
            btnAjouterMedicament.Location = new Point(511, 401);
            btnAjouterMedicament.Name = "btnAjouterMedicament";
            btnAjouterMedicament.Size = new Size(152, 29);
            btnAjouterMedicament.TabIndex = 7;
            btnAjouterMedicament.Text = "Ajouter au panier";
            btnAjouterMedicament.UseVisualStyleBackColor = true;
            btnAjouterMedicament.Click += btnAjouterMedicament_Click;
            // 
            // lstMedicamentsAjoutes
            // 
            lstMedicamentsAjoutes.FormattingEnabled = true;
            lstMedicamentsAjoutes.Location = new Point(815, 172);
            lstMedicamentsAjoutes.Name = "lstMedicamentsAjoutes";
            lstMedicamentsAjoutes.Size = new Size(189, 184);
            lstMedicamentsAjoutes.TabIndex = 8;
            lstMedicamentsAjoutes.SelectedIndexChanged += lstMedicamentsAjoutes_SelectedIndexChanged;
            // 
            // btnEnregistrerOrdonnance
            // 
            btnEnregistrerOrdonnance.Location = new Point(815, 401);
            btnEnregistrerOrdonnance.Name = "btnEnregistrerOrdonnance";
            btnEnregistrerOrdonnance.Size = new Size(189, 29);
            btnEnregistrerOrdonnance.TabIndex = 9;
            btnEnregistrerOrdonnance.Text = "Enregistrer l'ordonnance";
            btnEnregistrerOrdonnance.UseVisualStyleBackColor = true;
            btnEnregistrerOrdonnance.Click += btnEnregistrerOrdonnance_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(511, 460);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(21, 20);
            lblMessage.TabIndex = 10;
            lblMessage.Text = "\"\"";
            lblMessage.Click += lblMessage_Click;
            // 
            // AjouterOrdonnanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 503);
            Controls.Add(lblMessage);
            Controls.Add(btnEnregistrerOrdonnance);
            Controls.Add(lstMedicamentsAjoutes);
            Controls.Add(btnAjouterMedicament);
            Controls.Add(txtDose);
            Controls.Add(lblDose);
            Controls.Add(dgvMedicaments);
            Controls.Add(btnRechercher);
            Controls.Add(txtRecherche);
            Controls.Add(lblRecherche);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "AjouterOrdonnanceForm";
            Text = "AjouterOrdonnanceForm";
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRecherche;
        private TextBox txtRecherche;
        private Button btnRechercher;
        private DataGridView dgvMedicaments;
        private Label lblDose;
        private TextBox txtDose;
        private Button btnAjouterMedicament;
        private ListBox lstMedicamentsAjoutes;
        private Button btnEnregistrerOrdonnance;
        private Label lblMessage;
    }
}