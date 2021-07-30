namespace ProyectoFinal.Vistas.Modificar
{
    partial class ModificarDirectivo
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
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.tbcv = new System.Windows.Forms.TextBox();
            this.cbinstitucion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btagregar = new System.Windows.Forms.Button();
            this.ofdcv = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(154, 358);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(55, 358);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(395, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(76, 7);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(143, 94);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 8;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(143, 127);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 20);
            this.tbapellido.TabIndex = 9;
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(143, 160);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(100, 20);
            this.tbdni.TabIndex = 10;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(143, 193);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 20);
            this.tbtelefono.TabIndex = 11;
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(143, 226);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(100, 20);
            this.tbdireccion.TabIndex = 12;
            // 
            // tbcv
            // 
            this.tbcv.Enabled = false;
            this.tbcv.Location = new System.Drawing.Point(143, 259);
            this.tbcv.Name = "tbcv";
            this.tbcv.Size = new System.Drawing.Size(100, 20);
            this.tbcv.TabIndex = 13;
            // 
            // cbinstitucion
            // 
            this.cbinstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbinstitucion.FormattingEnabled = true;
            this.cbinstitucion.Location = new System.Drawing.Point(143, 293);
            this.cbinstitucion.Name = "cbinstitucion";
            this.cbinstitucion.Size = new System.Drawing.Size(121, 21);
            this.cbinstitucion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Institucion";
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(268, 257);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(75, 23);
            this.btagregar.TabIndex = 23;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // ofdcv
            // 
            this.ofdcv.FileName = "openFileDialog1";
            // 
            // ModificarDirectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 404);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbinstitucion);
            this.Controls.Add(this.tbcv);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Name = "ModificarDirectivo";
            this.Text = "ModificarDirectivo";
            this.Load += new System.EventHandler(this.ModificarDirectivo_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.tbapellido, 0);
            this.Controls.SetChildIndex(this.tbdni, 0);
            this.Controls.SetChildIndex(this.tbtelefono, 0);
            this.Controls.SetChildIndex(this.tbdireccion, 0);
            this.Controls.SetChildIndex(this.tbcv, 0);
            this.Controls.SetChildIndex(this.cbinstitucion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btagregar, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbdni;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.TextBox tbcv;
        private System.Windows.Forms.ComboBox cbinstitucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.OpenFileDialog ofdcv;
    }
}