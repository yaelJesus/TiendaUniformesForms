namespace TiendaUniformes
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtMail = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnRegister = new Button();
            txtPassC = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(13, 89);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(205, 23);
            txtMail.TabIndex = 9;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 39);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(207, 23);
            txtUser.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "&Correo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "&Usuario";
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Location = new Point(74, 231);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "&Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassC
            // 
            txtPassC.Location = new Point(13, 192);
            txtPassC.Name = "txtPassC";
            txtPassC.Size = new Size(205, 23);
            txtPassC.TabIndex = 13;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(12, 142);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(207, 23);
            txtPass.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 11;
            label3.Text = "&Confirmar contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "&Contraseña";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 229);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 14;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 271);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(txtPassC);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private Button btnRegister;
        private TextBox txtPassC;
        private TextBox txtPass;
        private Label label3;
        private Label label4;
        private Button btnBack;
    }
}