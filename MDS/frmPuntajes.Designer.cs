namespace MDS
{
    partial class frmPuntajes
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
            this.dgvQ = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHeat = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQ
            // 
            this.dgvQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQ.Location = new System.Drawing.Point(72, 122);
            this.dgvQ.Name = "dgvQ";
            this.dgvQ.ReadOnly = true;
            this.dgvQ.RowHeadersVisible = false;
            this.dgvQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQ.Size = new System.Drawing.Size(213, 589);
            this.dgvQ.TabIndex = 0;
            this.dgvQ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQ_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje Clasificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puntaje Heat (Sprint):";
            // 
            // dgvHeat
            // 
            this.dgvHeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeat.Location = new System.Drawing.Point(359, 122);
            this.dgvHeat.Name = "dgvHeat";
            this.dgvHeat.RowHeadersVisible = false;
            this.dgvHeat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeat.Size = new System.Drawing.Size(213, 589);
            this.dgvHeat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puntaje Main (Principal):";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(642, 116);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(213, 595);
            this.dgvMain.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(669, 857);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 44);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.button1);
            this.gbModificar.Controls.Add(this.txtPuntos);
            this.gbModificar.Controls.Add(this.txtPosicion);
            this.gbModificar.Controls.Add(this.label5);
            this.gbModificar.Controls.Add(this.label4);
            this.gbModificar.Enabled = false;
            this.gbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificar.Location = new System.Drawing.Point(359, 745);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(213, 156);
            this.gbModificar.TabIndex = 7;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar valores:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(117, 67);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(86, 26);
            this.txtPuntos.TabIndex = 3;
            this.txtPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(11, 67);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(86, 26);
            this.txtPosicion.TabIndex = 2;
            this.txtPosicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Puntaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Posición:";
            // 
            // frmPuntajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 935);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQ);
            this.Name = "frmPuntajes";
            this.Text = "Puntajes";
            this.Load += new System.EventHandler(this.frmPuntajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}