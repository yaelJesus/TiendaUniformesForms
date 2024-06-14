namespace TiendaUniformes.Views
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            btnBack = new Button();
            btnBorrar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
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
            btnBack.Location = new Point(12, 299);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 13;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(340, 305);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(84, 25);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "&Eliminar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(246, 305);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 25);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(152, 305);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(84, 25);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.AllowUserToDeleteRows = false;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Phone });
            dgList.Location = new Point(12, 12);
            dgList.Name = "dgList";
            dgList.ReadOnly = true;
            dgList.Size = new Size(412, 277);
            dgList.TabIndex = 9;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 5;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre del Cliente";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 269;
            // 
            // Phone
            // 
            Phone.HeaderText = "Telefono";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 342);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgList);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerView";
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnNuevo;
        private DataGridView dgList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Phone;
    }
}