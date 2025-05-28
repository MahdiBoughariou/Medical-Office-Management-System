namespace GestionCabinetVf
{
    partial class Login
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
            lblUtilisateur = new Label();
            txtUsername = new TextBox();
            lblMdp = new Label();
            txtPassword = new TextBox();
            lblMessage = new Label();
            btnLogin = new Button();
            lblConnecter = new Label();
            SuspendLayout();
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Location = new Point(279, 161);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(120, 20);
            lblUtilisateur.TabIndex = 0;
            lblUtilisateur.Text = "Nom Utilisateur :";
            lblUtilisateur.Click += lblUtilisateur_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(502, 161);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(298, 27);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new Point(279, 229);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(105, 20);
            lblMdp.TabIndex = 2;
            lblMdp.Text = "Mot de passe :";
            lblMdp.Click += lblMdp_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(502, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(298, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(502, 395);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(21, 20);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "\"\"";
            lblMessage.Click += lblMessage_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(502, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(303, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblConnecter
            // 
            lblConnecter.AutoSize = true;
            lblConnecter.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConnecter.ForeColor = SystemColors.MenuHighlight;
            lblConnecter.Location = new Point(502, 62);
            lblConnecter.Name = "lblConnecter";
            lblConnecter.Size = new Size(244, 38);
            lblConnecter.TabIndex = 6;
            lblConnecter.Text = "Connectez-vous";
            lblConnecter.Click += lblConnecter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 503);
            Controls.Add(lblConnecter);
            Controls.Add(btnLogin);
            Controls.Add(lblMessage);
            Controls.Add(txtPassword);
            Controls.Add(lblMdp);
            Controls.Add(txtUsername);
            Controls.Add(lblUtilisateur);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUtilisateur;
        private TextBox txtUsername;
        private Label lblMdp;
        private TextBox txtPassword;
        private Label lblMessage;
        private Button btnLogin;
        private Label lblConnecter;
    }
}