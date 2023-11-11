namespace ProyectoSedima.PL
{
    partial class FrmBorrar_Modificar
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
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dtpFec = new System.Windows.Forms.DateTimePicker();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle});
            this.dgvReportes.Location = new System.Drawing.Point(61, 101);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.Size = new System.Drawing.Size(673, 309);
            this.dgvReportes.TabIndex = 0;
            this.dgvReportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportes_CellClick);
            this.dgvReportes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportes_CellDoubleClick);
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Image = global::ProyectoSedima.Properties.Resources.detalle;
            this.Detalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalle.Name = "Detalle";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(85, 53);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "STATUS";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(234, 53);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // dtpFec
            // 
            this.dtpFec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFec.Location = new System.Drawing.Point(369, 53);
            this.dtpFec.Name = "dtpFec";
            this.dtpFec.Size = new System.Drawing.Size(102, 20);
            this.dtpFec.TabIndex = 5;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(629, 45);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(87, 35);
            this.btnFiltro.TabIndex = 6;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FECHA INICIAL";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Detalle";
            this.dataGridViewImageColumn1.Image = global::ProyectoSedima.Properties.Resources.detalle;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FECHA FINAL";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(498, 53);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(102, 20);
            this.dtpFinal.TabIndex = 8;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(74, 74);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(142, 21);
            this.cbCliente.TabIndex = 10;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(222, 74);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 11;
            // 
            // FrmBorrar_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.dtpFec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dgvReportes);
            this.Name = "FrmBorrar_Modificar";
            this.Text = "Borrar/Modificar";
            this.Load += new System.EventHandler(this.FrmBorrar_Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dtpFec;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}