namespace ProyectoFinal.Vistas.abm
{
    partial class abminscripcion
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
            this.dtpInscripcion = new System.Windows.Forms.DateTimePicker();
            this.tbobservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbañolectivo = new System.Windows.Forms.ComboBox();
            this.dgvalumnos = new System.Windows.Forms.DataGridView();
            this.dgvdivisiones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbbuscaralumno = new System.Windows.Forms.TextBox();
            this.tbbuscardivision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btbuscaralumno = new System.Windows.Forms.Button();
            this.btbuscardivision = new System.Windows.Forms.Button();
            this.tbalumno = new System.Windows.Forms.TextBox();
            this.tbdivision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdivisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(131, 404);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(15, 404);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(904, 30);
            // 
            // dtpInscripcion
            // 
            this.dtpInscripcion.Location = new System.Drawing.Point(131, 116);
            this.dtpInscripcion.Name = "dtpInscripcion";
            this.dtpInscripcion.Size = new System.Drawing.Size(200, 20);
            this.dtpInscripcion.TabIndex = 8;
            // 
            // tbobservaciones
            // 
            this.tbobservaciones.Location = new System.Drawing.Point(131, 158);
            this.tbobservaciones.Name = "tbobservaciones";
            this.tbobservaciones.Size = new System.Drawing.Size(100, 20);
            this.tbobservaciones.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de Inscripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Observaciones";
            // 
            // cbañolectivo
            // 
            this.cbañolectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbañolectivo.FormattingEnabled = true;
            this.cbañolectivo.Location = new System.Drawing.Point(131, 200);
            this.cbañolectivo.Name = "cbañolectivo";
            this.cbañolectivo.Size = new System.Drawing.Size(121, 21);
            this.cbañolectivo.TabIndex = 13;
            // 
            // dgvalumnos
            // 
            this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalumnos.Location = new System.Drawing.Point(599, 88);
            this.dgvalumnos.Name = "dgvalumnos";
            this.dgvalumnos.Size = new System.Drawing.Size(293, 150);
            this.dgvalumnos.TabIndex = 14;
            this.dgvalumnos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalumnos_RowEnter);
            // 
            // dgvdivisiones
            // 
            this.dgvdivisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdivisiones.Location = new System.Drawing.Point(599, 277);
            this.dgvdivisiones.Name = "dgvdivisiones";
            this.dgvdivisiones.Size = new System.Drawing.Size(293, 150);
            this.dgvdivisiones.TabIndex = 15;
            this.dgvdivisiones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdivisiones_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar Alumno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Buscar Division";
            // 
            // tbbuscaralumno
            // 
            this.tbbuscaralumno.Location = new System.Drawing.Point(447, 91);
            this.tbbuscaralumno.Name = "tbbuscaralumno";
            this.tbbuscaralumno.Size = new System.Drawing.Size(100, 20);
            this.tbbuscaralumno.TabIndex = 18;
            // 
            // tbbuscardivision
            // 
            this.tbbuscardivision.Location = new System.Drawing.Point(447, 277);
            this.tbbuscardivision.Name = "tbbuscardivision";
            this.tbbuscardivision.Size = new System.Drawing.Size(100, 20);
            this.tbbuscardivision.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Año Lectivo";
            // 
            // btbuscaralumno
            // 
            this.btbuscaralumno.Location = new System.Drawing.Point(553, 91);
            this.btbuscaralumno.Name = "btbuscaralumno";
            this.btbuscaralumno.Size = new System.Drawing.Size(25, 23);
            this.btbuscaralumno.TabIndex = 21;
            this.btbuscaralumno.Text = "button1";
            this.btbuscaralumno.UseVisualStyleBackColor = true;
            this.btbuscaralumno.Click += new System.EventHandler(this.btbuscaralumno_Click);
            // 
            // btbuscardivision
            // 
            this.btbuscardivision.Location = new System.Drawing.Point(553, 275);
            this.btbuscardivision.Name = "btbuscardivision";
            this.btbuscardivision.Size = new System.Drawing.Size(25, 23);
            this.btbuscardivision.TabIndex = 22;
            this.btbuscardivision.Text = "button2";
            this.btbuscardivision.UseVisualStyleBackColor = true;
            this.btbuscardivision.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbalumno
            // 
            this.tbalumno.Enabled = false;
            this.tbalumno.Location = new System.Drawing.Point(131, 243);
            this.tbalumno.Name = "tbalumno";
            this.tbalumno.Size = new System.Drawing.Size(100, 20);
            this.tbalumno.TabIndex = 23;
            // 
            // tbdivision
            // 
            this.tbdivision.Enabled = false;
            this.tbdivision.Location = new System.Drawing.Point(131, 323);
            this.tbdivision.Name = "tbdivision";
            this.tbdivision.Size = new System.Drawing.Size(100, 20);
            this.tbdivision.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Alumno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Division";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(250, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // abminscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbdivision);
            this.Controls.Add(this.tbalumno);
            this.Controls.Add(this.btbuscardivision);
            this.Controls.Add(this.btbuscaralumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbbuscardivision);
            this.Controls.Add(this.tbbuscaralumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdivisiones);
            this.Controls.Add(this.dgvalumnos);
            this.Controls.Add(this.cbañolectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbobservaciones);
            this.Controls.Add(this.dtpInscripcion);
            this.Name = "abminscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "abminscripcion";
            this.Load += new System.EventHandler(this.abminscripcion_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.dtpInscripcion, 0);
            this.Controls.SetChildIndex(this.tbobservaciones, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbañolectivo, 0);
            this.Controls.SetChildIndex(this.dgvalumnos, 0);
            this.Controls.SetChildIndex(this.dgvdivisiones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbbuscaralumno, 0);
            this.Controls.SetChildIndex(this.tbbuscardivision, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btbuscaralumno, 0);
            this.Controls.SetChildIndex(this.btbuscardivision, 0);
            this.Controls.SetChildIndex(this.tbalumno, 0);
            this.Controls.SetChildIndex(this.tbdivision, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdivisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInscripcion;
        private System.Windows.Forms.TextBox tbobservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbañolectivo;
        private System.Windows.Forms.DataGridView dgvalumnos;
        private System.Windows.Forms.DataGridView dgvdivisiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbbuscaralumno;
        private System.Windows.Forms.TextBox tbbuscardivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btbuscaralumno;
        private System.Windows.Forms.Button btbuscardivision;
        private System.Windows.Forms.TextBox tbalumno;
        private System.Windows.Forms.TextBox tbdivision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}