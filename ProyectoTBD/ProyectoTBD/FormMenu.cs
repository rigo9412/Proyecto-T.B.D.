using MetroFramework.Controls;
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
            btnSalir.Text = "Hola! "+Conexion.usuario;


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
                    FormLogin miLogin = new FormLogin();
                     this.Hide();
                    miLogin.FormClosed += (s, args) => this.Close();
                    miLogin.Show();
                    miLogin.Focus();
                    Conexion.usuario = "";
                    Conexion.contraseña = "";
                    break;
                case "Cerrar":
                    //Cierra todo el programa tambien hay que cerrar sesion antes de cerrar el programa
                    this.Close();
                    break;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado empleados = new FormEmpleado();
            this.Hide();
            empleados.FormClosed += (s, args) => this.Close();
            empleados.Show();
            empleados.Focus();
        }

        private void metroVentas_Click(object sender, EventArgs e)
        {
            FormVentas misVentas = new FormVentas();
            this.Hide();
            misVentas.FormClosed += (s, args) => this.Close();
            misVentas.Show();
            misVentas.Focus();
        }

        private void metroProductos_Click(object sender, EventArgs e)
        {
            FormProductos misProductos = new FormProductos();
            this.Hide();
            misProductos.FormClosed += (s, args) => this.Close();
            misProductos.Show();
            misProductos.Focus();
        }

        private void metroProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores miProveedores = new FormProveedores();
            this.Hide();
            miProveedores.FormClosed += (s, args) => this.Close();
            miProveedores.Show();
            miProveedores.Focus();
        }

        private void metroClientes_Click(object sender, EventArgs e)
        {
            FormClientes misClientes = new FormClientes();
            this.Hide();
            misClientes.FormClosed += (s, args) => this.Close();
            misClientes.Show();
            misClientes.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            metroEmpleados_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metroVentas_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            metroProductos_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           // metroProductos_Click(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            metroClientes_Click(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            metroProveedores_Click(sender, e);
        }
     
        
    }
}
