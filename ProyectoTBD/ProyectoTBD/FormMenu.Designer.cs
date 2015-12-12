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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroVentas = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroProductos = new MetroFramework.Controls.MetroTile();
            this.metroProveedores = new MetroFramework.Controls.MetroTile();
            this.metroClientes = new MetroFramework.Controls.MetroTile();
            this.metroReportes = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.metroEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroProductos.SuspendLayout();
            this.metroProveedores.SuspendLayout();
            this.metroClientes.SuspendLayout();
            this.metroReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.metroEmpleados.Location = new System.Drawing.Point(151, 180);
            this.metroEmpleados.Name = "metroEmpleados";
            this.metroEmpleados.Size = new System.Drawing.Size(212, 113);
            this.metroEmpleados.TabIndex = 2;
            this.metroEmpleados.Text = "Empleados";
            this.metroEmpleados.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroEmpleados.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroEmpleados.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroEmpleados.UseCustomBackColor = true;
            this.metroEmpleados.UseSelectable = true;
            this.metroEmpleados.UseStyleColors = true;
            this.metroEmpleados.UseTileImage = true;
            this.metroEmpleados.Click += new System.EventHandler(this.metroEmpleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroVentas
            // 
            this.metroVentas.ActiveControl = null;
            this.metroVentas.BackColor = System.Drawing.Color.Teal;
            this.metroVentas.Controls.Add(this.pictureBox2);
            this.metroVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroVentas.Location = new System.Drawing.Point(369, 178);
            this.metroVentas.Name = "metroVentas";
            this.metroVentas.Size = new System.Drawing.Size(212, 113);
            this.metroVentas.TabIndex = 9;
            this.metroVentas.Text = "Ventas";
            this.metroVentas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroVentas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroVentas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroVentas.UseCustomBackColor = true;
            this.metroVentas.UseSelectable = true;
            this.metroVentas.UseStyleColors = true;
            this.metroVentas.UseTileImage = true;
            this.metroVentas.Click += new System.EventHandler(this.metroVentas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 75);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroProductos
            // 
            this.metroProductos.ActiveControl = null;
            this.metroProductos.BackColor = System.Drawing.Color.MediumPurple;
            this.metroProductos.Controls.Add(this.pictureBox3);
            this.metroProductos.Location = new System.Drawing.Point(587, 180);
            this.metroProductos.Name = "metroProductos";
            this.metroProductos.Size = new System.Drawing.Size(212, 113);
            this.metroProductos.TabIndex = 10;
            this.metroProductos.Text = "Productos";
            this.metroProductos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroProductos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroProductos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroProductos.UseCustomBackColor = true;
            this.metroProductos.UseSelectable = true;
            this.metroProductos.UseStyleColors = true;
            this.metroProductos.UseTileImage = true;
            this.metroProductos.Click += new System.EventHandler(this.metroProductos_Click);
            // 
            // metroProveedores
            // 
            this.metroProveedores.ActiveControl = null;
            this.metroProveedores.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroProveedores.Controls.Add(this.pictureBox6);
            this.metroProveedores.Location = new System.Drawing.Point(587, 312);
            this.metroProveedores.Name = "metroProveedores";
            this.metroProveedores.Size = new System.Drawing.Size(212, 113);
            this.metroProveedores.TabIndex = 11;
            this.metroProveedores.Text = "Proveedores";
            this.metroProveedores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroProveedores.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroProveedores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroProveedores.UseCustomBackColor = true;
            this.metroProveedores.UseSelectable = true;
            this.metroProveedores.UseStyleColors = true;
            this.metroProveedores.UseTileImage = true;
            this.metroProveedores.Click += new System.EventHandler(this.metroProveedores_Click);
            // 
            // metroClientes
            // 
            this.metroClientes.ActiveControl = null;
            this.metroClientes.BackColor = System.Drawing.Color.Orange;
            this.metroClientes.Controls.Add(this.pictureBox5);
            this.metroClientes.Location = new System.Drawing.Point(369, 312);
            this.metroClientes.Name = "metroClientes";
            this.metroClientes.Size = new System.Drawing.Size(212, 113);
            this.metroClientes.TabIndex = 12;
            this.metroClientes.Text = "Clientes";
            this.metroClientes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroClientes.UseCustomBackColor = true;
            this.metroClientes.UseSelectable = true;
            this.metroClientes.UseStyleColors = true;
            this.metroClientes.UseTileImage = true;
            this.metroClientes.Click += new System.EventHandler(this.metroClientes_Click);
            // 
            // metroReportes
            // 
            this.metroReportes.ActiveControl = null;
            this.metroReportes.Controls.Add(this.pictureBox4);
            this.metroReportes.Location = new System.Drawing.Point(151, 312);
            this.metroReportes.Name = "metroReportes";
            this.metroReportes.Size = new System.Drawing.Size(212, 113);
            this.metroReportes.TabIndex = 13;
            this.metroReportes.Text = "Reportes";
            this.metroReportes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroReportes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroReportes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroReportes.UseSelectable = true;
            this.metroReportes.UseStyleColors = true;
            this.metroReportes.UseTileImage = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(70, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 75);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(70, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 75);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(70, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(88, 75);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(70, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 75);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
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
            this.metroVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroProductos.ResumeLayout(false);
            this.metroProveedores.ResumeLayout(false);
            this.metroClientes.ResumeLayout(false);
            this.metroReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}