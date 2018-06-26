using System;
using System.Windows.Forms;
using LugTp.UI.Entities;

namespace LugTp.UI
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            var docent = new Docente(txtNombre.Text,
                                     txtApellido.Text,
                                     txtDireccion.Text,
                                     txtTelefono.Text,
                                     cmbCargo.SelectedValue.ToString(),
                                     txtProfesion.Text);


        }

     

        private void CheckCompleteForm()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)
                ||
                string.IsNullOrWhiteSpace(txtApellido.Text)
                ||
                string.IsNullOrWhiteSpace(txtDireccion.Text)
                ||
                string.IsNullOrWhiteSpace(txtTelefono.Text)
                ||
                string.IsNullOrWhiteSpace(cmbCargo.SelectedItem.ToString())
                ||
                string.IsNullOrWhiteSpace(txtProfesion.Text))
            {
                btnAccion.Enabled = false;
            }
            else
            {
                btnAccion.Enabled = true;
            }
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            cmbCargo.SelectedIndex = 0;
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void txtProfesion_TextChanged(object sender, EventArgs e)
        {

            CheckCompleteForm();
        }
    }
}
