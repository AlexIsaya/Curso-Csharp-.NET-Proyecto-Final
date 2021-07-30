namespace ProyectoFinal.Vistas.Modificar
{
    partial class ModificarGrado
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
            this.cbnivel = new System.Windows.Forms.ComboBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(371, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(74, 7);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // cbnivel
            // 
            this.cbnivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnivel.FormattingEnabled = true;
            this.cbnivel.Location = new System.Drawing.Point(158, 222);
            this.cbnivel.Name = "cbnivel";
            this.cbnivel.Size = new System.Drawing.Size(121, 21);
            this.cbnivel.TabIndex = 33;
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(158, 180);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbdescripcion.TabIndex = 32;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(158, 138);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 31;
            // 
            // ModificarGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbnivel);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.tbnombre);
            this.Name = "ModificarGrado";
            this.Text = "ModificarGrado";
            this.Load += new System.EventHandler(this.ModificarGrado_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.tbdescripcion, 0);
            this.Controls.SetChildIndex(this.cbnivel, 0);
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
        private System.Windows.Forms.ComboBox cbnivel;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.TextBox tbnombre;
    }
}