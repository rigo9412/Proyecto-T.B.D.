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
    public partial class FormVentas : MetroFramework.Forms.MetroForm
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
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
                DataTable dt = Conexion.Consultas("exec get_ventas ");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos activos");
                }
                grid.DataSource = dt;
                //this.grid.Columns[0].Visible = false;
                //this.grid.Columns[1].Visible = false;
                //this.grid.Columns[2].Visible = false;
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
             string query = String.Format("select * from dbo. ('{0}','{1}')", txtBuscar.Text, 1);
             DataTable dt = Conexion.Consultas(query);
             if (dt.Rows.Count == 0)
             {
                 MessageBox.Show("No se encontraron productos activos");
             }
             grid.DataSource = dt;
         }

         private void btnNuevo_Click(object sender, EventArgs e)
         {

         }

     
    }
}
