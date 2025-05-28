namespace GestionCabinetVf
{
    partial class ModifierMedicamentForm
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
            lblNom = new Label();
            lblDescription = new Label();
            lblCategorie = new Label();
            btnSauvegarder = new Button();
            txtNom = new TextBox();
            txtDescription = new TextBox();
            cmbCategorie = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(392, 40);
            label1.Name = "label1";
            label1.Size = new Size(363, 38);
            label1.TabIndex = 0;
            label1.Text = "Modifier le médicament";
            label1.Click += label1_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(251, 140);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom :";
            lblNom.Click += lblNom_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(251, 218);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(92, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description :";
            lblDescription.Click += lblDescription_Click;
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.Location = new Point(251, 295);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(81, 20);
            lblCategorie.TabIndex = 3;
            lblCategorie.Text = "Catégorie :";
            lblCategorie.Click += lblCategorie_Click;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.Location = new Point(501, 374);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(254, 29);
            btnSauvegarder.TabIndex = 4;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = true;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(501, 140);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(254, 27);
            txtNom.TabIndex = 5;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(501, 218);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(254, 27);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(501, 287);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(254, 28);
            cmbCategorie.TabIndex = 7;
            cmbCategorie.SelectedIndexChanged += cmbCategorie_SelectedIndexChanged;
            // 
            // ModifierMedicamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 503);
            Controls.Add(cmbCategorie);
            Controls.Add(txtDescription);
            Controls.Add(txtNom);
            Controls.Add(btnSauvegarder);
            Controls.Add(lblCategorie);
            Controls.Add(lblDescription);
            Controls.Add(lblNom);
            Controls.Add(label1);
            Name = "ModifierMedicamentForm";
            Text = "ModifierMedicamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNom;
        private Label lblDescription;
        private Label lblCategorie;
        private Button btnSauvegarder;
        private TextBox txtNom;
        private TextBox txtDescription;
        private ComboBox cmbCategorie;
    }
}