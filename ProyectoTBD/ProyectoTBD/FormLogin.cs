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
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //intentamos realizar la conexion
            try
            {
                Conexion.usuario = txtUserName.Text;//asignamos el nombre del usuario
                Conexion.contraseña = txtPassword.Text;//la contraseña
                MessageBox.Show(Conexion.Login(),"Bienvenido",MessageBoxButtons.OK,MessageBoxIcon.Information);//si se puede conectar, recibiremos un mensaje de bienvenida.
                FormMenu miMenu = new FormMenu();//abrimos la forma principal
                this.Hide();//ocultamos esta
                miMenu.FormClosed += (s, args) => this.Close();
                miMenu.Show();//lo mostramos
                miMenu.Focus();//y centramos(?)
            }
            catch (SqlException ex)
            {
                switch (ex.Number)// en caso de que el numero de error que mande sql sea
                {
                    case 18456://18456, quiere decir que no se pudo conectar a la base de datos,
                        {
                            MessageBox.Show("Login fallido, intente de nuevo","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }break;
                    default://en caso de que sea otro error, lo mostramos tal cual
                        {
                            MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }break;
                }
               
            }
            

        }
    }
}
