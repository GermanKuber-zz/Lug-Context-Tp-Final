using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LugTp.Data.SqlExecute.Alumno;
using LugTp.Data.SqlExecute.AlumnoCurso;
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
            _docentes = Form1.Context.Docentes.GetAll();
            _cursos = Form1.Context.Cursos.GetAll();
            _alumnos = Form1.Context.Alumnos.GetAll();

            _docentes?.ForEach(docente =>
            {

                cmbDocente.Items.Add(Name = docente.Nombre);
            });
            cmbDocente.SelectedIndex = 0;
            _alumnos?.ForEach(alumno => { chkAlumnos.Items.Add(Name = alumno.Nombre); });
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            var alumnos = _alumnos.Where(x => chkAlumnos.CheckedItems.Contains(x.Nombre))?.ToList();
            var docente = _docentes.First(x => cmbDocente.SelectedItem.ToString().Contains(x.Nombre));

            var alumnosBase = new CollectionBase<Alumno>(new List<Alumno>(), new AlumnoCursoSqlExecutions(), () => { return null; });
            var curso = new Curso(txtNombre.Text, int.Parse(txtDuracion.Text), docente, alumnosBase);
            curso.Alumnos.Add(_alumnos.First());
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
    }
}
