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
    public partial class FormEmpleado : MetroFramework.Forms.MetroForm
    {
        int currentMouseOverRow = 0;
        DataTable dtJefe = new DataTable();
        public FormEmpleado()
        {
            InitializeComponent();
            CtxMenu.Items.Add("Editar");
            CtxMenu.Items.Add("Eliminar");
            CargarJefes();
        }

        private void CargarJefes()
        {
            string query = String.Format("exec get_JEFES " + 1);

            //proveedores

            dtJefe = Conexion.Consultas(query);
            for (int i = 0; i < dtJefe.Rows.Count; i++)
            {
                comboJEFE.Items.Add(dtJefe.Rows[i].ItemArray[1]);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (checkActivos.Checked == true)
            {
                string query = String.Format("select * from dbo.BUSCAR_empleado  ('{0}','{1}')", txtBuscar.Text, 1);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resuldatos ");
                }
                grid.DataSource = dt;

            }
            else
            {
                string query = String.Format("select * from dbo.BUSCAR_empleado ('{0}','{1}')", txtBuscar.Text, 0);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resultados");
                }
                grid.DataSource = dt;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            lblTitulo.Text = "Nuevo Empleado";
            Panel.Width = this.Width;
            Panel.Height = this.Height;
            Panel.Visible = true;
            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            clearText(Panel);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "", genero = "",jefe="";

            if (radHombre.Checked)
                genero = "M";
            else
                genero = "F";

            if (lblTitulo.Text == "Nuevo Empleado")
            {

                if (comboJEFE.SelectedIndex != -1)
                {
                    Guardar(query = String.Format("exec INSERT_EMPLEADO '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11}", txtNombre.Text, txtAp.Text, txtAm.Text, DateFechaNacimiento.Value.ToString("yyyy-MM-dd"),
                     txtCalle.Text, genero, txtNumero.Text, txtColonia.Text, txtCP.Text, txtRFC.Text, comboPuesto.SelectedItem.ToString(), dtJefe.Rows[comboJEFE.SelectedIndex].ItemArray[0]));
                }
                else
                {
                    Guardar(query = String.Format("exec INSERT_EMPLEADO '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',NULL", txtNombre.Text, txtAp.Text, txtAm.Text, DateFechaNacimiento.Value.ToString("yyyy-MM-dd"),
                     txtCalle.Text, genero, txtNumero.Text, txtColonia.Text, txtCP.Text, txtRFC.Text, comboPuesto.SelectedItem.ToString()));
                }
            }
            else
            {
   
                if (comboJEFE.SelectedIndex != -1)
                {
                    Guardar(query = String.Format("exec UPDATE_EMPLEADO {12},'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11}", txtNombre.Text, txtAp.Text, txtAm.Text, DateFechaNacimiento.Value.ToString("yyyy-MM-dd"), txtCalle.Text, genero, txtNumero.Text, txtColonia.Text, txtCP.Text, txtRFC.Text,
                     comboPuesto.SelectedItem.ToString(), dtJefe.Rows[comboJEFE.SelectedIndex].ItemArray[0], grid.Rows[currentMouseOverRow].Cells[0].Value.ToString()));
                }
                else
                {
                    Guardar(query = String.Format("exec UPDATE_EMPLEADO {11},'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',NULL,'{10}'", txtNombre.Text, txtAp.Text, txtAm.Text, DateFechaNacimiento.Value.ToString("yyyy-MM-dd"), txtCalle.Text, genero, txtNumero.Text, txtColonia.Text, txtCP.Text, txtRFC.Text,
                     comboPuesto.SelectedItem.ToString(), grid.Rows[currentMouseOverRow].Cells[0].Value.ToString()));
                }
                
            }
            CargarJefes();
        }

        private void gridEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                 currentMouseOverRow = grid.HitTest(e.X, e.Y).RowIndex;
                 grid.Rows[currentMouseOverRow].Selected = true;
                CtxMenu.Show(grid, new Point(e.X, e.Y));
            }
        }

        private void metroContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Editar":
                    lblTitulo.Text= "Editar Producto";
                    txtNombre.Text = grid.Rows[currentMouseOverRow].Cells[2].Value.ToString();
                    txtAp.Text = grid.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                    txtAm.Text = grid.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                    txtCalle.Text = grid.Rows[currentMouseOverRow].Cells[5].Value.ToString();
                    txtColonia.Text = grid.Rows[currentMouseOverRow].Cells[6].Value.ToString();
                    txtNumero.Text = grid.Rows[currentMouseOverRow].Cells[7].Value.ToString();
                    txtCP.Text = grid.Rows[currentMouseOverRow].Cells[8].Value.ToString();
                    txtRFC.Text = grid.Rows[currentMouseOverRow].Cells[15].Value.ToString(); 
                     string fecha = grid.Rows[currentMouseOverRow].Cells[10].Value.ToString();
                    DateTime dt = DateTime.Parse(fecha);
                    DateFechaNacimiento.Value = dt;
                    string jefe = grid.Rows[currentMouseOverRow].Cells[16].Value.ToString();
                    if (jefe!="")
                    {
                        comboJEFE.SelectedIndex = comboJEFE.FindString(jefe); 
                    }
                    else
                    {
                        comboJEFE.SelectedIndex = -1;
                    }
                    if (grid.Rows[currentMouseOverRow].Cells[12].Value.ToString() == "M")
                        radHombre.Checked = true;
                    else
                        radMujer.Checked = true;

                    comboPuesto.SelectedIndex = comboPuesto.FindString(grid.Rows[currentMouseOverRow].Cells[17].Value.ToString());
                    Dialogo("Editar Empleado");
         
                    
                    break;
                case "Eliminar":
                    //manda un mensaje de si esta seguro (solo es logico)
                    break;
            }
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
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
                RefrescarGrid();
                Panel.Visible = false;
                clearText(Panel);
                MessageBox.Show("Operacion exitosa");
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
                DataTable dt = Conexion.Consultas("exec GET_EMPLEADOS " + 1);
               
                grid.DataSource = dt;
               
                for (int i = 0; i < 9; i++)
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

        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkActivos.Checked == true)
            {
                string query = String.Format("exec GET_EMPLEADOS " + 1);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resuldatos ");
                }
                grid.DataSource = dt;

            }
            else
            {
                string query = String.Format("exec GET_EMPLEADOS " + 0);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resultados");
                }
                grid.DataSource = dt;

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text.Length==0)
            {
                if (checkActivos.Checked == true)
            {
                string query = String.Format("exec GET_EMPLEADOS " + 1);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resuldatos ");
                }
                grid.DataSource = dt;

            }
            else
            {
                string query = String.Format("exec GET_EMPLEADOS " + 0);
                DataTable dt = Conexion.Consultas(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resultados");
                }
                grid.DataSource = dt;

            }
            }
        }
    }
}
