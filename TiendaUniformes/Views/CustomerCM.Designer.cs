namespace TiendaUniformes.Views
{
    partial class CustomerCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCM));
            btnBack = new Button();
            txtName = new TextBox();
            label1 = new Label();
            btnCM = new Button();
            label2 = new Label();
            txtPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 109);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 13;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre del cliente";
            // 
            // btnCM
            // 
            btnCM.DialogResult = DialogResult.OK;
            btnCM.FlatStyle = FlatStyle.Popup;
            btnCM.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCM.Location = new Point(110, 116);
            btnCM.Name = "btnCM";
            btnCM.Size = new Size(84, 25);
            btnCM.TabIndex = 10;
            btnCM.Text = "&Nuevo";
            btnCM.UseVisualStyleBackColor = true;
            btnCM.Click += btnCM_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 57);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 14;
            label2.Text = "Telefono";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 75);
            txtPhone.Mask = "000-000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 15;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 151);
            ControlBox = false;
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnCM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CustomerCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox txtName;
        private Label label1;
        private Button btnCM;
        private Label label2;
        private MaskedTextBox txtPhone;
    }
}