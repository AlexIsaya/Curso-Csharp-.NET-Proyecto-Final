namespace ProyectoFinal.Vistas.Modificar
{
    partial class ModificarNivel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbturno = new System.Windows.Forms.ComboBox();
            this.cbinstitucion = new System.Windows.Forms.ComboBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btaceptar
            // 
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(337, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(65, 7);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Institucion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre";
            // 
            // cbturno
            // 
            this.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbturno.FormattingEnabled = true;
            this.cbturno.Location = new System.Drawing.Point(129, 216);
            this.cbturno.Name = "cbturno";
            this.cbturno.Size = new System.Drawing.Size(121, 21);
            this.cbturno.TabIndex = 35;
            // 
            // cbinstitucion
            // 
            this.cbinstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbinstitucion.FormattingEnabled = true;
            this.cbinstitucion.Location = new System.Drawing.Point(129, 182);
            this.cbinstitucion.Name = "cbinstitucion";
            this.cbinstitucion.Size = new System.Drawing.Size(121, 21);
            this.cbinstitucion.TabIndex = 34;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(129, 149);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 33;
            // 
            // ModificarNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbturno);
            this.Controls.Add(this.cbinstitucion);
            this.Controls.Add(this.tbnombre);
            this.Name = "ModificarNivel";
            this.Text = "ModificarNivel";
            this.Load += new System.EventHandler(this.ModificarNivel_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.cbinstitucion, 0);
            this.Controls.SetChildIndex(this.cbturno, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbturno;
        private System.Windows.Forms.ComboBox cbinstitucion;
        private System.Windows.Forms.TextBox tbnombre;
    }
}