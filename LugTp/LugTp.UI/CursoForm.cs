using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LugTp.Data.Factories;
using LugTp.Entities;

namespace LugTp.UI
{
    public partial class CursoForm : Form
    {
        private List<Docente> _docentes;
        private List<Curso> _cursos;
        private List<Unidad> _unidades;
        private Curso _currentCurso;

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
            grvDocentes.Columns.Add("Docente_Id", "Docente_Id");
            grvDocentes.Columns["Docente_Id"].Width = 100;
            grvDocentes.Columns["Docente_Id"].Visible = false;

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
            _unidades = Form1.Context.Unidades.GetAll();
            _cursos?.ToList().ForEach(alumno =>
                     {
                         grvDocentes.Rows.Add(alumno.Id,
                             alumno.Nombre,
                             alumno.Duracion,
                             alumno.Docente.Nombre,
                             alumno.Docente.Id);
                     });
            chkCursos.Items.Clear();
            _unidades.ForEach(x=> chkCursos.Items.Add(x.Tema));
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var idToUpdate = int.Parse(grvDocentes.SelectedRows[0].Cells["Id"].Value.ToString());
            var cursoToUpdate = _cursos.FirstOrDefault(x => x.Id == idToUpdate);
            cursoToUpdate.Nombre = txtNombre.Text;
            cursoToUpdate.Duracion = int.Parse(txtDuracion.Text);

            var newDocente = _docentes.FirstOrDefault(x =>
                x.Nombre == cmbDocente.SelectedItem.ToString());
            cursoToUpdate.Docente = newDocente;


            Form1.Context.Cursos.Update(cursoToUpdate);
            Form1.Context.SaveChange();
            LoadData();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            var docente = _docentes.First(x => cmbDocente.SelectedItem.ToString().Contains(x.Nombre));

            var curso = new Curso(txtNombre.Text, 
                int.Parse(txtDuracion.Text), 
                docente,
                new List<Unidad>(),
                new CollectionsUnidadesFactory());
            Form1.Context.Cursos.Add(curso);
            Form1.Context.SaveChange();
            LoadData();
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
                _currentCurso = _cursos.FirstOrDefault(x =>
                  x.Id == int.Parse(grvDocentes.SelectedRows[0].Cells["Id"].Value.ToString()));
                btnEliminar.Enabled = true;
                txtNombre.Text = grvDocentes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDuracion.Text = grvDocentes.SelectedRows[0].Cells["Duracion"].Value.ToString();
                var docente = grvDocentes.SelectedRows[0].Cells["Docente"].Value.ToString();
                cmbDocente.SelectedItem = docente;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
                chkCursos.Items.Clear();
                var index = 0;
                _unidades?.ForEach(unidad =>
                {
                    chkCursos.Items.Add(Name = unidad.Tema);

                    if (_currentCurso.Unidades.Any(x => x.Tema == unidad.Tema))
                    {
                        chkCursos.SetItemChecked(index, true);
                    }
                    ++index;
                });

            }
            else
            {
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var cursoToDelete = _cursos.FirstOrDefault(x =>
                x.Id == int.Parse(grvDocentes.SelectedRows[0].Cells["Id"].Value.ToString()));
            Form1.Context.Cursos.Delete(cursoToDelete);
            Form1.Context.SaveChange();
            LoadData();
        }
     
    }
}
