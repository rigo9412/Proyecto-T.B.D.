using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTBD
{
    public partial class FormMenu : MetroFramework.Forms.MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();
            cotxMenuSesion.Items.Add("Cambiar Usuario");
            cotxMenuSesion.Items.Add("Cerrar");
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            FormVendedores vendedores = new FormVendedores();
            vendedores.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas misVentas = new FormVentas();
            misVentas.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos misProductos = new FormProductos();
            misProductos.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes misClientes = new FormClientes();
            this.Hide();
            misClientes.FormClosed += (s, args) => this.Close();
            misClientes.Show();
            misClientes.Focus();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores miProveedores = new FormProveedores();
            miProveedores.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            //Preguntar si cambia de usuario o si quiere cerrar el programa
            if (e.Button == MouseButtons.Left)
            {
                 
                cotxMenuSesion.Show(btnSalir, new Point(60, 60));
            }
        }

        private void cotxMenuSesion_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Cambiar Usuario":
                    //manda al menu de login despues de cerrar sesion en la base de datos
                    break;
                case "Cerrar":
                    //Cierra todo el programa tambien hay que cerrar sesion antes de cerrar el programa
                    this.Close();
                    break;
            }
        }
    }
}
