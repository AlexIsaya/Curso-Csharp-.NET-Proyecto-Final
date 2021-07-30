namespace ProyectoFinal.Vistas.Modificar
{
    partial class Modificaralumno
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
            this.btaceptar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbfoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(133, 434);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(287, 403);
            this.btaceptar.Visible = false;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(873, 30);
            // 
            // btaceptar2
            // 
            this.btaceptar2.Location = new System.Drawing.Point(38, 434);
            this.btaceptar2.Name = "btaceptar2";
            this.btaceptar2.Size = new System.Drawing.Size(75, 23);
            this.btaceptar2.TabIndex = 40;
            this.btaceptar2.Text = "Aceptar";
            this.btaceptar2.UseVisualStyleBackColor = true;
            this.btaceptar2.Click += new System.EventHandler(this.btaceptar2_Click);
            // 
            // Modificaralumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 469);
            this.Controls.Add(this.btaceptar2);
            this.Name = "Modificaralumno";
            this.Text = "Modificaralumno";
            this.Load += new System.EventHandler(this.Modificaralumno_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tbobservaciones, 0);
            this.Controls.SetChildIndex(this.tbenfermedades, 0);
            this.Controls.SetChildIndex(this.tbtutor, 0);
            this.Controls.SetChildIndex(this.tbmadre, 0);
            this.Controls.SetChildIndex(this.tbpadre, 0);
            this.Controls.SetChildIndex(this.tbnombre, 0);
            this.Controls.SetChildIndex(this.tbdni, 0);
            this.Controls.SetChildIndex(this.tbtelefono, 0);
            this.Controls.SetChildIndex(this.tbapellido, 0);
            this.Controls.SetChildIndex(this.dtpfecha, 0);
            this.Controls.SetChildIndex(this.tbdireccion, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.picbfoto, 0);
            this.Controls.SetChildIndex(this.btbuscarfoto, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.btaceptar2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picbfoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btaceptar2;
    }
}