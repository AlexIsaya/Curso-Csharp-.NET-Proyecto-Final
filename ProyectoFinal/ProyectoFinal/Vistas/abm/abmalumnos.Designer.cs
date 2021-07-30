namespace ProyectoFinal.Vistas.abm
{
    partial class abmalumnos
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.picbfoto = new System.Windows.Forms.PictureBox();
            this.btbuscarfoto = new System.Windows.Forms.Button();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbapellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbpadre = new System.Windows.Forms.TextBox();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.tbmadre = new System.Windows.Forms.TextBox();
            this.tbtutor = new System.Windows.Forms.TextBox();
            this.tbenfermedades = new System.Windows.Forms.TextBox();
            this.tbobservaciones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(134, 453);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(35, 453);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(862, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(392, 7);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dni";
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(165, 100);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(100, 20);
            this.tbdni.TabIndex = 20;
            this.tbdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbdni_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(165, 74);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Foto:";
            // 
            // picbfoto
            // 
            this.picbfoto.Location = new System.Drawing.Point(453, 103);
            this.picbfoto.Name = "picbfoto";
            this.picbfoto.Size = new System.Drawing.Size(141, 117);
            this.picbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbfoto.TabIndex = 37;
            this.picbfoto.TabStop = false;
            // 
            // btbuscarfoto
            // 
            this.btbuscarfoto.Location = new System.Drawing.Point(453, 228);
            this.btbuscarfoto.Name = "btbuscarfoto";
            this.btbuscarfoto.Size = new System.Drawing.Size(141, 23);
            this.btbuscarfoto.TabIndex = 38;
            this.btbuscarfoto.Text = "Agregar Foto";
            this.btbuscarfoto.UseVisualStyleBackColor = true;
            this.btbuscarfoto.Click += new System.EventHandler(this.btbuscarfoto_Click);
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            this.ofdfoto.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Padre";
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Location = new System.Drawing.Point(38, 136);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(44, 13);
            this.lbapellido.TabIndex = 26;
            this.lbapellido.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Madre";
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(165, 133);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 20);
            this.tbapellido.TabIndex = 25;
            this.tbapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbapellido_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tutor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Enfermedades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Observaciones";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(165, 199);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 20);
            this.tbtelefono.TabIndex = 21;
            this.tbtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtelefono_KeyPress);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(165, 166);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 19;
            this.tbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnombre_KeyPress);
            // 
            // tbpadre
            // 
            this.tbpadre.Location = new System.Drawing.Point(165, 232);
            this.tbpadre.Name = "tbpadre";
            this.tbpadre.Size = new System.Drawing.Size(100, 20);
            this.tbpadre.TabIndex = 13;
            this.tbpadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpadre_KeyPress);
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(165, 397);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(100, 20);
            this.tbdireccion.TabIndex = 34;
            // 
            // tbmadre
            // 
            this.tbmadre.Location = new System.Drawing.Point(165, 265);
            this.tbmadre.Name = "tbmadre";
            this.tbmadre.Size = new System.Drawing.Size(100, 20);
            this.tbmadre.TabIndex = 12;
            this.tbmadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmadre_KeyPress);
            // 
            // tbtutor
            // 
            this.tbtutor.Location = new System.Drawing.Point(165, 298);
            this.tbtutor.Name = "tbtutor";
            this.tbtutor.Size = new System.Drawing.Size(100, 20);
            this.tbtutor.TabIndex = 11;
            this.tbtutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtutor_KeyPress);
            // 
            // tbenfermedades
            // 
            this.tbenfermedades.Location = new System.Drawing.Point(165, 331);
            this.tbenfermedades.Name = "tbenfermedades";
            this.tbenfermedades.Size = new System.Drawing.Size(100, 20);
            this.tbenfermedades.TabIndex = 10;
            this.tbenfermedades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbenfermedades_KeyPress);
            // 
            // tbobservaciones
            // 
            this.tbobservaciones.Location = new System.Drawing.Point(165, 364);
            this.tbobservaciones.Name = "tbobservaciones";
            this.tbobservaciones.Size = new System.Drawing.Size(100, 20);
            this.tbobservaciones.TabIndex = 9;
            this.tbobservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbobservaciones_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Direccion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(271, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(271, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(271, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 25);
            this.label14.TabIndex = 41;
            this.label14.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(271, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 25);
            this.label15.TabIndex = 42;
            this.label15.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(271, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(356, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(380, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Campos obligatorios";
            // 
            // abmalumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 488);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbobservaciones);
            this.Controls.Add(this.tbenfermedades);
            this.Controls.Add(this.tbtutor);
            this.Controls.Add(this.tbmadre);
            this.Controls.Add(this.btbuscarfoto);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.tbpadre);
            this.Controls.Add(this.picbfoto);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.label2);
            this.Name = "abmalumnos";
            this.Text = "abmalumnos";
            this.Load += new System.EventHandler(this.abmalumnos_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbapellido, 0);
            this.Controls.SetChildIndex(this.lbapellido, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbdni, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dtpfecha, 0);
            this.Controls.SetChildIndex(this.tbtelefono, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.picbfoto, 0);
            this.Controls.SetChildIndex(this.tbpadre, 0);
            this.Controls.SetChildIndex(this.tbdireccion, 0);
            this.Controls.SetChildIndex(this.btbuscarfoto, 0);
            this.Controls.SetChildIndex(this.tbmadre, 0);
            this.Controls.SetChildIndex(this.tbtutor, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tbenfermedades, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.tbobservaciones, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
        public System.Windows.Forms.TextBox tbdni;
        public System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox picbfoto;
        public System.Windows.Forms.Button btbuscarfoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbtelefono;
        public System.Windows.Forms.TextBox tbnombre;
        public System.Windows.Forms.TextBox tbpadre;
        public System.Windows.Forms.TextBox tbdireccion;
        public System.Windows.Forms.TextBox tbmadre;
        public System.Windows.Forms.TextBox tbtutor;
        public System.Windows.Forms.TextBox tbenfermedades;
        public System.Windows.Forms.TextBox tbobservaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}