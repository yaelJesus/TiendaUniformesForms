namespace TiendaUniformes.Views
{
    partial class OrderCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCM));
            txtTotal = new MaskedTextBox();
            label3 = new Label();
            txtIdC = new MaskedTextBox();
            label1 = new Label();
            txtDeadLine = new MaskedTextBox();
            label2 = new Label();
            btnBack = new Button();
            btnCM = new Button();
            txtDateOrder = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(12, 169);
            txtTotal.Mask = "99999";
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(280, 23);
            txtTotal.TabIndex = 31;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            txtTotal.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 152);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 30;
            label3.Text = "Total";
            // 
            // txtIdC
            // 
            txtIdC.Location = new Point(12, 121);
            txtIdC.Mask = "99";
            txtIdC.Name = "txtIdC";
            txtIdC.Size = new Size(280, 23);
            txtIdC.TabIndex = 29;
            txtIdC.TextAlign = HorizontalAlignment.Center;
            txtIdC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 103);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 28;
            label1.Text = "idC";
            // 
            // txtDeadLine
            // 
            txtDeadLine.Location = new Point(12, 73);
            txtDeadLine.Mask = "0000/00/00";
            txtDeadLine.Name = "txtDeadLine";
            txtDeadLine.Size = new Size(280, 23);
            txtDeadLine.TabIndex = 27;
            txtDeadLine.TextAlign = HorizontalAlignment.Center;
            txtDeadLine.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 55);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 26;
            label2.Text = "Fecha de entrega";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 211);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 25;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCM
            // 
            btnCM.DialogResult = DialogResult.OK;
            btnCM.FlatStyle = FlatStyle.Popup;
            btnCM.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCM.Location = new Point(110, 218);
            btnCM.Name = "btnCM";
            btnCM.Size = new Size(84, 25);
            btnCM.TabIndex = 24;
            btnCM.Text = "&Nuevo";
            btnCM.UseVisualStyleBackColor = true;
            btnCM.Click += btnCM_Click;
            // 
            // txtDateOrder
            // 
            txtDateOrder.Location = new Point(12, 27);
            txtDateOrder.Mask = "0000/00/00";
            txtDateOrder.Name = "txtDateOrder";
            txtDateOrder.Size = new Size(280, 23);
            txtDateOrder.TabIndex = 33;
            txtDateOrder.TextAlign = HorizontalAlignment.Center;
            txtDateOrder.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 9);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 32;
            label4.Text = "Fecha de la orden";
            // 
            // OrderCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 253);
            ControlBox = false;
            Controls.Add(txtDateOrder);
            Controls.Add(label4);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(txtIdC);
            Controls.Add(label1);
            Controls.Add(txtDeadLine);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnCM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrderCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtTotal;
        private Label label3;
        private MaskedTextBox txtIdC;
        private Label label1;
        private MaskedTextBox txtDeadLine;
        private Label label2;
        private Button btnBack;
        private Button btnCM;
        private MaskedTextBox txtDateOrder;
        private Label label4;
    }
}