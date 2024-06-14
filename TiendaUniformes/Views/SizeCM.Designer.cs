namespace TiendaUniformes.Views
{
    partial class SizeCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SizeCM));
            label2 = new Label();
            btnBack = new Button();
            label1 = new Label();
            btnCM = new Button();
            txtPresio = new MaskedTextBox();
            txtTalla = new MaskedTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 57);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 20;
            label2.Text = "Presio";
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
            btnBack.TabIndex = 19;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 17;
            label1.Text = "Talla de prenda";
            // 
            // btnCM
            // 
            btnCM.DialogResult = DialogResult.OK;
            btnCM.FlatStyle = FlatStyle.Popup;
            btnCM.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCM.Location = new Point(110, 116);
            btnCM.Name = "btnCM";
            btnCM.Size = new Size(84, 25);
            btnCM.TabIndex = 16;
            btnCM.Text = "&Nuevo";
            btnCM.UseVisualStyleBackColor = true;
            btnCM.Click += btnCM_Click;
            // 
            // txtPresio
            // 
            txtPresio.Location = new Point(12, 75);
            txtPresio.Mask = "99999";
            txtPresio.Name = "txtPresio";
            txtPresio.Size = new Size(280, 23);
            txtPresio.TabIndex = 21;
            txtPresio.TextAlign = HorizontalAlignment.Center;
            txtPresio.ValidatingType = typeof(int);
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(12, 27);
            txtTalla.Mask = "99999";
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(280, 23);
            txtTalla.TabIndex = 22;
            txtTalla.TextAlign = HorizontalAlignment.Center;
            txtTalla.ValidatingType = typeof(int);
            // 
            // SizeCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 151);
            ControlBox = false;
            Controls.Add(txtTalla);
            Controls.Add(txtPresio);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnCM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SizeCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SizeCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnBack;
        private Label label1;
        private Button btnCM;
        private MaskedTextBox txtPresio;
        private MaskedTextBox txtTalla;
    }
}