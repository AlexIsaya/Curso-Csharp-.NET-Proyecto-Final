namespace ProyectoFinal.Vistas.Modificar
{
    partial class ModificarCondicionDocente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(167, 221);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(68, 221);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(378, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(53, 8);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Descripcion";
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(152, 125);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbdescripcion.TabIndex = 35;
            // 
            // ModificarCondicionDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdescripcion);
            this.Name = "ModificarCondicionDocente";
            this.Text = "ModificarCondicionDocente";
            this.Load += new System.EventHandler(this.ModificarCondicionDocente_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbdescripcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdescripcion;
    }
}