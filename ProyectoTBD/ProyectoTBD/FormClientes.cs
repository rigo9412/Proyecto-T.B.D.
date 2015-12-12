using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Data.SqlClient;

namespace ProyectoTBD
{
    public partial class FormClientes : MetroFramework.Forms.MetroForm
    {
        int currentMouseOverRow = 0;
        public FormClientes()
        {
            InitializeComponent();
            CotxMenu.Items.Add("Editar");
            CotxMenu.Items.Add("Eliminar");
        }

        private void gridClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = grid.HitTest(e.X, e.Y).RowIndex;
                grid.Rows[currentMouseOverRow].Selected = true;
                CotxMenu.Show(grid, new Point(e.X, e.Y));
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Dialogo("Nuevo Cliente");
        }

        //este tipo de metodos hay que hacerlos en una clase estatica
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

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            FormMenu miMenu = new FormMenu();
            this.Hide();
            miMenu.FormClosed += (s, args) => this.Close();
            miMenu.Show();
            miMenu.Focus();
        }

        private void CotxMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Editar":
                    lblTitulo.Text = "Editar Cliente";
                    txtNombre.Text = grid.Rows[currentMouseOverRow].Cells[1].Value.ToString();
                    txtAp.Text = grid.Rows[currentMouseOverRow].Cells[2].Value.ToString();
                    txtAm.Text = grid.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                    txtCalle.Text = grid.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                    txtColonia.Text = grid.Rows[currentMouseOverRow].Cells[6].Value.ToString();
                    txtNumero.Text = grid.Rows[currentMouseOverRow].Cells[5].Value.ToString();
                    txtCP.Text = grid.Rows[currentMouseOverRow].Cells[7].Value.ToString();
                    txtRFC.Text = grid.Rows[currentMouseOverRow].Cells[14].Value.ToString();
                    string fecha = grid.Rows[currentMouseOverRow].Cells[9].Value.ToString();

                    DateTime dt = DateTime.Parse(fecha);
                    DateFechaNacimiento.Value = dt;
                    if (grid.Rows[currentMouseOverRow].Cells[11].Value.ToString() == "M")
                        radHombre.Checked = true;
                    else
                        radMujer.Checked = true;

                    Dialogo("Editar Producto");
                    break;
                case "Eliminar":
                    //manda un mensaje de si esta seguro (solo es logico)
                    break;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (checkActivos.Checked == true)
            {
                string query = String.Format("select * from dbo.BUSCAR_CLIENTE ('{0}','{1}')", txtBuscar.Text, 1);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                grid.DataSource = dt;

            }
            else
            {
                string query = String.Format("select * from dbo.BUSCAR_CLIENTE ('{0}','{1}')", txtBuscar.Text, 0);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                grid.DataSource = dt;

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
                DataTable dt = Conexion.Consultas("exec get_clientes " + 1);

                grid.DataSource = dt;
                for (int i = 0; i < 8; i++)
                {
                    this.grid.Columns[i].Visible = false;

                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "", genero = "";


            if (lblTitulo.Text == "Nuevo Cliente")
            {
                if (radHombre.Checked)
                    genero = "M";
                else
                    genero = "F";

                Guardar(query = String.Format("exec INSERT_CLIENTES '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", txtNombre.Text, txtAp.Text, txtAm.Text, DateFechaNacimiento.Value.ToString("dd-MM-yyyy"), txtCalle.Text, genero, txtNumero.Text, txtColonia.Text, txtCP.Text, txtRFC.Text));

            }
            else
            {
                if (radHombre.Checked)
                    genero = "M";
                else
                    genero = "F";

                Guardar(query = String.Format("exec UPDATE_CLIENTES {10}, '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", txtNombre.Text, txtAp.Text, txtAm.Text, DateFechaNacimiento.Value.ToString("dd-MM-yyyy"), txtCalle.Text, genero, txtNumero.Text, txtColonia.Text, txtCP.Text, txtRFC.Text, grid.Rows[currentMouseOverRow].Cells[0].Value.ToString()));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            clearText(Panel);
        }

        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkActivos.Checked == true)
                {
                    DataTable dt = Conexion.Consultas("exec get_clientes " + 1);
                   
                    grid.DataSource = dt;
                    for (int i = 0; i < 8; i++)
                    {
                        this.grid.Columns[i].Visible = false;
                    
                    }
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados");
                    }
                }
                else
                {
                    DataTable dt = Conexion.Consultas("exec get_clientes " + 0);
                  
                    grid.DataSource = dt;
                    for (int i = 0; i < 8; i++)
                    {
                        this.grid.Columns[i].Visible = false;

                    }
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados");
                    }

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text.Length == 0)
            {

            }
        }
    }
}
