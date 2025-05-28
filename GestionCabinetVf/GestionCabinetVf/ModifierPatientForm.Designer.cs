namespace GestionCabinetVf
{
    partial class ModifierPatientForm
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
            lblPrenom = new Label();
            lblAdresse = new Label();
            lblTelephone = new Label();
            lblNom = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtAdresse = new TextBox();
            txtTelephone = new TextBox();
            btnSauvegarder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(411, 39);
            label1.Name = "label1";
            label1.Size = new Size(286, 38);
            label1.TabIndex = 0;
            label1.Text = "Modifier le patient";
            label1.Click += label1_Click;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(355, 210);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(67, 20);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom :";
            lblPrenom.Click += lblPrenom_Click;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(355, 272);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(68, 20);
            lblAdresse.TabIndex = 3;
            lblAdresse.Text = "Adresse :";
            lblAdresse.Click += lblAdresse_Click;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(355, 335);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(85, 20);
            lblTelephone.TabIndex = 4;
            lblTelephone.Text = "Téléphone :";
            lblTelephone.Click += lblTelephone_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(355, 146);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 5;
            lblNom.Text = "Nom :";
            lblNom.Click += lblNom_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(572, 143);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 6;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(572, 210);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 7;
            txtPrenom.TextChanged += txtPrenom_TextChanged;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(572, 272);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(125, 27);
            txtAdresse.TabIndex = 8;
            txtAdresse.TextChanged += txtAdresse_TextChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(572, 335);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(125, 27);
            txtTelephone.TabIndex = 9;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.Location = new Point(355, 407);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(342, 29);
            btnSauvegarder.TabIndex = 10;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = true;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // ModifierPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 503);
            Controls.Add(btnSauvegarder);
            Controls.Add(txtTelephone);
            Controls.Add(txtAdresse);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(lblTelephone);
            Controls.Add(lblAdresse);
            Controls.Add(lblPrenom);
            Controls.Add(label1);
            Name = "ModifierPatientForm";
            Text = "ModifierPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPrenom;
        private Label lblAdresse;
        private Label lblTelephone;
        private Label lblNom;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtAdresse;
        private TextBox txtTelephone;
        private Button btnSauvegarder;
    }
}