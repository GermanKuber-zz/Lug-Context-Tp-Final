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
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            var docente = new Docente(txtNombre.Text,
                                     txtApellido.Text,
                                     txtDireccion.Text,
                                     txtTelefono.Text,
                                     cmbCargo.SelectedItem.ToString(),
                                     txtProfesion.Text);

            Form1.Context.Docentes.Add(docente);
            Form1.Context.SaveChange();
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
            var docentes = Form1.Context.Docentes.GetAll();

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

            
            LoadData();
            if (grvDocentes.Rows.Count > 0)
                grvDocentes.Rows[0].Selected = true;

            CheckBtnEnables();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idToDelete = int.Parse(grvDocentes.SelectedRows[0].Cells["Id"].Value.ToString());
            var docenteToDelete = Form1.Context.Docentes.First(x => x.Id == idToDelete);
            Form1.Context.Docentes.Delete(docenteToDelete);
            Form1.Context.SaveChange();
            LoadData();
        }

    

        private void CheckBtnEnables()
        {
            if (grvDocentes.SelectedRows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
                txtNombre.Text = grvDocentes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtApellido.Text = grvDocentes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                txtDireccion.Text = grvDocentes.SelectedRows[0].Cells["Direccion"].Value.ToString();
                txtTelefono.Text = grvDocentes.SelectedRows[0].Cells["Telefono"].Value.ToString();
                cmbCargo.SelectedItem = grvDocentes.SelectedRows[0].Cells["Cargo"].Value.ToString();
                txtProfesion.Text = grvDocentes.SelectedRows[0].Cells["Profesion"].Value.ToString();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }

        private void grvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            CheckBtnEnables();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var idToDelete = int.Parse(grvDocentes.SelectedRows[0].Cells["Id"].Value.ToString());
            var docenteToUpdate = Form1.Context.Docentes.First(x => x.Id == idToDelete);
            docenteToUpdate.Nombre = txtNombre.Text ;
            docenteToUpdate.Apellido= txtApellido.Text ;
            docenteToUpdate.Direccion = txtDireccion.Text ;
            docenteToUpdate.Telefono = txtTelefono.Text ;
            docenteToUpdate.Cargo = cmbCargo.SelectedItem.ToString() ;
            docenteToUpdate.Profesion =  txtProfesion.Text ;
            Form1.Context.Docentes.Update(docenteToUpdate);
            Form1.Context.SaveChange();
            LoadData();
        }
    }
}
