namespace ProyectoTBD
{
    partial class FormProveedores
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
            this.checkActivos = new MetroFramework.Controls.MetroToggle();
            this.btnRegresarMenu = new MetroFramework.Controls.MetroButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRFC = new MetroFramework.Controls.MetroTextBox();
            this.txtColonia = new MetroFramework.Controls.MetroTextBox();
            this.txtCP = new MetroFramework.Controls.MetroTextBox();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtCalle = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.CtxMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.comboEstado = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Location = new System.Drawing.Point(678, 201);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(80, 17);
            this.checkActivos.TabIndex = 19;
            this.checkActivos.Text = "Off";
            this.checkActivos.UseSelectable = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(908, 80);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(200, 54);
            this.btnRegresarMenu.TabIndex = 18;
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
            this.txtBuscar.Location = new System.Drawing.Point(781, 196);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(187, 23);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(984, 196);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(149, 94);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(153, 60);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "+ Proveedor";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToResizeRows = false;
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
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.grid.Location = new System.Drawing.Point(202, 246);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(844, 332);
            this.grid.TabIndex = 14;
            this.grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridProveedores_MouseClick);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.comboEstado);
            this.Panel.Controls.Add(this.btnGuardar);
            this.Panel.Controls.Add(this.btnCancelar);
            this.Panel.Controls.Add(this.lblTitulo);
            this.Panel.Controls.Add(this.metroLabel6);
            this.Panel.Controls.Add(this.metroLabel5);
            this.Panel.Controls.Add(this.metroLabel4);
            this.Panel.Controls.Add(this.metroLabel3);
            this.Panel.Controls.Add(this.metroLabel2);
            this.Panel.Controls.Add(this.metroLabel1);
            this.Panel.Controls.Add(this.txtRFC);
            this.Panel.Controls.Add(this.txtColonia);
            this.Panel.Controls.Add(this.txtCP);
            this.Panel.Controls.Add(this.txtNumero);
            this.Panel.Controls.Add(this.txtCalle);
            this.Panel.Controls.Add(this.txtNombre);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(6, 11);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(26, 16);
            this.Panel.TabIndex = 20;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1048, 554);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 59);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(870, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 59);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(37, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(83, 19);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "metroLabel7";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(553, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "RFC";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(553, 313);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Colonia";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(320, 317);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Codigo Postal";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(553, 242);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Numero";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(320, 242);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Calle";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(320, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Nombre";
            // 
            // txtRFC
            // 
            // 
            // 
            // 
            this.txtRFC.CustomButton.Image = null;
            this.txtRFC.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtRFC.CustomButton.Name = "";
            this.txtRFC.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRFC.CustomButton.TabIndex = 1;
            this.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRFC.CustomButton.UseSelectable = true;
            this.txtRFC.CustomButton.Visible = false;
            this.txtRFC.Lines = new string[0];
            this.txtRFC.Location = new System.Drawing.Point(553, 193);
            this.txtRFC.MaxLength = 32767;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PasswordChar = '\0';
            this.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRFC.SelectedText = "";
            this.txtRFC.SelectionLength = 0;
            this.txtRFC.SelectionStart = 0;
            this.txtRFC.Size = new System.Drawing.Size(200, 30);
            this.txtRFC.TabIndex = 7;
            this.txtRFC.UseSelectable = true;
            this.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRFC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtColonia
            // 
            // 
            // 
            // 
            this.txtColonia.CustomButton.Image = null;
            this.txtColonia.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtColonia.CustomButton.Name = "";
            this.txtColonia.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColonia.CustomButton.TabIndex = 1;
            this.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColonia.CustomButton.UseSelectable = true;
            this.txtColonia.CustomButton.Visible = false;
            this.txtColonia.Lines = new string[0];
            this.txtColonia.Location = new System.Drawing.Point(553, 339);
            this.txtColonia.MaxLength = 32767;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.PasswordChar = '\0';
            this.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColonia.SelectedText = "";
            this.txtColonia.SelectionLength = 0;
            this.txtColonia.SelectionStart = 0;
            this.txtColonia.Size = new System.Drawing.Size(200, 30);
            this.txtColonia.TabIndex = 6;
            this.txtColonia.UseSelectable = true;
            this.txtColonia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColonia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCP
            // 
            // 
            // 
            // 
            this.txtCP.CustomButton.Image = null;
            this.txtCP.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtCP.CustomButton.Name = "";
            this.txtCP.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCP.CustomButton.TabIndex = 1;
            this.txtCP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCP.CustomButton.UseSelectable = true;
            this.txtCP.CustomButton.Visible = false;
            this.txtCP.Lines = new string[0];
            this.txtCP.Location = new System.Drawing.Point(320, 339);
            this.txtCP.MaxLength = 32767;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '\0';
            this.txtCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCP.SelectedText = "";
            this.txtCP.SelectionLength = 0;
            this.txtCP.SelectionStart = 0;
            this.txtCP.Size = new System.Drawing.Size(200, 30);
            this.txtCP.TabIndex = 5;
            this.txtCP.UseSelectable = true;
            this.txtCP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumero
            // 
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(553, 264);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(200, 30);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCalle
            // 
            // 
            // 
            // 
            this.txtCalle.CustomButton.Image = null;
            this.txtCalle.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtCalle.CustomButton.Name = "";
            this.txtCalle.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCalle.CustomButton.TabIndex = 1;
            this.txtCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCalle.CustomButton.UseSelectable = true;
            this.txtCalle.CustomButton.Visible = false;
            this.txtCalle.Lines = new string[0];
            this.txtCalle.Location = new System.Drawing.Point(320, 264);
            this.txtCalle.MaxLength = 32767;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.Size = new System.Drawing.Size(200, 30);
            this.txtCalle.TabIndex = 3;
            this.txtCalle.UseSelectable = true;
            this.txtCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(320, 193);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(200, 30);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CtxMenu
            // 
            this.CtxMenu.Name = "metroContextMenu";
            this.CtxMenu.Size = new System.Drawing.Size(61, 4);
            this.CtxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.metroContextMenu1_ItemClicked);
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.ItemHeight = 23;
            this.comboEstado.Location = new System.Drawing.Point(811, 193);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(206, 29);
            this.comboEstado.TabIndex = 17;
            this.comboEstado.UseSelectable = true;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 670);
            this.ControlBox = false;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grid);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle checkActivos;
        private MetroFramework.Controls.MetroButton btnRegresarMenu;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroGrid grid;
        private MetroFramework.Controls.MetroPanel Panel;
        private MetroFramework.Controls.MetroContextMenu CtxMenu;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRFC;
        private MetroFramework.Controls.MetroTextBox txtColonia;
        private MetroFramework.Controls.MetroTextBox txtCP;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroTextBox txtCalle;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroComboBox comboEstado;
    }
}