namespace SistemaPOS
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuPrincipal = new MenuStrip();
            gESTIÓNToolStripMenuItem = new ToolStripMenuItem();
            administrarFormasPagoToolStripMenuItem = new ToolStripMenuItem();
            administrarCargosToolStripMenuItem = new ToolStripMenuItem();
            administrarClientesToolStripMenuItem = new ToolStripMenuItem();
            administrarProductosToolStripMenuItem = new ToolStripMenuItem();
            administrarTipoIdentificaciónToolStripMenuItem = new ToolStripMenuItem();
            administrarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            consultarVentasToolStripMenuItem = new ToolStripMenuItem();
            fechahoraactual = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            fecha_hora_actual = new System.Windows.Forms.Timer(components);
            menuPrincipal.SuspendLayout();
            fechahoraactual.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { gESTIÓNToolStripMenuItem, ventasToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(1924, 35);
            menuPrincipal.TabIndex = 3;
            menuPrincipal.Text = "menuStrip1";
            // 
            // gESTIÓNToolStripMenuItem
            // 
            gESTIÓNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarFormasPagoToolStripMenuItem, administrarCargosToolStripMenuItem, administrarClientesToolStripMenuItem, administrarProductosToolStripMenuItem, administrarTipoIdentificaciónToolStripMenuItem, administrarUsuarioToolStripMenuItem });
            gESTIÓNToolStripMenuItem.Name = "gESTIÓNToolStripMenuItem";
            gESTIÓNToolStripMenuItem.Size = new Size(113, 31);
            gESTIÓNToolStripMenuItem.Text = "GESTIÓN";
            // 
            // administrarFormasPagoToolStripMenuItem
            // 
            administrarFormasPagoToolStripMenuItem.Image = (Image)resources.GetObject("administrarFormasPagoToolStripMenuItem.Image");
            administrarFormasPagoToolStripMenuItem.Name = "administrarFormasPagoToolStripMenuItem";
            administrarFormasPagoToolStripMenuItem.Size = new Size(376, 32);
            administrarFormasPagoToolStripMenuItem.Text = "Administrar Formas Pago";
            administrarFormasPagoToolStripMenuItem.Click += administrarFormasPagoToolStripMenuItem_Click;
            // 
            // administrarCargosToolStripMenuItem
            // 
            administrarCargosToolStripMenuItem.Image = Properties.Resources.icons8_trabajo_50;
            administrarCargosToolStripMenuItem.Name = "administrarCargosToolStripMenuItem";
            administrarCargosToolStripMenuItem.Size = new Size(376, 32);
            administrarCargosToolStripMenuItem.Text = "Administrar Cargos";
            administrarCargosToolStripMenuItem.Click += administrarCargosToolStripMenuItem_Click;
            // 
            // administrarClientesToolStripMenuItem
            // 
            administrarClientesToolStripMenuItem.Image = Properties.Resources.icons8_clientes_48;
            administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            administrarClientesToolStripMenuItem.Size = new Size(376, 32);
            administrarClientesToolStripMenuItem.Text = "Administrar Clientes";
            administrarClientesToolStripMenuItem.Click += administrarClientesToolStripMenuItem_Click;
            // 
            // administrarProductosToolStripMenuItem
            // 
            administrarProductosToolStripMenuItem.Image = Properties.Resources.icons8_productos_48;
            administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
            administrarProductosToolStripMenuItem.Size = new Size(376, 32);
            administrarProductosToolStripMenuItem.Text = "Administrar Productos";
            administrarProductosToolStripMenuItem.Click += administrarProductosToolStripMenuItem_Click;
            // 
            // administrarTipoIdentificaciónToolStripMenuItem
            // 
            administrarTipoIdentificaciónToolStripMenuItem.Image = Properties.Resources.icons8_tarjeta_de_identificación_40;
            administrarTipoIdentificaciónToolStripMenuItem.Name = "administrarTipoIdentificaciónToolStripMenuItem";
            administrarTipoIdentificaciónToolStripMenuItem.Size = new Size(376, 32);
            administrarTipoIdentificaciónToolStripMenuItem.Text = "Administrar Tipo Identificación";
            administrarTipoIdentificaciónToolStripMenuItem.Click += administrarTipoIdentificaciónToolStripMenuItem_Click;
            // 
            // administrarUsuarioToolStripMenuItem
            // 
            administrarUsuarioToolStripMenuItem.Image = Properties.Resources.icons8_usuarios_40;
            administrarUsuarioToolStripMenuItem.Name = "administrarUsuarioToolStripMenuItem";
            administrarUsuarioToolStripMenuItem.Size = new Size(376, 32);
            administrarUsuarioToolStripMenuItem.Text = "Administrar Usuario";
            administrarUsuarioToolStripMenuItem.Click += administrarUsuarioToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaciónToolStripMenuItem, consultarVentasToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(105, 31);
            ventasToolStripMenuItem.Text = "VENTAS";
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.Image = Properties.Resources.icons8_facturación_100;
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(252, 32);
            facturaciónToolStripMenuItem.Text = "Facturación";
            facturaciónToolStripMenuItem.Click += facturaciónToolStripMenuItem_Click;
            // 
            // consultarVentasToolStripMenuItem
            // 
            consultarVentasToolStripMenuItem.Image = Properties.Resources.icons8_búsqueda_100;
            consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            consultarVentasToolStripMenuItem.Size = new Size(252, 32);
            consultarVentasToolStripMenuItem.Text = "Consultar Ventas";
            consultarVentasToolStripMenuItem.Click += consultarVentasToolStripMenuItem_Click;
            // 
            // fechahoraactual
            // 
            fechahoraactual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fechahoraactual.ImageScalingSize = new Size(20, 20);
            fechahoraactual.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            fechahoraactual.Location = new Point(0, 911);
            fechahoraactual.Name = "fechahoraactual";
            fechahoraactual.Size = new Size(1924, 24);
            fechahoraactual.TabIndex = 5;
            fechahoraactual.Text = "Informacion";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 18);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 18);
            // 
            // fecha_hora_actual
            // 
            fecha_hora_actual.Enabled = true;
            fecha_hora_actual.Tick += fecha_hora_actual_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 935);
            Controls.Add(fechahoraactual);
            Controls.Add(menuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "FormPrincipal";
            Text = "Formulario Principal";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormPrincipal_FormClosed;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            fechahoraactual.ResumeLayout(false);
            fechahoraactual.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem gESTIÓNToolStripMenuItem;
        private ToolStripMenuItem administrarFormasPagoToolStripMenuItem;
        private ToolStripMenuItem administrarCargosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private StatusStrip fechahoraactual;
        private ToolStripMenuItem consultarVentasToolStripMenuItem;
        private ToolStripMenuItem administrarClientesToolStripMenuItem;
        private ToolStripMenuItem administrarProductosToolStripMenuItem;
        private ToolStripMenuItem administrarTipoIdentificaciónToolStripMenuItem;
        private ToolStripMenuItem administrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Timer fecha_hora_actual;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}