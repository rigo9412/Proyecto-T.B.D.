namespace ProyectoTBD
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.cotxMenuSesion = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroEmpleados = new MetroFramework.Controls.MetroTile();
            this.metroVentas = new MetroFramework.Controls.MetroTile();
            this.metroProductos = new MetroFramework.Controls.MetroTile();
            this.metroProveedores = new MetroFramework.Controls.MetroTile();
            this.metroClientes = new MetroFramework.Controls.MetroTile();
            this.metroReportes = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(832, 41);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 55);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseClick);
            // 
            // cotxMenuSesion
            // 
            this.cotxMenuSesion.Name = "cotxMenuSesion";
            this.cotxMenuSesion.Size = new System.Drawing.Size(61, 4);
            this.cotxMenuSesion.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cotxMenuSesion_ItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.ico");
            this.imageList1.Images.SetKeyName(1, "1449893080_add_blue.png");
            // 
            // metroEmpleados
            // 
            this.metroEmpleados.ActiveControl = null;
            this.metroEmpleados.BackColor = System.Drawing.Color.LimeGreen;
            this.metroEmpleados.Controls.Add(this.pictureBox1);
            this.metroEmpleados.Location = new System.Drawing.Point(151, 178);
            this.metroEmpleados.Name = "metroEmpleados";
            this.metroEmpleados.Size = new System.Drawing.Size(212, 113);
            this.metroEmpleados.TabIndex = 2;
            this.metroEmpleados.Text = "Empleados";
            this.metroEmpleados.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroEmpleados.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroEmpleados.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroEmpleados.UseCustomBackColor = true;
            this.metroEmpleados.UseSelectable = true;
            this.metroEmpleados.UseStyleColors = true;
            this.metroEmpleados.UseTileImage = true;
            this.metroEmpleados.Click += new System.EventHandler(this.metroEmpleados_Click);
            // 
            // metroVentas
            // 
            this.metroVentas.ActiveControl = null;
            this.metroVentas.Location = new System.Drawing.Point(369, 178);
            this.metroVentas.Name = "metroVentas";
            this.metroVentas.Size = new System.Drawing.Size(212, 113);
            this.metroVentas.TabIndex = 9;
            this.metroVentas.Text = "Ventas";
            this.metroVentas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroVentas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroVentas.UseSelectable = true;
            this.metroVentas.UseStyleColors = true;
            this.metroVentas.UseTileImage = true;
            this.metroVentas.Click += new System.EventHandler(this.metroVentas_Click);
            // 
            // metroProductos
            // 
            this.metroProductos.ActiveControl = null;
            this.metroProductos.Location = new System.Drawing.Point(587, 180);
            this.metroProductos.Name = "metroProductos";
            this.metroProductos.Size = new System.Drawing.Size(212, 113);
            this.metroProductos.TabIndex = 10;
            this.metroProductos.Text = "Productos";
            this.metroProductos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroProductos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroProductos.UseSelectable = true;
            this.metroProductos.UseStyleColors = true;
            this.metroProductos.UseTileImage = true;
            this.metroProductos.Click += new System.EventHandler(this.metroProductos_Click);
            // 
            // metroProveedores
            // 
            this.metroProveedores.ActiveControl = null;
            this.metroProveedores.Location = new System.Drawing.Point(587, 312);
            this.metroProveedores.Name = "metroProveedores";
            this.metroProveedores.Size = new System.Drawing.Size(212, 113);
            this.metroProveedores.TabIndex = 11;
            this.metroProveedores.Text = "Proveedores";
            this.metroProveedores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroProveedores.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroProveedores.UseSelectable = true;
            this.metroProveedores.UseStyleColors = true;
            this.metroProveedores.UseTileImage = true;
            this.metroProveedores.Click += new System.EventHandler(this.metroProveedores_Click);
            // 
            // metroClientes
            // 
            this.metroClientes.ActiveControl = null;
            this.metroClientes.Location = new System.Drawing.Point(369, 312);
            this.metroClientes.Name = "metroClientes";
            this.metroClientes.Size = new System.Drawing.Size(212, 113);
            this.metroClientes.TabIndex = 12;
            this.metroClientes.Text = "Clientes";
            this.metroClientes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroClientes.UseSelectable = true;
            this.metroClientes.UseStyleColors = true;
            this.metroClientes.UseTileImage = true;
            this.metroClientes.Click += new System.EventHandler(this.metroClientes_Click);
            // 
            // metroReportes
            // 
            this.metroReportes.ActiveControl = null;
            this.metroReportes.Location = new System.Drawing.Point(151, 312);
            this.metroReportes.Name = "metroReportes";
            this.metroReportes.Size = new System.Drawing.Size(212, 113);
            this.metroReportes.TabIndex = 13;
            this.metroReportes.Text = "Reportes";
            this.metroReportes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroReportes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroReportes.UseSelectable = true;
            this.metroReportes.UseStyleColors = true;
            this.metroReportes.UseTileImage = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoTBD.Properties.Resources._1449894352_user_manage;
            this.pictureBox1.Location = new System.Drawing.Point(70, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 552);
            this.ControlBox = false;
            this.Controls.Add(this.metroReportes);
            this.Controls.Add(this.metroClientes);
            this.Controls.Add(this.metroProveedores);
            this.Controls.Add(this.metroProductos);
            this.Controls.Add(this.metroVentas);
            this.Controls.Add(this.metroEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.metroEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroContextMenu cotxMenuSesion;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroTile metroEmpleados;
        private MetroFramework.Controls.MetroTile metroVentas;
        private MetroFramework.Controls.MetroTile metroProductos;
        private MetroFramework.Controls.MetroTile metroProveedores;
        private MetroFramework.Controls.MetroTile metroClientes;
        private MetroFramework.Controls.MetroTile metroReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}