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
            this.cotxMenuSesion = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroProveedores = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroVentas = new MetroFramework.Controls.MetroTile();
            this.metroReportes = new MetroFramework.Controls.MetroTile();
            this.metroClientes = new MetroFramework.Controls.MetroTile();
            this.metroProductos = new MetroFramework.Controls.MetroTile();
            this.metroEmpleados = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.metroProveedores.SuspendLayout();
            this.metroVentas.SuspendLayout();
            this.metroReportes.SuspendLayout();
            this.metroClientes.SuspendLayout();
            this.metroProductos.SuspendLayout();
            this.metroEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // cotxMenuSesion
            // 
            this.cotxMenuSesion.Name = "cotxMenuSesion";
            this.cotxMenuSesion.Size = new System.Drawing.Size(61, 4);
            this.cotxMenuSesion.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cotxMenuSesion_ItemClicked);
            // 
            // metroProveedores
            // 
            this.metroProveedores.ActiveControl = null;
            this.metroProveedores.BackColor = System.Drawing.Color.Gold;
            this.metroProveedores.Controls.Add(this.pictureBox1);
            this.metroProveedores.Location = new System.Drawing.Point(23, 191);
            this.metroProveedores.Name = "metroProveedores";
            this.metroProveedores.Size = new System.Drawing.Size(237, 109);
            this.metroProveedores.TabIndex = 1;
            this.metroProveedores.Text = "Proveedores";
            this.metroProveedores.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroProveedores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroProveedores.UseCustomBackColor = true;
            this.metroProveedores.UseSelectable = true;
            this.metroProveedores.Click += new System.EventHandler(this.metroProveedores_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(690, 37);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 55);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = " ";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseClick);
            // 
            // metroVentas
            // 
            this.metroVentas.ActiveControl = null;
            this.metroVentas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.metroVentas.Controls.Add(this.pictureBox2);
            this.metroVentas.Location = new System.Drawing.Point(277, 191);
            this.metroVentas.Name = "metroVentas";
            this.metroVentas.Size = new System.Drawing.Size(237, 109);
            this.metroVentas.TabIndex = 3;
            this.metroVentas.Text = "Ventas";
            this.metroVentas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroVentas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroVentas.UseCustomBackColor = true;
            this.metroVentas.UseSelectable = true;
            this.metroVentas.Click += new System.EventHandler(this.metroVentas_Click);
            // 
            // metroReportes
            // 
            this.metroReportes.ActiveControl = null;
            this.metroReportes.BackColor = System.Drawing.Color.OliveDrab;
            this.metroReportes.Controls.Add(this.pictureBox4);
            this.metroReportes.Location = new System.Drawing.Point(23, 317);
            this.metroReportes.Name = "metroReportes";
            this.metroReportes.Size = new System.Drawing.Size(237, 109);
            this.metroReportes.TabIndex = 4;
            this.metroReportes.Text = "Reportes";
            this.metroReportes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroReportes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroReportes.UseCustomBackColor = true;
            this.metroReportes.UseSelectable = true;
            this.metroReportes.Click += new System.EventHandler(this.metroReportes_Click);
            // 
            // metroClientes
            // 
            this.metroClientes.ActiveControl = null;
            this.metroClientes.BackColor = System.Drawing.Color.DarkCyan;
            this.metroClientes.Controls.Add(this.pictureBox5);
            this.metroClientes.Location = new System.Drawing.Point(277, 317);
            this.metroClientes.Name = "metroClientes";
            this.metroClientes.Size = new System.Drawing.Size(237, 109);
            this.metroClientes.TabIndex = 5;
            this.metroClientes.Text = "Clientes";
            this.metroClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroClientes.UseCustomBackColor = true;
            this.metroClientes.UseSelectable = true;
            this.metroClientes.Click += new System.EventHandler(this.metroClientes_Click);
            // 
            // metroProductos
            // 
            this.metroProductos.ActiveControl = null;
            this.metroProductos.BackColor = System.Drawing.Color.Firebrick;
            this.metroProductos.Controls.Add(this.pictureBox3);
            this.metroProductos.Location = new System.Drawing.Point(533, 191);
            this.metroProductos.Name = "metroProductos";
            this.metroProductos.Size = new System.Drawing.Size(237, 109);
            this.metroProductos.TabIndex = 6;
            this.metroProductos.Text = "Productos";
            this.metroProductos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroProductos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroProductos.UseCustomBackColor = true;
            this.metroProductos.UseSelectable = true;
            this.metroProductos.Click += new System.EventHandler(this.metroProductos_Click);
            // 
            // metroEmpleados
            // 
            this.metroEmpleados.ActiveControl = null;
            this.metroEmpleados.BackColor = System.Drawing.Color.SteelBlue;
            this.metroEmpleados.Controls.Add(this.pictureBox6);
            this.metroEmpleados.Location = new System.Drawing.Point(533, 317);
            this.metroEmpleados.Name = "metroEmpleados";
            this.metroEmpleados.Size = new System.Drawing.Size(237, 109);
            this.metroEmpleados.TabIndex = 7;
            this.metroEmpleados.Text = "Empleados";
            this.metroEmpleados.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroEmpleados.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroEmpleados.UseCustomBackColor = true;
            this.metroEmpleados.UseSelectable = true;
            this.metroEmpleados.Click += new System.EventHandler(this.metroEmpleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 60);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(70, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 60);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(70, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 60);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(70, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 60);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(70, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 60);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 525);
            this.ControlBox = false;
            this.Controls.Add(this.metroEmpleados);
            this.Controls.Add(this.metroProductos);
            this.Controls.Add(this.metroClientes);
            this.Controls.Add(this.metroReportes);
            this.Controls.Add(this.metroVentas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.metroProveedores);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.metroProveedores.ResumeLayout(false);
            this.metroVentas.ResumeLayout(false);
            this.metroReportes.ResumeLayout(false);
            this.metroClientes.ResumeLayout(false);
            this.metroProductos.ResumeLayout(false);
            this.metroEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu cotxMenuSesion;
        private MetroFramework.Controls.MetroTile metroProveedores;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroTile metroVentas;
        private MetroFramework.Controls.MetroTile metroReportes;
        private MetroFramework.Controls.MetroTile metroClientes;
        private MetroFramework.Controls.MetroTile metroProductos;
        private MetroFramework.Controls.MetroTile metroEmpleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}