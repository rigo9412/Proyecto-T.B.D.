namespace ProyectoTBD
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.btnRegresarMenu = new MetroFramework.Controls.MetroButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.CtxMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.checkActivos = new MetroFramework.Controls.MetroToggle();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtMarcaProduto = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtCantidadProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreProducto = new MetroFramework.Controls.MetroTextBox();
            this.comboCategoria = new MetroFramework.Controls.MetroComboBox();
            this.comboProveedor = new MetroFramework.Controls.MetroComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(817, 63);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(200, 54);
            this.btnRegresarMenu.TabIndex = 11;
            this.btnRegresarMenu.Text = "REGRESAR";
            this.btnRegresarMenu.UseSelectable = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(690, 179);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(187, 23);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(893, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(58, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(153, 60);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "+ producto";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(111, 229);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(844, 332);
            this.grid.TabIndex = 7;
            this.grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridProductos_MouseClick);
            // 
            // CtxMenu
            // 
            this.CtxMenu.Name = "CtxMenuProducto";
            this.CtxMenu.Size = new System.Drawing.Size(61, 4);
            this.CtxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CtxMenuProducto_ItemClicked);
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Checked = true;
            this.checkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivos.Location = new System.Drawing.Point(587, 184);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(80, 17);
            this.checkActivos.TabIndex = 13;
            this.checkActivos.Text = "On";
            this.checkActivos.UseSelectable = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.lblTitulo);
            this.Panel.Controls.Add(this.btnGuardar);
            this.Panel.Controls.Add(this.btnCancelar);
            this.Panel.Controls.Add(this.metroLabel6);
            this.Panel.Controls.Add(this.metroLabel5);
            this.Panel.Controls.Add(this.metroLabel4);
            this.Panel.Controls.Add(this.metroLabel3);
            this.Panel.Controls.Add(this.metroLabel2);
            this.Panel.Controls.Add(this.metroLabel1);
            this.Panel.Controls.Add(this.txtMarcaProduto);
            this.Panel.Controls.Add(this.txtPrecioProducto);
            this.Panel.Controls.Add(this.txtCantidadProducto);
            this.Panel.Controls.Add(this.txtNombreProducto);
            this.Panel.Controls.Add(this.comboCategoria);
            this.Panel.Controls.Add(this.comboProveedor);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(7, 6);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(17, 23);
            this.Panel.TabIndex = 14;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(49, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(83, 19);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "metroLabel7";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(944, 529);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 45);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(808, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 45);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(489, 177);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Proveedor";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(489, 254);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Categoria";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(201, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Marca";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(201, 320);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Precio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(201, 393);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Cantidad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(201, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Nombre";
            // 
            // txtMarcaProduto
            // 
            // 
            // 
            // 
            this.txtMarcaProduto.CustomButton.Image = null;
            this.txtMarcaProduto.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtMarcaProduto.CustomButton.Name = "";
            this.txtMarcaProduto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMarcaProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarcaProduto.CustomButton.TabIndex = 1;
            this.txtMarcaProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarcaProduto.CustomButton.UseSelectable = true;
            this.txtMarcaProduto.CustomButton.Visible = false;
            this.txtMarcaProduto.Lines = new string[] {
        " "};
            this.txtMarcaProduto.Location = new System.Drawing.Point(201, 275);
            this.txtMarcaProduto.MaxLength = 32767;
            this.txtMarcaProduto.Name = "txtMarcaProduto";
            this.txtMarcaProduto.PasswordChar = '\0';
            this.txtMarcaProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarcaProduto.SelectedText = "";
            this.txtMarcaProduto.SelectionLength = 0;
            this.txtMarcaProduto.SelectionStart = 0;
            this.txtMarcaProduto.Size = new System.Drawing.Size(219, 30);
            this.txtMarcaProduto.TabIndex = 7;
            this.txtMarcaProduto.Text = " ";
            this.txtMarcaProduto.UseSelectable = true;
            this.txtMarcaProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarcaProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrecioProducto
            // 
            // 
            // 
            // 
            this.txtPrecioProducto.CustomButton.Image = null;
            this.txtPrecioProducto.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtPrecioProducto.CustomButton.Name = "";
            this.txtPrecioProducto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrecioProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioProducto.CustomButton.TabIndex = 1;
            this.txtPrecioProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioProducto.CustomButton.UseSelectable = true;
            this.txtPrecioProducto.CustomButton.Visible = false;
            this.txtPrecioProducto.Lines = new string[] {
        " "};
            this.txtPrecioProducto.Location = new System.Drawing.Point(201, 342);
            this.txtPrecioProducto.MaxLength = 32767;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.PasswordChar = '\0';
            this.txtPrecioProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioProducto.SelectedText = "";
            this.txtPrecioProducto.SelectionLength = 0;
            this.txtPrecioProducto.SelectionStart = 0;
            this.txtPrecioProducto.Size = new System.Drawing.Size(219, 30);
            this.txtPrecioProducto.TabIndex = 6;
            this.txtPrecioProducto.Text = " ";
            this.txtPrecioProducto.UseSelectable = true;
            this.txtPrecioProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCantidadProducto
            // 
            // 
            // 
            // 
            this.txtCantidadProducto.CustomButton.Image = null;
            this.txtCantidadProducto.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtCantidadProducto.CustomButton.Name = "";
            this.txtCantidadProducto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCantidadProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadProducto.CustomButton.TabIndex = 1;
            this.txtCantidadProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadProducto.CustomButton.UseSelectable = true;
            this.txtCantidadProducto.CustomButton.Visible = false;
            this.txtCantidadProducto.Lines = new string[] {
        " "};
            this.txtCantidadProducto.Location = new System.Drawing.Point(201, 415);
            this.txtCantidadProducto.MaxLength = 32767;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.PasswordChar = '\0';
            this.txtCantidadProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadProducto.SelectedText = "";
            this.txtCantidadProducto.SelectionLength = 0;
            this.txtCantidadProducto.SelectionStart = 0;
            this.txtCantidadProducto.Size = new System.Drawing.Size(219, 30);
            this.txtCantidadProducto.TabIndex = 5;
            this.txtCantidadProducto.Text = " ";
            this.txtCantidadProducto.UseSelectable = true;
            this.txtCantidadProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreProducto
            // 
            // 
            // 
            // 
            this.txtNombreProducto.CustomButton.Image = null;
            this.txtNombreProducto.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtNombreProducto.CustomButton.Name = "";
            this.txtNombreProducto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNombreProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProducto.CustomButton.TabIndex = 1;
            this.txtNombreProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProducto.CustomButton.UseSelectable = true;
            this.txtNombreProducto.CustomButton.Visible = false;
            this.txtNombreProducto.Lines = new string[] {
        " "};
            this.txtNombreProducto.Location = new System.Drawing.Point(201, 198);
            this.txtNombreProducto.MaxLength = 32767;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(219, 30);
            this.txtNombreProducto.TabIndex = 4;
            this.txtNombreProducto.Text = " ";
            this.txtNombreProducto.UseSelectable = true;
            this.txtNombreProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.ItemHeight = 23;
            this.comboCategoria.Location = new System.Drawing.Point(489, 276);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(205, 29);
            this.comboCategoria.TabIndex = 3;
            this.comboCategoria.UseSelectable = true;
            // 
            // comboProveedor
            // 
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.ItemHeight = 23;
            this.comboProveedor.Location = new System.Drawing.Point(489, 199);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(205, 29);
            this.comboProveedor.TabIndex = 2;
            this.comboProveedor.UseSelectable = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.png");
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 631);
            this.ControlBox = false;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grid);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegresarMenu;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroGrid grid;
        private MetroFramework.Controls.MetroContextMenu CtxMenu;
        private MetroFramework.Controls.MetroToggle checkActivos;
        private MetroFramework.Controls.MetroPanel Panel;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMarcaProduto;
        private MetroFramework.Controls.MetroTextBox txtPrecioProducto;
        private MetroFramework.Controls.MetroTextBox txtCantidadProducto;
        private MetroFramework.Controls.MetroTextBox txtNombreProducto;
        private MetroFramework.Controls.MetroComboBox comboCategoria;
        private MetroFramework.Controls.MetroComboBox comboProveedor;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private System.Windows.Forms.ImageList imageList1;
    }
}