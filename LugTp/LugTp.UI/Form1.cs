using System;
using System.Windows.Forms;

namespace LugTp.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var docentesForm = new Docentes();
            docentesForm.MdiParent = this;
            docentesForm.MinimizeBox = false;
            docentesForm.MaximizeBox = false;
            docentesForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
