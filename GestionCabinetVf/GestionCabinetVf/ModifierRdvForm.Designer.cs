namespace GestionCabinetVf
{
    partial class ModifierRdvForm
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
            lblModifierRdv = new Label();
            lblPatient = new Label();
            txtPatient = new TextBox();
            lblDate = new Label();
            dtpDateRdv = new DateTimePicker();
            btnModifier = new Button();
            SuspendLayout();
            // 
            // lblModifierRdv
            // 
            lblModifierRdv.AutoSize = true;
            lblModifierRdv.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModifierRdv.ForeColor = SystemColors.MenuHighlight;
            lblModifierRdv.Location = new Point(388, 56);
            lblModifierRdv.Name = "lblModifierRdv";
            lblModifierRdv.Size = new Size(358, 38);
            lblModifierRdv.TabIndex = 0;
            lblModifierRdv.Text = "Modifier le rendez-vous";
            lblModifierRdv.Click += lblModifierRdv_Click;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(385, 192);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(61, 20);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Patient :";
            lblPatient.Click += lblPatient_Click;
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(496, 192);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(250, 27);
            txtPatient.TabIndex = 2;
            txtPatient.TextChanged += txtPatient_TextChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(385, 267);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date :";
            lblDate.Click += lblDate_Click;
            // 
            // dtpDateRdv
            // 
            dtpDateRdv.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDateRdv.Format = DateTimePickerFormat.Custom;
            dtpDateRdv.Location = new Point(496, 267);
            dtpDateRdv.Name = "dtpDateRdv";
            dtpDateRdv.ShowUpDown = true;
            dtpDateRdv.Size = new Size(250, 27);
            dtpDateRdv.TabIndex = 4;
            dtpDateRdv.ValueChanged += dtpDateRdv_ValueChanged;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(496, 347);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(250, 29);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // ModifierRdvForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 506);
            Controls.Add(btnModifier);
            Controls.Add(dtpDateRdv);
            Controls.Add(lblDate);
            Controls.Add(txtPatient);
            Controls.Add(lblPatient);
            Controls.Add(lblModifierRdv);
            Name = "ModifierRdvForm";
            Text = "ModifierRdvForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModifierRdv;
        private Label lblPatient;
        private TextBox txtPatient;
        private Label lblDate;
        private DateTimePicker dtpDateRdv;
        private Button btnModifier;
    }
}