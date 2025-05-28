namespace GestionCabinetVf
{
    partial class AjouterRdvForm
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
            lblAjouterRdv = new Label();
            lblPatient = new Label();
            txtPatient = new TextBox();
            lblDate = new Label();
            dtpDateRdv = new DateTimePicker();
            btnAjouterRdv = new Button();
            SuspendLayout();
            // 
            // lblAjouterRdv
            // 
            lblAjouterRdv.AutoSize = true;
            lblAjouterRdv.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAjouterRdv.ForeColor = SystemColors.MenuHighlight;
            lblAjouterRdv.Location = new Point(391, 59);
            lblAjouterRdv.Name = "lblAjouterRdv";
            lblAjouterRdv.Size = new Size(310, 38);
            lblAjouterRdv.TabIndex = 0;
            lblAjouterRdv.Text = "Ajouter rendez-vous";
            lblAjouterRdv.Click += lblAjouterRdv_Click;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(346, 182);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(61, 20);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Patient :";
            lblPatient.Click += lblPatient_Click;
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(465, 182);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(246, 27);
            txtPatient.TabIndex = 2;
            txtPatient.TextChanged += txtPatient_TextChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(346, 246);
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
            dtpDateRdv.Location = new Point(465, 246);
            dtpDateRdv.Name = "dtpDateRdv";
            dtpDateRdv.ShowUpDown = true;
            dtpDateRdv.Size = new Size(250, 27);
            dtpDateRdv.TabIndex = 4;
            dtpDateRdv.ValueChanged += dtpDateRdv_ValueChanged;
            // 
            // btnAjouterRdv
            // 
            btnAjouterRdv.Location = new Point(465, 316);
            btnAjouterRdv.Name = "btnAjouterRdv";
            btnAjouterRdv.Size = new Size(250, 29);
            btnAjouterRdv.TabIndex = 5;
            btnAjouterRdv.Text = "Ajouter";
            btnAjouterRdv.UseVisualStyleBackColor = true;
            btnAjouterRdv.Click += btnAjouterRdv_Click;
            // 
            // AjouterRdvForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 506);
            Controls.Add(btnAjouterRdv);
            Controls.Add(dtpDateRdv);
            Controls.Add(lblDate);
            Controls.Add(txtPatient);
            Controls.Add(lblPatient);
            Controls.Add(lblAjouterRdv);
            Name = "AjouterRdvForm";
            Text = "AjouterRdvForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAjouterRdv;
        private Label lblPatient;
        private TextBox txtPatient;
        private Label lblDate;
        private DateTimePicker dtpDateRdv;
        private Button btnAjouterRdv;
    }
}