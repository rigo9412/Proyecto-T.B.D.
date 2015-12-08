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

namespace ProyectoTBD
{
    public partial class FormClientes : MetroFramework.Forms.MetroForm
    {
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
                int currentMouseOverRow = gridClientes.HitTest(e.X, e.Y).RowIndex;
                CotxMenu.Show(gridClientes, new Point(e.X, e.Y));
            }
         }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            metroLabel1.Text = "Nuevo Cliente";
            panelAddEdit.Width = this.Width;
            panelAddEdit.Height = this.Height;
            panelAddEdit.Visible = true;
        }

        private void btnAddEditClienteCancelar_Click(object sender, EventArgs e)
        {
            panelAddEdit.Visible = false;
            clearText(panelAddEdit);
        }

        private void btnClienteAddEditGuardar_Click(object sender, EventArgs e)
        {

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
                    //Manda el panel de editar
                    break;
                case "Eliminar":
                    //manda un mensaje de si esta seguro (solo es logico)
                    break;
            }
        }
    }
}
