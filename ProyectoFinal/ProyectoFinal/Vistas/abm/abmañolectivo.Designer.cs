namespace ProyectoFinal.Vistas.abm
{
    partial class abmañolectivo
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
            this.tbañolectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(178, 184);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(79, 184);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(364, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(153, 9);
            // 
            // tbañolectivo
            // 
            this.tbañolectivo.Location = new System.Drawing.Point(122, 122);
            this.tbañolectivo.Name = "tbañolectivo";
            this.tbañolectivo.Size = new System.Drawing.Size(100, 20);
            this.tbañolectivo.TabIndex = 8;
            this.tbañolectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbañolectivo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Año";
            // 
            // abmañolectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbañolectivo);
            this.Name = "abmañolectivo";
            this.Text = "abmañolectivo";
            this.Load += new System.EventHandler(this.abmañolectivo_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbañolectivo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbañolectivo;
        private System.Windows.Forms.Label label1;
    }
}