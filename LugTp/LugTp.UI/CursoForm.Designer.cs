namespace LugTp.UI
{
    partial class CursoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDocente = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvDocentes = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDocente);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAccion);
            this.groupBox2.Controls.Add(this.txtDuracion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(48, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 279);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Docentes";
            // 
            // cmbDocente
            // 
            this.cmbDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.Location = new System.Drawing.Point(111, 90);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.Size = new System.Drawing.Size(121, 21);
            this.cmbDocente.TabIndex = 15;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(205, 125);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(286, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(367, 125);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 23);
            this.btnAccion.TabIndex = 12;
            this.btnAccion.Text = "Agregar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(111, 58);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(121, 20);
            this.txtDuracion.TabIndex = 8;
            this.txtDuracion.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duración :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvDocentes);
            this.groupBox1.Location = new System.Drawing.Point(48, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos";
            // 
            // grvDocentes
            // 
            this.grvDocentes.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.grvDocentes.AllowDrop = true;
            this.grvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDocentes.Location = new System.Drawing.Point(0, 19);
            this.grvDocentes.Name = "grvDocentes";
            this.grvDocentes.Size = new System.Drawing.Size(776, 238);
            this.grvDocentes.TabIndex = 0;
            // 
            // CursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CursoForm";
            this.Text = "CursoForm";
            this.Load += new System.EventHandler(this.CursoForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvDocentes;
        private System.Windows.Forms.ComboBox cmbDocente;
    }
}