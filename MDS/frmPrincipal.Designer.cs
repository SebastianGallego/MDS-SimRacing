namespace MDS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnABMPilotos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoTorneo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTorneosFinalizados = new System.Windows.Forms.Button();
            this.btnPuntajes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnABMPilotos
            // 
            this.btnABMPilotos.Location = new System.Drawing.Point(126, 390);
            this.btnABMPilotos.Name = "btnABMPilotos";
            this.btnABMPilotos.Size = new System.Drawing.Size(219, 44);
            this.btnABMPilotos.TabIndex = 3;
            this.btnABMPilotos.Text = "ABM Pilotos";
            this.btnABMPilotos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(126, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(219, 44);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoTorneo
            // 
            this.btnNuevoTorneo.Location = new System.Drawing.Point(126, 320);
            this.btnNuevoTorneo.Name = "btnNuevoTorneo";
            this.btnNuevoTorneo.Size = new System.Drawing.Size(219, 44);
            this.btnNuevoTorneo.TabIndex = 2;
            this.btnNuevoTorneo.Text = "Crear Nuevo Torneo";
            this.btnNuevoTorneo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Resultados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTorneosFinalizados
            // 
            this.btnTorneosFinalizados.Location = new System.Drawing.Point(126, 464);
            this.btnTorneosFinalizados.Name = "btnTorneosFinalizados";
            this.btnTorneosFinalizados.Size = new System.Drawing.Size(219, 44);
            this.btnTorneosFinalizados.TabIndex = 4;
            this.btnTorneosFinalizados.Text = "Torneos Finalizados";
            this.btnTorneosFinalizados.UseVisualStyleBackColor = true;
            // 
            // btnPuntajes
            // 
            this.btnPuntajes.Location = new System.Drawing.Point(126, 537);
            this.btnPuntajes.Name = "btnPuntajes";
            this.btnPuntajes.Size = new System.Drawing.Size(219, 44);
            this.btnPuntajes.TabIndex = 5;
            this.btnPuntajes.Text = "Puntajes";
            this.btnPuntajes.UseVisualStyleBackColor = true;
            this.btnPuntajes.Click += new System.EventHandler(this.btnPuntajes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 201);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 705);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPuntajes);
            this.Controls.Add(this.btnTorneosFinalizados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoTorneo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnABMPilotos);
            this.Name = "frmPrincipal";
            this.Text = "Torneos MDS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMPilotos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoTorneo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTorneosFinalizados;
        private System.Windows.Forms.Button btnPuntajes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

