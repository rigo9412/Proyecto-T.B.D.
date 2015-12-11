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
            try
            {
                Conexion.usuario = txtUserName.Text;
                Conexion.contraseña = txtPassword.Text;
                MessageBox.Show(Conexion.Login());
                FormMenu miMenu = new FormMenu();
                this.Hide();
                miMenu.FormClosed += (s, args) => this.Close();
                miMenu.Show();
                miMenu.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
