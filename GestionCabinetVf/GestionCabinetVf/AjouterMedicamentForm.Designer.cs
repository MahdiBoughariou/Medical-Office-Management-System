namespace GestionCabinetVf
{
    partial class AjouterMedicamentForm
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
            lblAjouterMedicament = new Label();
            lblNom = new Label();
            lblDescription = new Label();
            lblCategorie = new Label();
            txtNom = new TextBox();
            txtDescription = new TextBox();
            cmbCategorie = new ComboBox();
            btnAjouterMedicament = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblAjouterMedicament
            // 
            lblAjouterMedicament.AutoSize = true;
            lblAjouterMedicament.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAjouterMedicament.ForeColor = SystemColors.MenuHighlight;
            lblAjouterMedicament.Location = new Point(406, 44);
            lblAjouterMedicament.Name = "lblAjouterMedicament";
            lblAjouterMedicament.Size = new Size(362, 38);
            lblAjouterMedicament.TabIndex = 0;
            lblAjouterMedicament.Text = "Ajouter un médicament";
            lblAjouterMedicament.Click += lblAjouterMedicament_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(285, 154);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom :";
            lblNom.Click += lblNom_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(285, 231);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(92, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description :";
            lblDescription.Click += lblDescription_Click;
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.Location = new Point(285, 301);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(81, 20);
            lblCategorie.TabIndex = 3;
            lblCategorie.Text = "Catégorie :";
            lblCategorie.Click += lblCategorie_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(562, 154);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(212, 27);
            txtNom.TabIndex = 4;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(562, 231);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(212, 27);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(562, 301);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(212, 28);
            cmbCategorie.TabIndex = 6;
            cmbCategorie.SelectedIndexChanged += cmbCategorie_SelectedIndexChanged;
            // 
            // btnAjouterMedicament
            // 
            btnAjouterMedicament.Location = new Point(562, 377);
            btnAjouterMedicament.Name = "btnAjouterMedicament";
            btnAjouterMedicament.Size = new Size(212, 29);
            btnAjouterMedicament.TabIndex = 7;
            btnAjouterMedicament.Text = "Ajouter";
            btnAjouterMedicament.UseVisualStyleBackColor = true;
            btnAjouterMedicament.Click += btnAjouterMedicament_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(552, 443);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(21, 20);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "\"\"";
            lblMessage.Click += lblMessage_Click;
            // 
            // AjouterMedicamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 502);
            Controls.Add(lblMessage);
            Controls.Add(btnAjouterMedicament);
            Controls.Add(cmbCategorie);
            Controls.Add(txtDescription);
            Controls.Add(txtNom);
            Controls.Add(lblCategorie);
            Controls.Add(lblDescription);
            Controls.Add(lblNom);
            Controls.Add(lblAjouterMedicament);
            Name = "AjouterMedicamentForm";
            Text = "AjouterMedicamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAjouterMedicament;
        private Label lblNom;
        private Label lblDescription;
        private Label lblCategorie;
        private TextBox txtNom;
        private TextBox txtDescription;
        private ComboBox cmbCategorie;
        private Button btnAjouterMedicament;
        private Label lblMessage;
    }
}