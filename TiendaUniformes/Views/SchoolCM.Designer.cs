namespace TiendaUniformes.Views
{
    partial class SchoolCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolCM));
            btnCM = new Button();
            label1 = new Label();
            txtName = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnCM
            // 
            btnCM.DialogResult = DialogResult.OK;
            btnCM.FlatStyle = FlatStyle.Popup;
            btnCM.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCM.Location = new Point(110, 94);
            btnCM.Name = "btnCM";
            btnCM.Size = new Size(84, 25);
            btnCM.TabIndex = 5;
            btnCM.Text = "&Nuevo";
            btnCM.UseVisualStyleBackColor = true;
            btnCM.Click += btnCM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre de la escuela";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 91);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 9;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SchoolCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 131);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnCM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SchoolCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCM;
        private Label label1;
        private TextBox txtName;
        private Button btnBack;
    }
}