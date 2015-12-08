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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridClientes = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoCliente = new MetroFramework.Controls.MetroButton();
            this.CotxMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.btnBuscarCliente = new MetroFramework.Controls.MetroButton();
            this.txtBuscarClientes = new MetroFramework.Controls.MetroTextBox();
            this.panelAddEdit = new MetroFramework.Controls.MetroPanel();
            this.btnAddEditClienteCancelar = new MetroFramework.Controls.MetroButton();
            this.btnClienteAddEditGuardar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtClienteAddEditRFC = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditCP = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditColonia = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditCalle = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditAm = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditAp = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteAddEditNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnRegresarMenu = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.panelAddEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToResizeRows = false;
            this.gridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClientes.Location = new System.Drawing.Point(116, 232);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(844, 332);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridClientes_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Direccion";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RFC";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(34, 77);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(153, 60);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.Text = "+ Cliente";
            this.btnNuevoCliente.UseSelectable = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // CotxMenu
            // 
            this.CotxMenu.Name = "CotxMenu";
            this.CotxMenu.Size = new System.Drawing.Size(153, 26);
            this.CotxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CotxMenu_ItemClicked);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(885, 173);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseSelectable = true;
            // 
            // txtBuscarClientes
            // 
            // 
            // 
            // 
            this.txtBuscarClientes.CustomButton.Image = null;
            this.txtBuscarClientes.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtBuscarClientes.CustomButton.Name = "";
            this.txtBuscarClientes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscarClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarClientes.CustomButton.TabIndex = 1;
            this.txtBuscarClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarClientes.CustomButton.UseSelectable = true;
            this.txtBuscarClientes.CustomButton.Visible = false;
            this.txtBuscarClientes.Lines = new string[0];
            this.txtBuscarClientes.Location = new System.Drawing.Point(682, 173);
            this.txtBuscarClientes.MaxLength = 32767;
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.PasswordChar = '\0';
            this.txtBuscarClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarClientes.SelectedText = "";
            this.txtBuscarClientes.SelectionLength = 0;
            this.txtBuscarClientes.SelectionStart = 0;
            this.txtBuscarClientes.Size = new System.Drawing.Size(187, 23);
            this.txtBuscarClientes.TabIndex = 4;
            this.txtBuscarClientes.UseSelectable = true;
            this.txtBuscarClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelAddEdit
            // 
            this.panelAddEdit.Controls.Add(this.btnAddEditClienteCancelar);
            this.panelAddEdit.Controls.Add(this.btnClienteAddEditGuardar);
            this.panelAddEdit.Controls.Add(this.metroLabel1);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditRFC);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditCP);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditNumero);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditColonia);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditCalle);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditAm);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditAp);
            this.panelAddEdit.Controls.Add(this.txtClienteAddEditNombre);
            this.panelAddEdit.HorizontalScrollbarBarColor = true;
            this.panelAddEdit.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAddEdit.HorizontalScrollbarSize = 10;
            this.panelAddEdit.Location = new System.Drawing.Point(0, 4);
            this.panelAddEdit.Name = "panelAddEdit";
            this.panelAddEdit.Size = new System.Drawing.Size(12, 18);
            this.panelAddEdit.TabIndex = 5;
            this.panelAddEdit.VerticalScrollbarBarColor = true;
            this.panelAddEdit.VerticalScrollbarHighlightOnWheel = false;
            this.panelAddEdit.VerticalScrollbarSize = 10;
            this.panelAddEdit.Visible = false;
            // 
            // btnAddEditClienteCancelar
            // 
            this.btnAddEditClienteCancelar.Location = new System.Drawing.Point(684, 504);
            this.btnAddEditClienteCancelar.Name = "btnAddEditClienteCancelar";
            this.btnAddEditClienteCancelar.Size = new System.Drawing.Size(138, 50);
            this.btnAddEditClienteCancelar.TabIndex = 12;
            this.btnAddEditClienteCancelar.Text = "Cancelar";
            this.btnAddEditClienteCancelar.UseSelectable = true;
            this.btnAddEditClienteCancelar.Click += new System.EventHandler(this.btnAddEditClienteCancelar_Click);
            // 
            // btnClienteAddEditGuardar
            // 
            this.btnClienteAddEditGuardar.Location = new System.Drawing.Point(828, 504);
            this.btnClienteAddEditGuardar.Name = "btnClienteAddEditGuardar";
            this.btnClienteAddEditGuardar.Size = new System.Drawing.Size(138, 50);
            this.btnClienteAddEditGuardar.TabIndex = 11;
            this.btnClienteAddEditGuardar.Text = "Guardar";
            this.btnClienteAddEditGuardar.UseSelectable = true;
            this.btnClienteAddEditGuardar.Click += new System.EventHandler(this.btnClienteAddEditGuardar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(118, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // txtClienteAddEditRFC
            // 
            // 
            // 
            // 
            this.txtClienteAddEditRFC.CustomButton.Image = null;
            this.txtClienteAddEditRFC.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditRFC.CustomButton.Name = "";
            this.txtClienteAddEditRFC.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditRFC.CustomButton.TabIndex = 1;
            this.txtClienteAddEditRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditRFC.CustomButton.UseSelectable = true;
            this.txtClienteAddEditRFC.CustomButton.Visible = false;
            this.txtClienteAddEditRFC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditRFC.Lines = new string[] {
        "RFC"};
            this.txtClienteAddEditRFC.Location = new System.Drawing.Point(281, 323);
            this.txtClienteAddEditRFC.MaxLength = 32767;
            this.txtClienteAddEditRFC.Name = "txtClienteAddEditRFC";
            this.txtClienteAddEditRFC.PasswordChar = '\0';
            this.txtClienteAddEditRFC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditRFC.SelectedText = "";
            this.txtClienteAddEditRFC.SelectionLength = 0;
            this.txtClienteAddEditRFC.SelectionStart = 0;
            this.txtClienteAddEditRFC.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditRFC.TabIndex = 9;
            this.txtClienteAddEditRFC.Text = "RFC";
            this.txtClienteAddEditRFC.UseSelectable = true;
            this.txtClienteAddEditRFC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditRFC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditCP
            // 
            // 
            // 
            // 
            this.txtClienteAddEditCP.CustomButton.Image = null;
            this.txtClienteAddEditCP.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditCP.CustomButton.Name = "";
            this.txtClienteAddEditCP.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditCP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditCP.CustomButton.TabIndex = 1;
            this.txtClienteAddEditCP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditCP.CustomButton.UseSelectable = true;
            this.txtClienteAddEditCP.CustomButton.Visible = false;
            this.txtClienteAddEditCP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditCP.Lines = new string[] {
        "Codigo Postal"};
            this.txtClienteAddEditCP.Location = new System.Drawing.Point(573, 323);
            this.txtClienteAddEditCP.MaxLength = 32767;
            this.txtClienteAddEditCP.Name = "txtClienteAddEditCP";
            this.txtClienteAddEditCP.PasswordChar = '\0';
            this.txtClienteAddEditCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditCP.SelectedText = "";
            this.txtClienteAddEditCP.SelectionLength = 0;
            this.txtClienteAddEditCP.SelectionStart = 0;
            this.txtClienteAddEditCP.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditCP.TabIndex = 8;
            this.txtClienteAddEditCP.Text = "Codigo Postal";
            this.txtClienteAddEditCP.UseSelectable = true;
            this.txtClienteAddEditCP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditCP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditNumero
            // 
            // 
            // 
            // 
            this.txtClienteAddEditNumero.CustomButton.Image = null;
            this.txtClienteAddEditNumero.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditNumero.CustomButton.Name = "";
            this.txtClienteAddEditNumero.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditNumero.CustomButton.TabIndex = 1;
            this.txtClienteAddEditNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditNumero.CustomButton.UseSelectable = true;
            this.txtClienteAddEditNumero.CustomButton.Visible = false;
            this.txtClienteAddEditNumero.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditNumero.Lines = new string[] {
        "Numero"};
            this.txtClienteAddEditNumero.Location = new System.Drawing.Point(573, 275);
            this.txtClienteAddEditNumero.MaxLength = 32767;
            this.txtClienteAddEditNumero.Name = "txtClienteAddEditNumero";
            this.txtClienteAddEditNumero.PasswordChar = '\0';
            this.txtClienteAddEditNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditNumero.SelectedText = "";
            this.txtClienteAddEditNumero.SelectionLength = 0;
            this.txtClienteAddEditNumero.SelectionStart = 0;
            this.txtClienteAddEditNumero.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditNumero.TabIndex = 7;
            this.txtClienteAddEditNumero.Text = "Numero";
            this.txtClienteAddEditNumero.UseSelectable = true;
            this.txtClienteAddEditNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditColonia
            // 
            // 
            // 
            // 
            this.txtClienteAddEditColonia.CustomButton.Image = null;
            this.txtClienteAddEditColonia.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditColonia.CustomButton.Name = "";
            this.txtClienteAddEditColonia.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditColonia.CustomButton.TabIndex = 1;
            this.txtClienteAddEditColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditColonia.CustomButton.UseSelectable = true;
            this.txtClienteAddEditColonia.CustomButton.Visible = false;
            this.txtClienteAddEditColonia.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditColonia.Lines = new string[] {
        "Colonia"};
            this.txtClienteAddEditColonia.Location = new System.Drawing.Point(573, 222);
            this.txtClienteAddEditColonia.MaxLength = 32767;
            this.txtClienteAddEditColonia.Name = "txtClienteAddEditColonia";
            this.txtClienteAddEditColonia.PasswordChar = '\0';
            this.txtClienteAddEditColonia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditColonia.SelectedText = "";
            this.txtClienteAddEditColonia.SelectionLength = 0;
            this.txtClienteAddEditColonia.SelectionStart = 0;
            this.txtClienteAddEditColonia.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditColonia.TabIndex = 6;
            this.txtClienteAddEditColonia.Text = "Colonia";
            this.txtClienteAddEditColonia.UseSelectable = true;
            this.txtClienteAddEditColonia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditColonia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditCalle
            // 
            // 
            // 
            // 
            this.txtClienteAddEditCalle.CustomButton.Image = null;
            this.txtClienteAddEditCalle.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditCalle.CustomButton.Name = "";
            this.txtClienteAddEditCalle.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditCalle.CustomButton.TabIndex = 1;
            this.txtClienteAddEditCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditCalle.CustomButton.UseSelectable = true;
            this.txtClienteAddEditCalle.CustomButton.Visible = false;
            this.txtClienteAddEditCalle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditCalle.Lines = new string[] {
        "Calle"};
            this.txtClienteAddEditCalle.Location = new System.Drawing.Point(573, 163);
            this.txtClienteAddEditCalle.MaxLength = 32767;
            this.txtClienteAddEditCalle.Name = "txtClienteAddEditCalle";
            this.txtClienteAddEditCalle.PasswordChar = '\0';
            this.txtClienteAddEditCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditCalle.SelectedText = "";
            this.txtClienteAddEditCalle.SelectionLength = 0;
            this.txtClienteAddEditCalle.SelectionStart = 0;
            this.txtClienteAddEditCalle.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditCalle.TabIndex = 5;
            this.txtClienteAddEditCalle.Text = "Calle";
            this.txtClienteAddEditCalle.UseSelectable = true;
            this.txtClienteAddEditCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditAm
            // 
            // 
            // 
            // 
            this.txtClienteAddEditAm.CustomButton.Image = null;
            this.txtClienteAddEditAm.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditAm.CustomButton.Name = "";
            this.txtClienteAddEditAm.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditAm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditAm.CustomButton.TabIndex = 1;
            this.txtClienteAddEditAm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditAm.CustomButton.UseSelectable = true;
            this.txtClienteAddEditAm.CustomButton.Visible = false;
            this.txtClienteAddEditAm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditAm.Lines = new string[] {
        "Apellido Materno"};
            this.txtClienteAddEditAm.Location = new System.Drawing.Point(281, 275);
            this.txtClienteAddEditAm.MaxLength = 32767;
            this.txtClienteAddEditAm.Name = "txtClienteAddEditAm";
            this.txtClienteAddEditAm.PasswordChar = '\0';
            this.txtClienteAddEditAm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditAm.SelectedText = "";
            this.txtClienteAddEditAm.SelectionLength = 0;
            this.txtClienteAddEditAm.SelectionStart = 0;
            this.txtClienteAddEditAm.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditAm.TabIndex = 4;
            this.txtClienteAddEditAm.Text = "Apellido Materno";
            this.txtClienteAddEditAm.UseSelectable = true;
            this.txtClienteAddEditAm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditAm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditAp
            // 
            // 
            // 
            // 
            this.txtClienteAddEditAp.CustomButton.Image = null;
            this.txtClienteAddEditAp.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditAp.CustomButton.Name = "";
            this.txtClienteAddEditAp.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditAp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditAp.CustomButton.TabIndex = 1;
            this.txtClienteAddEditAp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditAp.CustomButton.UseSelectable = true;
            this.txtClienteAddEditAp.CustomButton.Visible = false;
            this.txtClienteAddEditAp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditAp.Lines = new string[] {
        "Apellido Paterno"};
            this.txtClienteAddEditAp.Location = new System.Drawing.Point(281, 222);
            this.txtClienteAddEditAp.MaxLength = 32767;
            this.txtClienteAddEditAp.Name = "txtClienteAddEditAp";
            this.txtClienteAddEditAp.PasswordChar = '\0';
            this.txtClienteAddEditAp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditAp.SelectedText = "";
            this.txtClienteAddEditAp.SelectionLength = 0;
            this.txtClienteAddEditAp.SelectionStart = 0;
            this.txtClienteAddEditAp.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditAp.TabIndex = 3;
            this.txtClienteAddEditAp.Text = "Apellido Paterno";
            this.txtClienteAddEditAp.UseSelectable = true;
            this.txtClienteAddEditAp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditAp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteAddEditNombre
            // 
            // 
            // 
            // 
            this.txtClienteAddEditNombre.CustomButton.Image = null;
            this.txtClienteAddEditNombre.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClienteAddEditNombre.CustomButton.Name = "";
            this.txtClienteAddEditNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClienteAddEditNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteAddEditNombre.CustomButton.TabIndex = 1;
            this.txtClienteAddEditNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteAddEditNombre.CustomButton.UseSelectable = true;
            this.txtClienteAddEditNombre.CustomButton.Visible = false;
            this.txtClienteAddEditNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClienteAddEditNombre.Lines = new string[] {
        "Nombre"};
            this.txtClienteAddEditNombre.Location = new System.Drawing.Point(281, 163);
            this.txtClienteAddEditNombre.MaxLength = 32767;
            this.txtClienteAddEditNombre.Name = "txtClienteAddEditNombre";
            this.txtClienteAddEditNombre.PasswordChar = '\0';
            this.txtClienteAddEditNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteAddEditNombre.SelectedText = "";
            this.txtClienteAddEditNombre.SelectionLength = 0;
            this.txtClienteAddEditNombre.SelectionStart = 0;
            this.txtClienteAddEditNombre.Size = new System.Drawing.Size(200, 30);
            this.txtClienteAddEditNombre.TabIndex = 2;
            this.txtClienteAddEditNombre.Text = "Nombre";
            this.txtClienteAddEditNombre.UseSelectable = true;
            this.txtClienteAddEditNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteAddEditNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 612);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.panelAddEdit);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.gridClientes);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.panelAddEdit.ResumeLayout(false);
            this.panelAddEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroButton btnNuevoCliente;
        private MetroFramework.Controls.MetroContextMenu CotxMenu;
        private MetroFramework.Controls.MetroButton btnBuscarCliente;
        private MetroFramework.Controls.MetroTextBox txtBuscarClientes;
        private MetroFramework.Controls.MetroPanel panelAddEdit;
        private MetroFramework.Controls.MetroButton btnAddEditClienteCancelar;
        private MetroFramework.Controls.MetroButton btnClienteAddEditGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditRFC;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditCP;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditNumero;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditColonia;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditCalle;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditAm;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditAp;
        private MetroFramework.Controls.MetroTextBox txtClienteAddEditNombre;
        private MetroFramework.Controls.MetroButton btnRegresarMenu;
    }
}