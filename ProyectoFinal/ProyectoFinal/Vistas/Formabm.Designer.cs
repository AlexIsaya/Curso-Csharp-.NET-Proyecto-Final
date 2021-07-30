namespace ProyectoFinal.Vistas
{
    partial class Formabm
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
            this.btregresar = new System.Windows.Forms.Button();
            this.btaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(165, 356);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(75, 23);
            this.btregresar.TabIndex = 6;
            this.btregresar.Text = "Regresar";
            this.btregresar.UseVisualStyleBackColor = true;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(66, 356);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(75, 23);
            this.btaceptar.TabIndex = 7;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            // 
            // Formabm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 414);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.btregresar);
            this.Name = "Formabm";
            this.Text = "Formabm";
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btregresar;
        public System.Windows.Forms.Button btaceptar;

    }
}