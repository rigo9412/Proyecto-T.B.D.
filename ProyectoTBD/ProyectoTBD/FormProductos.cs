using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoTBD
{
    public partial class FormProductos : MetroFramework.Forms.MetroForm
    {
        DataTable dtPro = new DataTable();
        DataTable dtCat = new DataTable();
        int currentMouseOverRow = 0;
        public FormProductos()
        {
            InitializeComponent();
            CtxMenu.Items.Add("Editar");
            CtxMenu.Items.Add("Eliminar");
            string query = String.Format("exec get_proveedores " + 1);
            //proveedores
            dtPro = Conexion.Consultas(query);
            for (int i = 0; i < dtPro.Rows.Count; i++)
            {
                comboProveedor.Items.Add(dtPro.Rows[i].ItemArray[5]);
            }
            //categoria
            query = String.Format("exec GET_CATEGORIA " + 1);
            dtCat = Conexion.Consultas(query);
            for (int i = 0; i < dtCat.Rows.Count; i++)
            {
                comboCategoria.Items.Add(dtCat.Rows[i].ItemArray[1]);
            }

        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
        
            FormMenu miMenu = new FormMenu();
            this.Hide();
            miMenu.FormClosed += (s, args) => this.Close();
            miMenu.Show();
            miMenu.Focus();
 
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (checkActivos.Checked == true)
                {
                    string query = String.Format("select * from dbo.buscar_productos ('{0}','{1}')", txtBuscar.Text, 1);
                    DataTable dt = Conexion.Consultas(query);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos activos");
                    }
                    grid.DataSource = dt;

                }
                else
                {
                    string query = String.Format("select * from dbo.buscar_productos ('{0}','{1}')", txtBuscar.Text, 0);
                    DataTable dt = Conexion.Consultas(query);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos no activos");
                    }
                    grid.DataSource = dt;

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Nuevo Producto";
            comboCategoria.SelectedIndex = -1;
            comboProveedor.SelectedIndex = -1;
            Dialogo("Nuevo Produco");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query="";
            if (lblTitulo.Text=="Nuevo Producto")
            {
                Guardar(query = String.Format("exec insert_producto '{0}','{1}','{2}',{3},{4},{5}", txtNombreProducto.Text, txtMarcaProduto.Text, txtCantidadProducto.Text.Trim(), txtPrecioProducto.Text.Trim(),
                    dtPro.Rows[comboProveedor.SelectedIndex].ItemArray[0], dtCat.Rows[comboCategoria.SelectedIndex].ItemArray[0]));
            }
            else{
                query = String.Format("exec update_producto {6},'{0}','{1}',{2},{3},{4},{5}", txtNombreProducto.Text, txtMarcaProduto.Text, txtCantidadProducto.Text.Trim(), txtPrecioProducto.Text.Trim(),
                   dtPro.Rows[comboProveedor.SelectedIndex].ItemArray[0], dtCat.Rows[comboCategoria.SelectedIndex].ItemArray[0], grid.Rows[currentMouseOverRow].Cells[0].Value.ToString());
                Guardar(query);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            clearText(Panel);
        }
        private void clearText(Panel PanelID)
        {
            foreach (Control c in PanelID.Controls)
            {
                if (c is MetroTextBox)
                {
                    MetroTextBox questionTextBox = c as MetroTextBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = "";
                    }
                }
            }
        }

        private void gridProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                  currentMouseOverRow = grid.HitTest(e.X, e.Y).RowIndex;
                  grid.Rows[currentMouseOverRow].Selected = true;
                CtxMenu.Show(grid, new Point(e.X, e.Y));
            }
        }

        private void CtxMenuProducto_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Editar":
                    lblTitulo.Text= "Editar Producto";
                    txtNombreProducto.Text = grid.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                    txtMarcaProduto.Text = grid.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                    string precio = grid.Rows[currentMouseOverRow].Cells[6].Value.ToString();
                    txtPrecioProducto.Text = precio.Substring(0,precio.LastIndexOf(','));
                    txtCantidadProducto.Text = grid.Rows[currentMouseOverRow].Cells[5].Value.ToString();                   
                    comboCategoria.SelectedIndex = comboCategoria.FindString(grid.Rows[currentMouseOverRow].Cells[7].Value.ToString());
                    comboProveedor.SelectedIndex = comboProveedor.FindString(grid.Rows[currentMouseOverRow].Cells[8].Value.ToString());
         
                    Dialogo("Editar Producto");
                    break;
                case "Eliminar":
                    //manda un mensaje de si esta seguro (solo es logico)
                    break;
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

            RefrescarGrid();
        }

        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                    if (checkActivos.Checked == true)
                    {
                        DataTable dt = Conexion.Consultas("exec get_productos " + 1);
                        if (dt.Rows.Count==0)
                        {
                            MessageBox.Show("No se encontraron productos activos");
                        }
                        grid.DataSource = dt;

                    }
                    else
                    {
                        DataTable dt = Conexion.Consultas("exec get_productos " + 0);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron productos no activos");
                        }
                        grid.DataSource = dt;

                    }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Dialogo(string x)
        {
            try
            {
                metroLabel1.Text = x;
                Panel.Width = this.Width;
                Panel.Height = this.Height;
                Panel.Visible = true;

            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Guardar(string query)
        {
            try
            {
                Conexion.Cambiar(query);
                MessageBox.Show("Operacion exitosa");
                RefrescarGrid();
                Panel.Visible = false;
                clearText(Panel);
            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void RefrescarGrid()
        {
            try
            {
                DataTable dt = Conexion.Consultas("exec get_productos " + 1);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos activos");
                }
                grid.DataSource = dt;
                this.grid.Columns[0].Visible = false;
                this.grid.Columns[1].Visible = false;
                this.grid.Columns[2].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text.Length==0)
            {
                try
            {
                    if (checkActivos.Checked == true)
                    {
                        DataTable dt = Conexion.Consultas("exec get_productos " + 1);
                        if (dt.Rows.Count==0)
                        {
                            MessageBox.Show("No se encontraron productos activos");
                        }
                        grid.DataSource = dt;

                    }
                    else
                    {
                        DataTable dt = Conexion.Consultas("exec get_productos " + 0);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron productos no activos");
                        }
                        grid.DataSource = dt;

                    }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
    }
}
