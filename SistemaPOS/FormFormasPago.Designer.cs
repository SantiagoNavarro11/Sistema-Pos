namespace SistemaPOS
{
    partial class FormFormasPago
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvFormasPago = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            formasDePagoBindingSource = new BindingSource(components);
            txtId = new TextBox();
            btnGuardar = new Button();
            label2 = new Label();
            txtFormaPago = new TextBox();
            label8 = new Label();
            btnExportar = new Button();
            lblmensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFormasPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formasDePagoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 61);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // dgvFormasPago
            // 
            dgvFormasPago.AutoGenerateColumns = false;
            dgvFormasPago.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvFormasPago.BorderStyle = BorderStyle.None;
            dgvFormasPago.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFormasPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFormasPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormasPago.Columns.AddRange(new DataGridViewColumn[] { Id, MetodoPago, Eliminar });
            dgvFormasPago.DataSource = formasDePagoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFormasPago.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFormasPago.EnableHeadersVisualStyles = false;
            dgvFormasPago.GridColor = Color.SteelBlue;
            dgvFormasPago.Location = new Point(12, 170);
            dgvFormasPago.Name = "dgvFormasPago";
            dgvFormasPago.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFormasPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFormasPago.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvFormasPago.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFormasPago.Size = new Size(682, 211);
            dgvFormasPago.TabIndex = 5;
            dgvFormasPago.CellClick += dgvFormasPago_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdFormaPago";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 70;
            // 
            // MetodoPago
            // 
            MetodoPago.DataPropertyName = "NombreMetodoPago";
            MetodoPago.HeaderText = "Nombre";
            MetodoPago.MinimumWidth = 6;
            MetodoPago.Name = "MetodoPago";
            MetodoPago.Width = 250;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 85;
            // 
            // formasDePagoBindingSource
            // 
            formasDePagoBindingSource.DataSource = typeof(SistemaPos.Entidades.FormasDePago);
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 59);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.BackgroundImage = Properties.Resources.icons_save_24;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.WindowText;
            btnGuardar.Location = new Point(219, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 47);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(399, 61);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtFormaPago
            // 
            txtFormaPago.Location = new Point(538, 59);
            txtFormaPago.Name = "txtFormaPago";
            txtFormaPago.Size = new Size(250, 27);
            txtFormaPago.TabIndex = 2;
            txtFormaPago.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightGreen;
            label8.Location = new Point(11, 9);
            label8.Name = "label8";
            label8.Size = new Size(304, 23);
            label8.TabIndex = 18;
            label8.Text = "Administración Formas de Pago";
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(647, 103);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(142, 47);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblmensaje.ForeColor = Color.White;
            lblmensaje.Location = new Point(378, 128);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 22);
            lblmensaje.TabIndex = 19;
            // 
            // FormFormasPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(877, 462);
            Controls.Add(lblmensaje);
            Controls.Add(btnExportar);
            Controls.Add(label8);
            Controls.Add(txtFormaPago);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(txtId);
            Controls.Add(dgvFormasPago);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFormasPago";
            Text = "Administración Formas de Pago";
            ((System.ComponentModel.ISupportInitialize)dgvFormasPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)formasDePagoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvFormasPago;
        private TextBox txtId;
        private Button btnGuardar;
        private Label label2;
        private TextBox txtFormaPago;
        private BindingSource formasDePagoBindingSource;
        private Label label8;
        private Button btnExportar;
        private Label lblmensaje;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewImageColumn Eliminar;
    }
}