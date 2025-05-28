namespace GestionCabinetVf
{
    partial class AjouterPatientForm
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
            lblNom = new Label();
            lblPrenom = new Label();
            lblNaissance = new Label();
            lblAdresse = new Label();
            lblTelephone = new Label();
            lblResultat = new Label();
            btnAjouter = new Button();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtAdresse = new TextBox();
            txtTelephone = new TextBox();
            dtpNaissance = new DateTimePicker();
            lblAjouterPatient = new Label();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(245, 96);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom :";
            lblNom.Click += lblNom_Click;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(245, 151);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(67, 20);
            lblPrenom.TabIndex = 1;
            lblPrenom.Text = "Prénom :";
            lblPrenom.Click += lblPrenom_Click;
            // 
            // lblNaissance
            // 
            lblNaissance.AutoSize = true;
            lblNaissance.Location = new Point(245, 205);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(136, 20);
            lblNaissance.TabIndex = 2;
            lblNaissance.Text = "Date de naissance :";
            lblNaissance.Click += lblNaissance_Click;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(245, 260);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(68, 20);
            lblAdresse.TabIndex = 3;
            lblAdresse.Text = "Adresse :";
            lblAdresse.Click += lblAdresse_Click;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(245, 320);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(85, 20);
            lblTelephone.TabIndex = 4;
            lblTelephone.Text = "Téléphone :";
            lblTelephone.Click += lblTelephone_Click;
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.ForeColor = Color.Green;
            lblResultat.Location = new Point(549, 460);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(21, 20);
            lblResultat.TabIndex = 5;
            lblResultat.Text = "\"\"";
            lblResultat.Click += lblResultat_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(549, 393);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(250, 29);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(549, 96);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(250, 27);
            txtNom.TabIndex = 7;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(549, 151);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(250, 27);
            txtPrenom.TabIndex = 8;
            txtPrenom.TextChanged += txtPrenom_TextChanged;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(549, 260);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(250, 27);
            txtAdresse.TabIndex = 9;
            txtAdresse.TextChanged += txtAdresse_TextChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(549, 320);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(250, 27);
            txtTelephone.TabIndex = 10;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // dtpNaissance
            // 
            dtpNaissance.Location = new Point(549, 205);
            dtpNaissance.Name = "dtpNaissance";
            dtpNaissance.Size = new Size(250, 27);
            dtpNaissance.TabIndex = 11;
            dtpNaissance.ValueChanged += dtpNaissance_ValueChanged;
            // 
            // lblAjouterPatient
            // 
            lblAjouterPatient.AutoSize = true;
            lblAjouterPatient.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAjouterPatient.ForeColor = SystemColors.MenuHighlight;
            lblAjouterPatient.Location = new Point(440, 27);
            lblAjouterPatient.Name = "lblAjouterPatient";
            lblAjouterPatient.Size = new Size(285, 38);
            lblAjouterPatient.TabIndex = 12;
            lblAjouterPatient.Text = "Ajouter un patient";
            lblAjouterPatient.Click += lblAjouterPatient_Click;
            // 
            // AjouterPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 500);
            Controls.Add(lblAjouterPatient);
            Controls.Add(dtpNaissance);
            Controls.Add(txtTelephone);
            Controls.Add(txtAdresse);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(btnAjouter);
            Controls.Add(lblResultat);
            Controls.Add(lblTelephone);
            Controls.Add(lblAdresse);
            Controls.Add(lblNaissance);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Name = "AjouterPatientForm";
            Text = "AjouterPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Label lblPrenom;
        private Label lblNaissance;
        private Label lblAdresse;
        private Label lblTelephone;
        private Label lblResultat;
        private Button btnAjouter;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtAdresse;
        private TextBox txtTelephone;
        private DateTimePicker dtpNaissance;
        private Label lblAjouterPatient;
    }
}