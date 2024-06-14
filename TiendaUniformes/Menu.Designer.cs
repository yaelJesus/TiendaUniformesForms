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
            btnInventory = new Button();
            btnSizes = new Button();
            btnOrders = new Button();
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
            btnGarments.Click += btnGarments_Click;
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
            // btnInventory
            // 
            btnInventory.FlatStyle = FlatStyle.Popup;
            btnInventory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.Location = new Point(161, 90);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(95, 35);
            btnInventory.TabIndex = 9;
            btnInventory.Text = "&Inventario";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
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
            btnSizes.Click += btnSizes_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatStyle = FlatStyle.Popup;
            btnOrders.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(290, 90);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(95, 35);
            btnOrders.TabIndex = 11;
            btnOrders.Text = "&Ordenes";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 186);
            ControlBox = false;
            Controls.Add(btnOrders);
            Controls.Add(btnSizes);
            Controls.Add(btnInventory);
            Controls.Add(btnSchools);
            Controls.Add(btnGarments);
            Controls.Add(btnLogOut);
            Controls.Add(btnCustomers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnLogOut;
        private Button btnCustomers;
        private Button btnGarments;
        private Button btnSchools;
        private Button btnInventory;
        private Button btnSizes;
        private Button btnOrders;
        private ToolTip toolTip1;
    }
}