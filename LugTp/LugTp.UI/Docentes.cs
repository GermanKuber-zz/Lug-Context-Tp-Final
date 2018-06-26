using System;
using System.Linq;
using System.Windows.Forms;
using LugTp.Entities;

namespace LugTp.UI
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            var docente = new Docente(txtNombre.Text,
                                     txtApellido.Text,
                                     txtDireccion.Text,
                                     txtTelefono.Text,
                                     cmbCargo.SelectedValue.ToString(),
                                     txtProfesion.Text);

            Form1.Context.Docentes.Add(docente);
            Form1.Context.SaveChangeAsync();
            CleanWindow();
            LoadData();
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

        private void CleanWindow()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cmbCargo.SelectedIndex = 0;
            txtProfesion.Text = string.Empty;
        }

        private void LoadData()
        {
            grvDocentes.Rows.Clear();

            var docentes = Form1.Context.Docentes;

            docentes?.ToList().ForEach(docente =>
            {
                grvDocentes.Rows.Add(docente.Id,
                    docente.Nombre,
                    docente.Apellido,
                    docente.Cargo,
                    docente.Profesion,
                    docente.Telefono,
                    docente.Direccion);
            });

        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            cmbCargo.SelectedIndex = 0;
            grvDocentes.Columns.Add("Id", "Id");
            grvDocentes.Columns["Id"].Visible = false;
            grvDocentes.Columns.Add("Nombre", "Nombre");
            grvDocentes.Columns["Nombre"].Width = 100;

            grvDocentes.Columns.Add("Apellido", "Apellido");
            grvDocentes.Columns["Apellido"].Width = 100;

            grvDocentes.Columns.Add("Cargo", "Cargo");
            grvDocentes.Columns["Cargo"].Width = 100;

            grvDocentes.Columns.Add("Profesion", "Profesion");
            grvDocentes.Columns["Profesion"].Width = 100;

            grvDocentes.Columns.Add("Telefono", "Telefono");
            grvDocentes.Columns["Telefono"].Width = 100;

            grvDocentes.Columns.Add("Direccion", "Direccion");
            grvDocentes.Columns["Direccion"].Width = 100; 
      
            grvDocentes.RowHeadersVisible = false;
            grvDocentes.AllowUserToAddRows = false;
            grvDocentes.AllowUserToDeleteRows = false;
            grvDocentes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grvDocentes.MultiSelect = false;
            grvDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
