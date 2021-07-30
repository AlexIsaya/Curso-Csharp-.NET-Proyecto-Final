namespace ProyectoFinal.Vistas.abm
{
    partial class abmdocente
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.cbcondicion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.lbapellido = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(145, 306);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(46, 306);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(458, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(108, 7);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(165, 150);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 8;
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(165, 180);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(100, 20);
            this.tbdni.TabIndex = 9;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(165, 210);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 20);
            this.tbtelefono.TabIndex = 10;
            // 
            // cbcondicion
            // 
            this.cbcondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcondicion.FormattingEnabled = true;
            this.cbcondicion.Location = new System.Drawing.Point(165, 240);
            this.cbcondicion.Name = "cbcondicion";
            this.cbcondicion.Size = new System.Drawing.Size(121, 21);
            this.cbcondicion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Condicion Docente";
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(165, 124);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 20);
            this.tbapellido.TabIndex = 16;
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Location = new System.Drawing.Point(43, 127);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(44, 13);
            this.lbapellido.TabIndex = 17;
            this.lbapellido.Text = "Apellido";
            // 
            // abmdocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 415);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbcondicion);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.tbnombre);
            this.Name = "abmdocente";
            this.Text = "abmdocente";
            this.Load += new System.EventHandler(this.abmdocente_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.tbdni, 0);
            this.Controls.SetChildIndex(this.tbtelefono, 0);
            this.Controls.SetChildIndex(this.cbcondicion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbapellido, 0);
            this.Controls.SetChildIndex(this.lbapellido, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbdni;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.ComboBox cbcondicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.Label lbapellido;
    }
}