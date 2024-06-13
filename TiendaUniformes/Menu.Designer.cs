namespace TiendaUniformes
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnLogOut = new PictureBox();
            btnCustomers = new Button();
            btnGarments = new Button();
            btnSchools = new Button();
            button3 = new Button();
            btnSizes = new Button();
            button5 = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(12, 149);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(25, 25);
            btnLogOut.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogOut.TabIndex = 6;
            btnLogOut.TabStop = false;
            toolTip1.SetToolTip(btnLogOut, "Cerrar Sesión");
            btnLogOut.Click += pictureBox1_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(32, 33);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(95, 35);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "&Clientes";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnGarments
            // 
            btnGarments.FlatStyle = FlatStyle.Popup;
            btnGarments.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGarments.Location = new Point(32, 90);
            btnGarments.Name = "btnGarments";
            btnGarments.Size = new Size(95, 35);
            btnGarments.TabIndex = 7;
            btnGarments.Text = "&Prendas";
            btnGarments.UseVisualStyleBackColor = true;
            // 
            // btnSchools
            // 
            btnSchools.FlatStyle = FlatStyle.Popup;
            btnSchools.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSchools.Location = new Point(161, 33);
            btnSchools.Name = "btnSchools";
            btnSchools.Size = new Size(95, 35);
            btnSchools.TabIndex = 8;
            btnSchools.Text = "&Escuelas";
            btnSchools.UseVisualStyleBackColor = true;
            btnSchools.Click += btnSchools_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(161, 90);
            button3.Name = "button3";
            button3.Size = new Size(95, 35);
            button3.TabIndex = 9;
            button3.Text = "&Inventario";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSizes
            // 
            btnSizes.FlatStyle = FlatStyle.Popup;
            btnSizes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSizes.Location = new Point(290, 33);
            btnSizes.Name = "btnSizes";
            btnSizes.Size = new Size(95, 35);
            btnSizes.TabIndex = 10;
            btnSizes.Text = "&Tallas";
            btnSizes.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(290, 90);
            button5.Name = "button5";
            button5.Size = new Size(95, 35);
            button5.TabIndex = 11;
            button5.Text = "&Ordenes";
            button5.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 186);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(btnSizes);
            Controls.Add(button3);
            Controls.Add(btnSchools);
            Controls.Add(btnGarments);
            Controls.Add(btnLogOut);
            Controls.Add(btnCustomers);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnLogOut;
        private Button btnCustomers;
        private Button btnGarments;
        private Button btnSchools;
        private Button button3;
        private Button btnSizes;
        private Button button5;
        private ToolTip toolTip1;
    }
}