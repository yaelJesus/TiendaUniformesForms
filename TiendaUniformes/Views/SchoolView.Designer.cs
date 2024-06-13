namespace TiendaUniformes.Views
{
    partial class SchoolView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolView));
            dgSchoolsList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            toolTip1 = new ToolTip(components);
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSchoolsList).BeginInit();
            SuspendLayout();
            // 
            // dgSchoolsList
            // 
            dgSchoolsList.AllowUserToAddRows = false;
            dgSchoolsList.AllowUserToDeleteRows = false;
            dgSchoolsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSchoolsList.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre });
            dgSchoolsList.Location = new Point(12, 12);
            dgSchoolsList.Name = "dgSchoolsList";
            dgSchoolsList.ReadOnly = true;
            dgSchoolsList.Size = new Size(412, 277);
            dgSchoolsList.TabIndex = 3;
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
            Nombre.HeaderText = "Nombre de la Escuela";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 369;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(152, 305);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(84, 25);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(246, 305);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 25);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(340, 305);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(84, 25);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "&Eliminar";
            btnBorrar.UseVisualStyleBackColor = true;
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
            btnBack.TabIndex = 8;
            toolTip1.SetToolTip(btnBack, "Regresar al Menu");
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SchoolView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 342);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgSchoolsList);
            Name = "SchoolView";
            Text = "Escuelas";
            ((System.ComponentModel.ISupportInitialize)dgSchoolsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgSchoolsList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnBorrar;
        private ToolTip toolTip1;
        private Button btnBack;
    }
}