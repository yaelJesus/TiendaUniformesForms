namespace TiendaUniformes.Views
{
    partial class GarmentCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarmentCM));
            txtIdS = new MaskedTextBox();
            label2 = new Label();
            btnBack = new Button();
            txtType = new TextBox();
            label1 = new Label();
            btnCM = new Button();
            txtIdSc = new MaskedTextBox();
            label3 = new Label();
            txtDesc = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtIdS
            // 
            txtIdS.Location = new Point(9, 123);
            txtIdS.Mask = "99";
            txtIdS.Name = "txtIdS";
            txtIdS.Size = new Size(280, 23);
            txtIdS.TabIndex = 21;
            txtIdS.TextAlign = HorizontalAlignment.Center;
            txtIdS.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 57);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 20;
            label2.Text = "Descripcion";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(9, 209);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 19;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtType
            // 
            txtType.Location = new Point(9, 27);
            txtType.Name = "txtType";
            txtType.Size = new Size(280, 23);
            txtType.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 17;
            label1.Text = "Tipo de prenda";
            // 
            // btnCM
            // 
            btnCM.DialogResult = DialogResult.OK;
            btnCM.FlatStyle = FlatStyle.Popup;
            btnCM.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCM.Location = new Point(107, 216);
            btnCM.Name = "btnCM";
            btnCM.Size = new Size(84, 25);
            btnCM.TabIndex = 16;
            btnCM.Text = "&Nuevo";
            btnCM.UseVisualStyleBackColor = true;
            btnCM.Click += btnCM_Click;
            // 
            // txtIdSc
            // 
            txtIdSc.Location = new Point(9, 171);
            txtIdSc.Mask = "99";
            txtIdSc.Name = "txtIdSc";
            txtIdSc.Size = new Size(280, 23);
            txtIdSc.TabIndex = 25;
            txtIdSc.TextAlign = HorizontalAlignment.Center;
            txtIdSc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 153);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 24;
            label3.Text = "idSc";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(9, 75);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(280, 23);
            txtDesc.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 105);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 22;
            label4.Text = "idS";
            // 
            // GarmentCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 253);
            ControlBox = false;
            Controls.Add(txtIdSc);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(label4);
            Controls.Add(txtIdS);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(txtType);
            Controls.Add(label1);
            Controls.Add(btnCM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GarmentCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GarmentCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtIdS;
        private Label label2;
        private Button btnBack;
        private TextBox txtType;
        private Label label1;
        private Button btnCM;
        private MaskedTextBox txtIdSc;
        private Label label3;
        private TextBox txtDesc;
        private Label label4;
    }
}