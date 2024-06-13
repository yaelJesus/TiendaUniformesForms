namespace TiendaUniformes
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            btnRegister = new LinkLabel();
            btnLogOut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(78, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "&Usuario o Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "&Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 48);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(207, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(13, 98);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(205, 23);
            txtPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 171);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 5;
            label3.Text = "Aun no tienes una cuenta?";
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.Location = new Point(86, 194);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(59, 15);
            btnRegister.TabIndex = 6;
            btnRegister.TabStop = true;
            btnRegister.Text = "Registrate";
            btnRegister.LinkClicked += btnRegister_LinkClicked;
            // 
            // btnLogOut
            // 
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(193, 208);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(25, 25);
            btnLogOut.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogOut.TabIndex = 7;
            btnLogOut.TabStop = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 245);
            ControlBox = false;
            Controls.Add(btnLogOut);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label3;
        private LinkLabel btnRegister;
        private PictureBox btnLogOut;
    }
}
