namespace ProyectoTBD
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.CotxMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.btnRegresarMenu = new MetroFramework.Controls.MetroButton();
            this.checkActivos = new MetroFramework.Controls.MetroToggle();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.txtRFC = new MetroFramework.Controls.MetroTextBox();
            this.txtCP = new MetroFramework.Controls.MetroTextBox();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtColonia = new MetroFramework.Controls.MetroTextBox();
            this.txtCalle = new MetroFramework.Controls.MetroTextBox();
            this.txtAm = new MetroFramework.Controls.MetroTextBox();
            this.txtAp = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.DateFechaNacimiento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.radHombre = new MetroFramework.Controls.MetroRadioButton();
            this.radMujer = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle17;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(116, 232);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(844, 332);
            this.grid.TabIndex = 0;
            this.grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridClientes_MouseClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(34, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(153, 60);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "+ Cliente";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // CotxMenu
            // 
            this.CotxMenu.Name = "CotxMenu";
            this.CotxMenu.Size = new System.Drawing.Size(61, 4);
            this.CotxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CotxMenu_ItemClicked);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(885, 173);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarCliente_Click);
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
            this.txtBuscar.Location = new System.Drawing.Point(682, 173);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(187, 23);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(792, 53);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(200, 54);
            this.btnRegresarMenu.TabIndex = 6;
            this.btnRegresarMenu.Text = "REGRESAR";
            this.btnRegresarMenu.UseSelectable = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Checked = true;
            this.checkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivos.Location = new System.Drawing.Point(572, 177);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(80, 17);
            this.checkActivos.TabIndex = 14;
            this.checkActivos.Text = "On";
            this.checkActivos.UseSelectable = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.metroLabel10);
            this.Panel.Controls.Add(this.radMujer);
            this.Panel.Controls.Add(this.radHombre);
            this.Panel.Controls.Add(this.metroLabel1);
            this.Panel.Controls.Add(this.DateFechaNacimiento);
            this.Panel.Controls.Add(this.metroLabel9);
            this.Panel.Controls.Add(this.metroLabel8);
            this.Panel.Controls.Add(this.metroLabel7);
            this.Panel.Controls.Add(this.metroLabel6);
            this.Panel.Controls.Add(this.metroLabel5);
            this.Panel.Controls.Add(this.metroLabel4);
            this.Panel.Controls.Add(this.metroLabel3);
            this.Panel.Controls.Add(this.metroLabel2);
            this.Panel.Controls.Add(this.btnCancelar);
            this.Panel.Controls.Add(this.btnGuardar);
            this.Panel.Controls.Add(this.lblTitulo);
            this.Panel.Controls.Add(this.txtRFC);
            this.Panel.Controls.Add(this.txtCP);
            this.Panel.Controls.Add(this.txtNumero);
            this.Panel.Controls.Add(this.txtColonia);
            this.Panel.Controls.Add(this.txtCalle);
            this.Panel.Controls.Add(this.txtAm);
            this.Panel.Controls.Add(this.txtAp);
            this.Panel.Controls.Add(this.txtNombre);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(5, 22);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(10, 19);
            this.Panel.TabIndex = 15;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(151, 160);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "Apellido Paterno";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(151, 217);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "Apellido Materno";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(151, 283);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "RFC";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(611, 272);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Codigo Postal";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(611, 217);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Numero";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(611, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Colonia";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(611, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Calle";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(151, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(679, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 50);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(823, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 50);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitulo.Location = new System.Drawing.Point(113, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 25);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "metroLabel1";
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
            this.txtRFC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRFC.Lines = new string[0];
            this.txtRFC.Location = new System.Drawing.Point(151, 305);
            this.txtRFC.MaxLength = 32767;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PasswordChar = '\0';
            this.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRFC.SelectedText = "";
            this.txtRFC.SelectionLength = 0;
            this.txtRFC.SelectionStart = 0;
            this.txtRFC.Size = new System.Drawing.Size(200, 30);
            this.txtRFC.TabIndex = 28;
            this.txtRFC.UseSelectable = true;
            this.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRFC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtCP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCP.Lines = new string[0];
            this.txtCP.Location = new System.Drawing.Point(611, 293);
            this.txtCP.MaxLength = 32767;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '\0';
            this.txtCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCP.SelectedText = "";
            this.txtCP.SelectionLength = 0;
            this.txtCP.SelectionStart = 0;
            this.txtCP.Size = new System.Drawing.Size(200, 30);
            this.txtCP.TabIndex = 27;
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
            this.txtNumero.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(611, 239);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(200, 30);
            this.txtNumero.TabIndex = 26;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtColonia.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtColonia.Lines = new string[0];
            this.txtColonia.Location = new System.Drawing.Point(611, 186);
            this.txtColonia.MaxLength = 32767;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.PasswordChar = '\0';
            this.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColonia.SelectedText = "";
            this.txtColonia.SelectionLength = 0;
            this.txtColonia.SelectionStart = 0;
            this.txtColonia.Size = new System.Drawing.Size(200, 30);
            this.txtColonia.TabIndex = 25;
            this.txtColonia.UseSelectable = true;
            this.txtColonia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColonia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtCalle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCalle.Lines = new string[0];
            this.txtCalle.Location = new System.Drawing.Point(611, 127);
            this.txtCalle.MaxLength = 32767;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.Size = new System.Drawing.Size(200, 30);
            this.txtCalle.TabIndex = 24;
            this.txtCalle.UseSelectable = true;
            this.txtCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAm
            // 
            // 
            // 
            // 
            this.txtAm.CustomButton.Image = null;
            this.txtAm.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtAm.CustomButton.Name = "";
            this.txtAm.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAm.CustomButton.TabIndex = 1;
            this.txtAm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAm.CustomButton.UseSelectable = true;
            this.txtAm.CustomButton.Visible = false;
            this.txtAm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAm.Lines = new string[0];
            this.txtAm.Location = new System.Drawing.Point(151, 239);
            this.txtAm.MaxLength = 32767;
            this.txtAm.Name = "txtAm";
            this.txtAm.PasswordChar = '\0';
            this.txtAm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAm.SelectedText = "";
            this.txtAm.SelectionLength = 0;
            this.txtAm.SelectionStart = 0;
            this.txtAm.Size = new System.Drawing.Size(200, 30);
            this.txtAm.TabIndex = 23;
            this.txtAm.UseSelectable = true;
            this.txtAm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAp
            // 
            // 
            // 
            // 
            this.txtAp.CustomButton.Image = null;
            this.txtAp.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtAp.CustomButton.Name = "";
            this.txtAp.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAp.CustomButton.TabIndex = 1;
            this.txtAp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAp.CustomButton.UseSelectable = true;
            this.txtAp.CustomButton.Visible = false;
            this.txtAp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAp.Lines = new string[0];
            this.txtAp.Location = new System.Drawing.Point(151, 186);
            this.txtAp.MaxLength = 32767;
            this.txtAp.Name = "txtAp";
            this.txtAp.PasswordChar = '\0';
            this.txtAp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAp.SelectedText = "";
            this.txtAp.SelectionLength = 0;
            this.txtAp.SelectionStart = 0;
            this.txtAp.Size = new System.Drawing.Size(200, 30);
            this.txtAp.TabIndex = 22;
            this.txtAp.UseSelectable = true;
            this.txtAp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(151, 127);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(200, 30);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DateFechaNacimiento
            // 
            this.DateFechaNacimiento.Location = new System.Drawing.Point(369, 239);
            this.DateFechaNacimiento.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFechaNacimiento.Name = "DateFechaNacimiento";
            this.DateFechaNacimiento.Size = new System.Drawing.Size(200, 29);
            this.DateFechaNacimiento.TabIndex = 40;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(367, 217);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Fecha Nacimiento";
            // 
            // radHombre
            // 
            this.radHombre.AutoSize = true;
            this.radHombre.Checked = true;
            this.radHombre.Location = new System.Drawing.Point(369, 142);
            this.radHombre.Name = "radHombre";
            this.radHombre.Size = new System.Drawing.Size(67, 15);
            this.radHombre.TabIndex = 42;
            this.radHombre.TabStop = true;
            this.radHombre.Text = "Hombre";
            this.radHombre.UseSelectable = true;
            // 
            // radMujer
            // 
            this.radMujer.AutoSize = true;
            this.radMujer.Location = new System.Drawing.Point(369, 163);
            this.radMujer.Name = "radMujer";
            this.radMujer.Size = new System.Drawing.Size(54, 15);
            this.radMujer.TabIndex = 43;
            this.radMujer.Text = "Mujer";
            this.radMujer.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(367, 105);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 44;
            this.metroLabel10.Text = "Genero";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 612);
            this.ControlBox = false;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grid);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grid;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroContextMenu CotxMenu;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroButton btnRegresarMenu;
        private MetroFramework.Controls.MetroToggle checkActivos;
        private MetroFramework.Controls.MetroPanel Panel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroTextBox txtRFC;
        private MetroFramework.Controls.MetroTextBox txtCP;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroTextBox txtColonia;
        private MetroFramework.Controls.MetroTextBox txtCalle;
        private MetroFramework.Controls.MetroTextBox txtAm;
        private MetroFramework.Controls.MetroTextBox txtAp;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DateFechaNacimiento;
        private MetroFramework.Controls.MetroRadioButton radMujer;
        private MetroFramework.Controls.MetroRadioButton radHombre;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}