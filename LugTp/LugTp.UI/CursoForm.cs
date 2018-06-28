using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LugTp.Entities;

namespace LugTp.UI
{
    public partial class CursoForm : Form
    {
        private List<Alumno> _alumnos;
        private List<Docente> _docentes;
        private List<Curso> _cursos;

        public CursoForm()
        {
            InitializeComponent();
        }

        private void CursoForm_Load(object sender, EventArgs e)
        {
            grvDocentes.Columns.Add("Id", "Id");
            grvDocentes.Columns.Add("Nombre", "Nombre");
            grvDocentes.Columns["Nombre"].Width = 100;

            grvDocentes.Columns.Add("Duracion", "Duracion");
            grvDocentes.Columns["Duracion"].Width = 100;

            grvDocentes.Columns.Add("Docente", "Docente");
            grvDocentes.Columns["Docente"].Width = 100;

            grvDocentes.RowHeadersVisible = false;
            grvDocentes.AllowUserToAddRows = false;
            grvDocentes.AllowUserToDeleteRows = false;
            grvDocentes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grvDocentes.MultiSelect = false;
            grvDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            _docentes = Form1.Context.Docentes.GetAll();
            _cursos = Form1.Context.Cursos.GetAll();

            _docentes?.ForEach(docente =>
            {
                cmbDocente.Items.Add(Name = docente.Nombre);
            });

            cmbDocente.SelectedIndex = 0;

            LoadData();
        }
        private void LoadData()
        {
            grvDocentes.Rows.Clear();

            _cursos = Form1.Context.Cursos.GetAll();

            _cursos?.ToList().ForEach(alumno =>
            {
                grvDocentes.Rows.Add(alumno.Id,
                    alumno.Nombre,
                    alumno.Duracion,
                    alumno.Docente);
            });
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            var docente = _docentes.First(x => cmbDocente.SelectedItem.ToString().Contains(x.Nombre));

            var curso = new Curso(txtNombre.Text, int.Parse(txtDuracion.Text), docente);
            Form1.Context.Cursos.Add(curso);
            Form1.Context.SaveChange();
            curso.Alumnos.Delete(_alumnos.First());
            Form1.Context.SaveChange();

        }
        private void CheckCompleteForm()
        {
            //if (string.IsNullOrWhiteSpace(txtNombre.Text)
            //    ||
            //    string.IsNullOrWhiteSpace(txtDuracion.Text)
            //    ||
            //    !string.IsNullOrWhiteSpace(cmbDocente.SelectedItem.ToString())
            //    ||
            //    chkAlumnos.CheckedItems.Count == 0)
            //{
            //    btnAccion.Enabled = false;
            //}
            //else
            //{
            //    btnAccion.Enabled = true;
            //}
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void chkAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void chkDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCompleteForm();
        }

        private void grvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            CheckBtnEnables();
        }
        private void CheckBtnEnables()
        {
            if (grvDocentes.SelectedRows.Count > 0)
            {
                txtNombre.Text = grvDocentes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDuracion.Text = grvDocentes.SelectedRows[0].Cells["Duracion"].Value.ToString();
                var docente = grvDocentes.SelectedRows[0].Cells["Docente"].Value.ToString();
                cmbDocente.SelectedItem = docente;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }
    }
}
