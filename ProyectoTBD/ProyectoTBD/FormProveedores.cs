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
    public partial class FormProveedores : MetroFramework.Forms.MetroForm
    {
        DataTable dtEstado = new DataTable();
        int currentMouseOverRow = 0;
        public FormProveedores()
        {
            InitializeComponent();
            CtxMenu.Items.Add("Editar");
            CtxMenu.Items.Add("Eliminar");
            string query = String.Format("exec get_estado");
            //proveedores
            dtEstado = Conexion.Consultas(query);
            for (int i = 0; i < dtEstado.Rows.Count; i++)
            {
                comboEstado.Items.Add(dtEstado.Rows[i].ItemArray[1]);
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            
            comboEstado.SelectedIndex = 1;
            Dialogo("Nuevo Proveedor");
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            FormMenu miMenu = new FormMenu();
            this.Hide();
            miMenu.FormClosed += (s, args) => this.Close();
            miMenu.Show();
            miMenu.Focus();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (checkActivos.Checked == true)
                {
                    string query = String.Format("select * from dbo.buscar_proveedor ('{0}','{1}')", txtBuscar.Text, 1);
                    DataTable dt = Conexion.Consultas(query);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos activos");
                    }
                    grid.DataSource = dt;

                }
                else
                {
                    string query = String.Format("select * from dbo.buscar_proveedor ('{0}','{1}')", txtBuscar.Text, 0);
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

        private void gridProveedores_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                 currentMouseOverRow = grid.HitTest(e.X, e.Y).RowIndex;
                CtxMenu.Show(grid, new Point(e.X, e.Y));
            }
        }

        private void metroContextMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.ToString())
            {
                case "Editar":
                     lblTitulo.Text= "Editar Producto";
                    txtNombre.Text = grid.Rows[currentMouseOverRow].Cells[5].Value.ToString();
                    txtCalle.Text = grid.Rows[currentMouseOverRow].Cells[1].Value.ToString();
                    txtColonia.Text = grid.Rows[currentMouseOverRow].Cells[2].Value.ToString();
                    txtCP.Text = grid.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                    txtRFC.Text = grid.Rows[currentMouseOverRow].Cells[8].Value.ToString();
                    txtNumero.Text = grid.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                    comboEstado.SelectedIndex = comboEstado.FindString(grid.Rows[currentMouseOverRow].Cells[9].Value.ToString());
                    Dialogo("Editar Proveedor");
                    break;
                case "Eliminar":
                    //manda un mensaje de si esta seguro (solo es logico)
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            clearText(Panel);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "";
            if (lblTitulo.Text == "Nuevo Proveedor")
            {
                Guardar(query = String.Format("exec insert_proveedores '{0}','{1}','{3}','{2}','{4}','{5}',{6}", txtNombre.Text, txtCalle.Text, txtColonia.Text, txtNumero.Text,txtCP.Text,txtRFC.Text
                   , dtEstado.Rows[comboEstado.SelectedIndex].ItemArray[0]));
            }
            else
            {
                query = String.Format("exec update_proveedores {7},'{0}','{1}','{3}','{2}','{4}','{5}',{6}", txtNombre.Text, txtCalle.Text, txtColonia.Text, txtNumero.Text,txtCP.Text,txtRFC.Text
                   , dtEstado.Rows[comboEstado.SelectedIndex].ItemArray[0], grid.Rows[currentMouseOverRow].Cells[0].Value.ToString());
                Guardar(query);
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
        }
        private void RefrescarGrid()
        {
            try
            {
                DataTable dt = Conexion.Consultas("exec get_proveedores " + 1);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron proveedores activos");
                }
                grid.DataSource = dt;
                //this.grid.Columns[0].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
        public void Dialogo(string x)
        {
            try
            {
                lblTitulo.Text = x;
                Panel.Width = this.Width;
                Panel.Height = this.Height;
                Panel.Visible = true;

            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkActivos.Checked == true)
                {
                    DataTable dt = Conexion.Consultas("exec get_proveedores " + 1);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron proveedores activos");
                    }
                    grid.DataSource = dt;

                }
                else
                {
                    DataTable dt = Conexion.Consultas("exec get_proveedores " + 0);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron proveedores NO activos");
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
