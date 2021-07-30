namespace ProyectoFinal.Vistas.abm
{
    partial class abmdirectivos
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
            this.lbapellido = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.cbinstitucion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btbuscarcv = new System.Windows.Forms.Button();
            this.ofdcv = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(159, 332);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(60, 332);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(460, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(155, 7);
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Location = new System.Drawing.Point(57, 122);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(44, 13);
            this.lbapellido.TabIndex = 25;
            this.lbapellido.Text = "Apellido";
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(184, 119);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 20);
            this.tbapellido.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(184, 203);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 20);
            this.tbtelefono.TabIndex = 20;
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(184, 175);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(100, 20);
            this.tbdni.TabIndex = 19;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(184, 147);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Direccion";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(184, 231);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(100, 20);
            this.tbdireccion.TabIndex = 36;
            // 
            // cbinstitucion
            // 
            this.cbinstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbinstitucion.FormattingEnabled = true;
            this.cbinstitucion.Location = new System.Drawing.Point(184, 259);
            this.cbinstitucion.Name = "cbinstitucion";
            this.cbinstitucion.Size = new System.Drawing.Size(121, 21);
            this.cbinstitucion.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Institucion";
            // 
            // tbcv
            // 
            this.tbcv.Enabled = false;
            this.tbcv.Location = new System.Drawing.Point(184, 286);
            this.tbcv.Name = "tbcv";
            this.tbcv.Size = new System.Drawing.Size(100, 20);
            this.tbcv.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cv";
            // 
            // btbuscarcv
            // 
            this.btbuscarcv.Location = new System.Drawing.Point(316, 284);
            this.btbuscarcv.Name = "btbuscarcv";
            this.btbuscarcv.Size = new System.Drawing.Size(92, 23);
            this.btbuscarcv.TabIndex = 42;
            this.btbuscarcv.Text = "Agregar Cv";
            this.btbuscarcv.UseVisualStyleBackColor = true;
            this.btbuscarcv.Click += new System.EventHandler(this.btbuscarcv_Click);
            // 
            // ofdcv
            // 
            this.ofdcv.FileName = "openFileDialog1";
            // 
            // abmdirectivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 412);
            this.Controls.Add(this.btbuscarcv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbcv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbinstitucion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.tbnombre);
            this.Name = "abmdirectivos";
            this.Text = "abmdirectivos";
            this.Load += new System.EventHandler(this.abmdirectivos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.tbdni, 0);
            this.Controls.SetChildIndex(this.tbtelefono, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbapellido, 0);
            this.Controls.SetChildIndex(this.lbapellido, 0);
            this.Controls.SetChildIndex(this.tbdireccion, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cbinstitucion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbcv, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btbuscarcv, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbdni;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.ComboBox cbinstitucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btbuscarcv;
        private System.Windows.Forms.OpenFileDialog ofdcv;
    }
}