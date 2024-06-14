namespace TiendaUniformes.Views
{
    partial class InventoryCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryCM));
            txtIdSc = new MaskedTextBox();
            label2 = new Label();
            btnBack = new Button();
            btnCM = new Button();
            txtIdG = new MaskedTextBox();
            label1 = new Label();
            txtQty = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtIdSc
            // 
            txtIdSc.Location = new Point(12, 27);
            txtIdSc.Mask = "99";
            txtIdSc.Name = "txtIdSc";
            txtIdSc.Size = new Size(280, 23);
            txtIdSc.TabIndex = 19;
            txtIdSc.TextAlign = HorizontalAlignment.Center;
            txtIdSc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 18;
            label2.Text = "idSc";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 165);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 17;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCM
            // 
            btnCM.DialogResult = DialogResult.OK;
            btnCM.FlatStyle = FlatStyle.Popup;
            btnCM.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCM.Location = new Point(110, 172);
            btnCM.Name = "btnCM";
            btnCM.Size = new Size(84, 25);
            btnCM.TabIndex = 16;
            btnCM.Text = "&Nuevo";
            btnCM.UseVisualStyleBackColor = true;
            btnCM.Click += btnCM_Click;
            // 
            // txtIdG
            // 
            txtIdG.Location = new Point(12, 75);
            txtIdG.Mask = "99";
            txtIdG.Name = "txtIdG";
            txtIdG.Size = new Size(280, 23);
            txtIdG.TabIndex = 21;
            txtIdG.TextAlign = HorizontalAlignment.Center;
            txtIdG.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 57);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 20;
            label1.Text = "idG";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(12, 123);
            txtQty.Mask = "999";
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(280, 23);
            txtQty.TabIndex = 23;
            txtQty.TextAlign = HorizontalAlignment.Center;
            txtQty.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 106);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 22;
            label3.Text = "Cantidad";
            // 
            // InventoryCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 207);
            ControlBox = false;
            Controls.Add(txtQty);
            Controls.Add(label3);
            Controls.Add(txtIdG);
            Controls.Add(label1);
            Controls.Add(txtIdSc);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnCM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InventoryCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtIdSc;
        private Label label2;
        private Button btnBack;
        private Button btnCM;
        private MaskedTextBox txtIdG;
        private Label label1;
        private MaskedTextBox txtQty;
        private Label label3;
    }
}