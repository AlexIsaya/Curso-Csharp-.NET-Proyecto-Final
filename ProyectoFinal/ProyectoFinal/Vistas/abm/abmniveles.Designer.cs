namespace ProyectoFinal.Vistas.abm
{
    partial class abmniveles
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
            this.cbinstitucion = new System.Windows.Forms.ComboBox();
            this.cbturno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btregresar
            // 
            this.btregresar.Location = new System.Drawing.Point(132, 234);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(33, 234);
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(348, 30);
            // 
            // lbtitulo
            // 
            this.lbtitulo.Location = new System.Drawing.Point(81, 7);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(116, 106);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 8;
            // 
            // cbinstitucion
            // 
            this.cbinstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbinstitucion.FormattingEnabled = true;
            this.cbinstitucion.Location = new System.Drawing.Point(116, 139);
            this.cbinstitucion.Name = "cbinstitucion";
            this.cbinstitucion.Size = new System.Drawing.Size(121, 21);
            this.cbinstitucion.TabIndex = 9;
            // 
            // cbturno
            // 
            this.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbturno.FormattingEnabled = true;
            this.cbturno.Location = new System.Drawing.Point(116, 173);
            this.cbturno.Name = "cbturno";
            this.cbturno.Size = new System.Drawing.Size(121, 21);
            this.cbturno.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Institucion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Turno";
            // 
            // abmniveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbturno);
            this.Controls.Add(this.cbinstitucion);
            this.Controls.Add(this.tbnombre);
            this.Name = "abmniveles";
            this.Text = "abmniveles";
            this.Load += new System.EventHandler(this.abmniveles_Load);
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

        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.ComboBox cbinstitucion;
        private System.Windows.Forms.ComboBox cbturno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}