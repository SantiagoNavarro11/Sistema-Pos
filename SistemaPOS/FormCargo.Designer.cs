namespace SistemaPOS
{
    partial class FormCargo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            label1 = new Label();
            dgvCargos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            cargoBindingSource = new BindingSource(components);
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            btnGuardar = new Button();
            btnExportar = new Button();
            lblmensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCargos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cargoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Id Cargo";
            // 
            // dgvCargos
            // 
            dgvCargos.AutoGenerateColumns = false;
            dgvCargos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvCargos.BorderStyle = BorderStyle.None;
            dgvCargos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargos.Columns.AddRange(new DataGridViewColumn[] { Id, Cargo, Eliminar });
            dgvCargos.DataSource = cargoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCargos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCargos.EnableHeadersVisualStyles = false;
            dgvCargos.GridColor = Color.SteelBlue;
            dgvCargos.Location = new Point(406, 152);
            dgvCargos.Name = "dgvCargos";
            dgvCargos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCargos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvCargos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCargos.Size = new Size(413, 228);
            dgvCargos.TabIndex = 5;
            dgvCargos.CellClick += dgvCargos_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "IdCargo";
            Id.HeaderText = "Cargo";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 70;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "NombreTipoCargo";
            Cargo.HeaderText = "Nombre";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.Width = 160;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 80;
            // 
            // cargoBindingSource
            // 
            cargoBindingSource.DataSource = typeof(SistemaPos.Entidades.Cargo);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(431, 65);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre Cargo";
            // 
            // txtId
            // 
            txtId.BackColor = Color.Azure;
            txtId.Location = new Point(147, 63);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Azure;
            txtNombre.Location = new Point(559, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightGreen;
            label8.Location = new Point(14, 12);
            label8.Name = "label8";
            label8.Size = new Size(221, 23);
            label8.TabIndex = 17;
            label8.Text = "Administración Cargos";
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.icons_save_24;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(234, 107);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 37);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.TopCenter;
            btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(663, 107);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 40);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click_1;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.BackColor = Color.Transparent;
            lblmensaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmensaje.ForeColor = Color.White;
            lblmensaje.Location = new Point(417, 116);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 20);
            lblmensaje.TabIndex = 18;
            // 
            // FormCargo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(862, 424);
            Controls.Add(lblmensaje);
            Controls.Add(btnExportar);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgvCargos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCargo";
            Text = "Administración Cargos";
            ((System.ComponentModel.ISupportInitialize)dgvCargos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cargoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvCargos;
        private Label label2;
        //private Button btnGuardar;
        private TextBox txtId;
        private TextBox txtNombre;
        private BindingSource cargoBindingSource;
        private Label label8;
        private Button btnGuardar;
        private Button btnExportar;
        private Label lblmensaje;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewImageColumn Eliminar;
    }
}
