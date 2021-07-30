namespace ProyectoFinal.Vistas.abm
{
    partial class abmasignaciongrado
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
            this.tbdocente = new System.Windows.Forms.TextBox();
            this.tbdivision = new System.Windows.Forms.TextBox();
            this.lbDocente = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdocentes = new System.Windows.Forms.DataGridView();
            this.dgvdivisiones = new System.Windows.Forms.DataGridView();
            this.tbbuscardocente = new System.Windows.Forms.TextBox();
            this.tbbuscardivision = new System.Windows.Forms.TextBox();
            this.btbuscardocente = new System.Windows.Forms.Button();
            this.btbuscardivision = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdivisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(135, 398);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(36, 398);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(291, 7);
            // 
            // tbdocente
            // 
            this.tbdocente.Enabled = false;
            this.tbdocente.Location = new System.Drawing.Point(120, 154);
            this.tbdocente.Name = "tbdocente";
            this.tbdocente.Size = new System.Drawing.Size(100, 20);
            this.tbdocente.TabIndex = 8;
            // 
            // tbdivision
            // 
            this.tbdivision.Enabled = false;
            this.tbdivision.Location = new System.Drawing.Point(120, 198);
            this.tbdivision.Name = "tbdivision";
            this.tbdivision.Size = new System.Drawing.Size(100, 20);
            this.tbdivision.TabIndex = 9;
            // 
            // lbDocente
            // 
            this.lbDocente.AutoSize = true;
            this.lbDocente.Location = new System.Drawing.Point(44, 157);
            this.lbDocente.Name = "lbDocente";
            this.lbDocente.Size = new System.Drawing.Size(48, 13);
            this.lbDocente.TabIndex = 10;
            this.lbDocente.Text = "Docente";
            // 
            // lbDivision
            // 
            this.lbDivision.AutoSize = true;
            this.lbDivision.Location = new System.Drawing.Point(44, 201);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(44, 13);
            this.lbDivision.TabIndex = 11;
            this.lbDivision.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buscar Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscar Division";
            // 
            // dgvdocentes
            // 
            this.dgvdocentes.AllowUserToAddRows = false;
            this.dgvdocentes.AllowUserToDeleteRows = false;
            this.dgvdocentes.AllowUserToResizeColumns = false;
            this.dgvdocentes.AllowUserToResizeRows = false;
            this.dgvdocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdocentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdocentes.Location = new System.Drawing.Point(507, 92);
            this.dgvdocentes.Name = "dgvdocentes";
            this.dgvdocentes.Size = new System.Drawing.Size(322, 150);
            this.dgvdocentes.TabIndex = 14;
            this.dgvdocentes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdocentes_RowEnter);
            // 
            // dgvdivisiones
            // 
            this.dgvdivisiones.AllowUserToAddRows = false;
            this.dgvdivisiones.AllowUserToDeleteRows = false;
            this.dgvdivisiones.AllowUserToResizeColumns = false;
            this.dgvdivisiones.AllowUserToResizeRows = false;
            this.dgvdivisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdivisiones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdivisiones.Location = new System.Drawing.Point(507, 271);
            this.dgvdivisiones.Name = "dgvdivisiones";
            this.dgvdivisiones.Size = new System.Drawing.Size(322, 150);
            this.dgvdivisiones.TabIndex = 15;
            this.dgvdivisiones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdivisiones_RowEnter);
            // 
            // tbbuscardocente
            // 
            this.tbbuscardocente.Location = new System.Drawing.Point(351, 92);
            this.tbbuscardocente.Name = "tbbuscardocente";
            this.tbbuscardocente.Size = new System.Drawing.Size(100, 20);
            this.tbbuscardocente.TabIndex = 16;
            // 
            // tbbuscardivision
            // 
            this.tbbuscardivision.Location = new System.Drawing.Point(351, 268);
            this.tbbuscardivision.Name = "tbbuscardivision";
            this.tbbuscardivision.Size = new System.Drawing.Size(100, 20);
            this.tbbuscardivision.TabIndex = 17;
            // 
            // btbuscardocente
            // 
            this.btbuscardocente.Location = new System.Drawing.Point(457, 90);
            this.btbuscardocente.Name = "btbuscardocente";
            this.btbuscardocente.Size = new System.Drawing.Size(23, 23);
            this.btbuscardocente.TabIndex = 18;
            this.btbuscardocente.Text = "button1";
            this.btbuscardocente.UseVisualStyleBackColor = true;
            this.btbuscardocente.Click += new System.EventHandler(this.btbuscardocente_Click);
            // 
            // btbuscardivision
            // 
            this.btbuscardivision.Location = new System.Drawing.Point(457, 266);
            this.btbuscardivision.Name = "btbuscardivision";
            this.btbuscardivision.Size = new System.Drawing.Size(23, 23);
            this.btbuscardivision.TabIndex = 19;
            this.btbuscardivision.Text = "button2";
            this.btbuscardivision.UseVisualStyleBackColor = true;
            this.btbuscardivision.Click += new System.EventHandler(this.btbuscardivision_Click);
            // 
            // abmasignaciongrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 458);
            this.Controls.Add(this.btbuscardivision);
            this.Controls.Add(this.btbuscardocente);
            this.Controls.Add(this.tbbuscardivision);
            this.Controls.Add(this.tbbuscardocente);
            this.Controls.Add(this.dgvdivisiones);
            this.Controls.Add(this.dgvdocentes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.lbDocente);
            this.Controls.Add(this.tbdivision);
            this.Controls.Add(this.tbdocente);
            this.Name = "abmasignaciongrado";
            this.Text = "abmasignaciongrado";
            this.Load += new System.EventHandler(this.abmasignaciongrado_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btregresar, 0);
            this.Controls.SetChildIndex(this.btaceptar, 0);
            this.Controls.SetChildIndex(this.tbdocente, 0);
            this.Controls.SetChildIndex(this.tbdivision, 0);
            this.Controls.SetChildIndex(this.lbDocente, 0);
            this.Controls.SetChildIndex(this.lbDivision, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dgvdocentes, 0);
            this.Controls.SetChildIndex(this.dgvdivisiones, 0);
            this.Controls.SetChildIndex(this.tbbuscardocente, 0);
            this.Controls.SetChildIndex(this.tbbuscardivision, 0);
            this.Controls.SetChildIndex(this.btbuscardocente, 0);
            this.Controls.SetChildIndex(this.btbuscardivision, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdivisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvdocentes;
        public System.Windows.Forms.TextBox tbdocente;
        public System.Windows.Forms.TextBox tbdivision;
        public System.Windows.Forms.Label lbDocente;
        public System.Windows.Forms.Label lbDivision;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvdivisiones;
        public System.Windows.Forms.TextBox tbbuscardocente;
        public System.Windows.Forms.TextBox tbbuscardivision;
        public System.Windows.Forms.Button btbuscardocente;
        public System.Windows.Forms.Button btbuscardivision;
    }
}