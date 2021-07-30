namespace ProyectoFinal.Vistas
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbrestore = new System.Windows.Forms.PictureBox();
            this.pbminim = new System.Windows.Forms.PictureBox();
            this.pbmaxim = new System.Windows.Forms.PictureBox();
            this.pbsalir = new System.Windows.Forms.PictureBox();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbrestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbminim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.lbtitulo);
            this.panel1.Controls.Add(this.pbrestore);
            this.panel1.Controls.Add(this.pbminim);
            this.panel1.Controls.Add(this.pbmaxim);
            this.panel1.Controls.Add(this.pbsalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 30);
            this.panel1.TabIndex = 5;
            // 
            // pbrestore
            // 
            this.pbrestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrestore.Image = ((System.Drawing.Image)(resources.GetObject("pbrestore.Image")));
            this.pbrestore.Location = new System.Drawing.Point(809, 7);
            this.pbrestore.Name = "pbrestore";
            this.pbrestore.Size = new System.Drawing.Size(20, 20);
            this.pbrestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbrestore.TabIndex = 8;
            this.pbrestore.TabStop = false;
            this.pbrestore.Visible = false;
            this.pbrestore.Click += new System.EventHandler(this.pbrestore_Click);
            // 
            // pbminim
            // 
            this.pbminim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbminim.Image = ((System.Drawing.Image)(resources.GetObject("pbminim.Image")));
            this.pbminim.Location = new System.Drawing.Point(783, 7);
            this.pbminim.Name = "pbminim";
            this.pbminim.Size = new System.Drawing.Size(20, 20);
            this.pbminim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbminim.TabIndex = 7;
            this.pbminim.TabStop = false;
            this.pbminim.Click += new System.EventHandler(this.pbminim_Click);
            // 
            // pbmaxim
            // 
            this.pbmaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbmaxim.Image = ((System.Drawing.Image)(resources.GetObject("pbmaxim.Image")));
            this.pbmaxim.Location = new System.Drawing.Point(809, 7);
            this.pbmaxim.Name = "pbmaxim";
            this.pbmaxim.Size = new System.Drawing.Size(20, 20);
            this.pbmaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmaxim.TabIndex = 6;
            this.pbmaxim.TabStop = false;
            this.pbmaxim.Click += new System.EventHandler(this.pbmaxim_Click);
            // 
            // pbsalir
            // 
            this.pbsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbsalir.Image = ((System.Drawing.Image)(resources.GetObject("pbsalir.Image")));
            this.pbsalir.Location = new System.Drawing.Point(835, 7);
            this.pbsalir.Name = "pbsalir";
            this.pbsalir.Size = new System.Drawing.Size(20, 20);
            this.pbsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalir.TabIndex = 5;
            this.pbsalir.TabStop = false;
            this.pbsalir.Click += new System.EventHandler(this.pbsalir_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(216)))));
            this.lbtitulo.Location = new System.Drawing.Point(367, 7);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(54, 19);
            this.lbtitulo.TabIndex = 9;
            this.lbtitulo.Text = "label1";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(867, 414);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbrestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbminim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbrestore;
        private System.Windows.Forms.PictureBox pbminim;
        private System.Windows.Forms.PictureBox pbmaxim;
        private System.Windows.Forms.PictureBox pbsalir;
        protected System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbtitulo;
    }
}