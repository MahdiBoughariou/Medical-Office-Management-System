namespace GestionCabinetVf
{
    partial class AjouterConsultationForm
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
            lblCreerConsultation = new Label();
            cmbPatients = new ComboBox();
            lblQR = new Label();
            txtQuestionsReponses = new TextBox();
            txtMaladie = new TextBox();
            lblMaladie = new Label();
            lblRemarques = new Label();
            btnCreerOrdonnance = new Button();
            lblMessage = new Label();
            txtRemarques = new TextBox();
            lblPatient = new Label();
            SuspendLayout();
            // 
            // lblCreerConsultation
            // 
            lblCreerConsultation.AutoSize = true;
            lblCreerConsultation.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreerConsultation.ForeColor = SystemColors.MenuHighlight;
            lblCreerConsultation.Location = new Point(397, 46);
            lblCreerConsultation.Name = "lblCreerConsultation";
            lblCreerConsultation.Size = new Size(358, 38);
            lblCreerConsultation.TabIndex = 0;
            lblCreerConsultation.Text = "Créer une Consultation";
            lblCreerConsultation.Click += lblCreerConsultation_Click;
            // 
            // cmbPatients
            // 
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(540, 148);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(277, 28);
            cmbPatients.TabIndex = 2;
            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
            // 
            // lblQR
            // 
            lblQR.AutoSize = true;
            lblQR.Location = new Point(267, 216);
            lblQR.Name = "lblQR";
            lblQR.Size = new Size(158, 20);
            lblQR.TabIndex = 3;
            lblQR.Text = "Questions / Réponses :";
            lblQR.Click += lblQR_Click;
            // 
            // txtQuestionsReponses
            // 
            txtQuestionsReponses.Location = new Point(540, 213);
            txtQuestionsReponses.Multiline = true;
            txtQuestionsReponses.Name = "txtQuestionsReponses";
            txtQuestionsReponses.Size = new Size(277, 27);
            txtQuestionsReponses.TabIndex = 4;
            txtQuestionsReponses.TextChanged += txtQuestionsReponses_TextChanged;
            // 
            // txtMaladie
            // 
            txtMaladie.Location = new Point(540, 279);
            txtMaladie.Name = "txtMaladie";
            txtMaladie.Size = new Size(277, 27);
            txtMaladie.TabIndex = 5;
            txtMaladie.TextChanged += txtMaladie_TextChanged;
            // 
            // lblMaladie
            // 
            lblMaladie.AutoSize = true;
            lblMaladie.Location = new Point(267, 279);
            lblMaladie.Name = "lblMaladie";
            lblMaladie.Size = new Size(70, 20);
            lblMaladie.TabIndex = 6;
            lblMaladie.Text = "Maladie :";
            lblMaladie.Click += lblMaladie_Click;
            // 
            // lblRemarques
            // 
            lblRemarques.AutoSize = true;
            lblRemarques.Location = new Point(267, 341);
            lblRemarques.Name = "lblRemarques";
            lblRemarques.Size = new Size(90, 20);
            lblRemarques.TabIndex = 7;
            lblRemarques.Text = "Remarques :";
            lblRemarques.Click += lblRemarques_Click;
            // 
            // btnCreerOrdonnance
            // 
            btnCreerOrdonnance.Location = new Point(540, 406);
            btnCreerOrdonnance.Name = "btnCreerOrdonnance";
            btnCreerOrdonnance.Size = new Size(277, 29);
            btnCreerOrdonnance.TabIndex = 8;
            btnCreerOrdonnance.Text = "Créer Ordonnance";
            btnCreerOrdonnance.UseVisualStyleBackColor = true;
            btnCreerOrdonnance.Click += btnCreerOrdonnance_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(540, 463);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(21, 20);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "\"\"";
            lblMessage.Click += lblMessage_Click;
            // 
            // txtRemarques
            // 
            txtRemarques.Location = new Point(540, 341);
            txtRemarques.Name = "txtRemarques";
            txtRemarques.Size = new Size(277, 27);
            txtRemarques.TabIndex = 10;
            txtRemarques.TextChanged += txtRemarques_TextChanged;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(267, 148);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(169, 20);
            lblPatient.TabIndex = 11;
            lblPatient.Text = "Sélectionner un patient :";
            lblPatient.Click += lblPatient_Click;
            // 
            // AjouterConsultationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 503);
            Controls.Add(lblPatient);
            Controls.Add(txtRemarques);
            Controls.Add(lblMessage);
            Controls.Add(btnCreerOrdonnance);
            Controls.Add(lblRemarques);
            Controls.Add(lblMaladie);
            Controls.Add(txtMaladie);
            Controls.Add(txtQuestionsReponses);
            Controls.Add(lblQR);
            Controls.Add(cmbPatients);
            Controls.Add(lblCreerConsultation);
            Name = "AjouterConsultationForm";
            Text = "AjouterConsultationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreerConsultation;
        private Label label2;
        private ComboBox cmbPatients;
        private Label lblQR;
        private TextBox txtQuestionsReponses;
        private TextBox txtMaladie;
        private Label lblMaladie;
        private Label lblRemarques;
        private Button btnCreerOrdonnance;
        private Label lblMessage;
        private TextBox txtRemarques;
        private Label lblPatient;
    }
}