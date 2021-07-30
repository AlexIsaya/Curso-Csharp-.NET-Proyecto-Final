namespace ProyectoFinal.Vistas
{
    partial class FormListado
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
            this.dgvAñoLectivo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAñoLectivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAñoLectivo
            // 
            this.dgvAñoLectivo.AllowUserToAddRows = false;
            this.dgvAñoLectivo.AllowUserToDeleteRows = false;
            this.dgvAñoLectivo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAñoLectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAñoLectivo.Location = new System.Drawing.Point(12, 113);
            this.dgvAñoLectivo.Name = "dgvAñoLectivo";
            this.dgvAñoLectivo.ReadOnly = true;
            this.dgvAñoLectivo.Size = new System.Drawing.Size(759, 225);
            this.dgvAñoLectivo.TabIndex = 6;
            this.dgvAñoLectivo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAñoLectivo_RowEnter);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 433);
            this.Controls.Add(this.dgvAñoLectivo);
            this.Name = "FormListado";
            this.Text = "FormListado";
            this.Load += new System.EventHandler(this.FormListado_Load);
            this.Controls.SetChildIndex(this.dgvAñoLectivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAñoLectivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvAñoLectivo;
    }
}