namespace ProyectoFinal.Vistas.Listado
{
    partial class ListadoAñoLectivo
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
            this.bteliminar = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(275, 7);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(146, 377);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 12;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Visible = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(12, 377);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 23);
            this.btmodificar.TabIndex = 11;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Visible = false;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // ListadoAñoLectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 433);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btmodificar);
            this.Name = "ListadoAñoLectivo";
            this.Text = "ListadoAñoLectivo";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btmodificar, 0);
            this.Controls.SetChildIndex(this.bteliminar, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btmodificar;
    }
}