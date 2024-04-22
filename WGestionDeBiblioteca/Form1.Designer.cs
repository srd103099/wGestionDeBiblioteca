namespace WGestionDeBiblioteca
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboISBN = new System.Windows.Forms.ComboBox();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboValor = new System.Windows.Forms.ComboBox();
            this.rbtDisponible = new System.Windows.Forms.RadioButton();
            this.rbtAgotado = new System.Windows.Forms.RadioButton();
            this.rbtFisico = new System.Windows.Forms.RadioButton();
            this.rbtDigital = new System.Windows.Forms.RadioButton();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btoIngresar = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTitulo.Location = new System.Drawing.Point(171, 328);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(67, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblAutor.Location = new System.Drawing.Point(175, 378);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(65, 23);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblISBN.Location = new System.Drawing.Point(175, 427);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(63, 23);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblEditorial.Location = new System.Drawing.Point(148, 476);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(92, 23);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblClasificacion.Location = new System.Drawing.Point(112, 527);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(128, 23);
            this.lblClasificacion.TabIndex = 4;
            this.lblClasificacion.Text = "Clasificacion:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblEstado.Location = new System.Drawing.Point(59, 265);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(74, 23);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblValor.Location = new System.Drawing.Point(176, 588);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(62, 23);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // cboTitulo
            // 
            this.cboTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(244, 325);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(358, 30);
            this.cboTitulo.TabIndex = 7;
            // 
            // cboAutor
            // 
            this.cboAutor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(244, 371);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(358, 30);
            this.cboAutor.TabIndex = 8;
            // 
            // cboISBN
            // 
            this.cboISBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboISBN.FormattingEnabled = true;
            this.cboISBN.Location = new System.Drawing.Point(244, 420);
            this.cboISBN.Name = "cboISBN";
            this.cboISBN.Size = new System.Drawing.Size(358, 30);
            this.cboISBN.TabIndex = 9;
            // 
            // cboEditorial
            // 
            this.cboEditorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(244, 473);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(358, 30);
            this.cboEditorial.TabIndex = 10;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(244, 524);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(358, 30);
            this.cboClasificacion.TabIndex = 11;
            // 
            // cboValor
            // 
            this.cboValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Location = new System.Drawing.Point(244, 585);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(358, 30);
            this.cboValor.TabIndex = 13;
            // 
            // rbtDisponible
            // 
            this.rbtDisponible.AutoSize = true;
            this.rbtDisponible.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDisponible.Location = new System.Drawing.Point(141, 265);
            this.rbtDisponible.Name = "rbtDisponible";
            this.rbtDisponible.Size = new System.Drawing.Size(119, 26);
            this.rbtDisponible.TabIndex = 14;
            this.rbtDisponible.TabStop = true;
            this.rbtDisponible.Text = "Disponible";
            this.rbtDisponible.UseVisualStyleBackColor = true;
            // 
            // rbtAgotado
            // 
            this.rbtAgotado.AutoSize = true;
            this.rbtAgotado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAgotado.Location = new System.Drawing.Point(266, 265);
            this.rbtAgotado.Name = "rbtAgotado";
            this.rbtAgotado.Size = new System.Drawing.Size(98, 26);
            this.rbtAgotado.TabIndex = 15;
            this.rbtAgotado.TabStop = true;
            this.rbtAgotado.Text = "Agotado";
            this.rbtAgotado.UseVisualStyleBackColor = true;
            // 
            // rbtFisico
            // 
            this.rbtFisico.AutoSize = true;
            this.rbtFisico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFisico.Location = new System.Drawing.Point(506, 6);
            this.rbtFisico.Name = "rbtFisico";
            this.rbtFisico.Size = new System.Drawing.Size(81, 26);
            this.rbtFisico.TabIndex = 16;
            this.rbtFisico.TabStop = true;
            this.rbtFisico.Text = "Fisico";
            this.rbtFisico.UseVisualStyleBackColor = true;
            // 
            // rbtDigital
            // 
            this.rbtDigital.AutoSize = true;
            this.rbtDigital.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDigital.Location = new System.Drawing.Point(593, 6);
            this.rbtDigital.Name = "rbtDigital";
            this.rbtDigital.Size = new System.Drawing.Size(86, 26);
            this.rbtDigital.TabIndex = 17;
            this.rbtDigital.TabStop = true;
            this.rbtDigital.Text = "Digital";
            this.rbtDigital.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 703);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(1019, 238);
            this.dgvTabla.TabIndex = 18;
            // 
            // btoIngresar
            // 
            this.btoIngresar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoIngresar.Location = new System.Drawing.Point(244, 653);
            this.btoIngresar.Name = "btoIngresar";
            this.btoIngresar.Size = new System.Drawing.Size(120, 35);
            this.btoIngresar.TabIndex = 19;
            this.btoIngresar.Text = "Ingresar";
            this.btoIngresar.UseVisualStyleBackColor = true;
            this.btoIngresar.Click += new System.EventHandler(this.btoIngresar_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.Location = new System.Drawing.Point(388, 653);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(199, 35);
            this.btnCSV.TabIndex = 20;
            this.btnCSV.Text = "Agregar Archivo CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btoAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 953);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btoIngresar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.rbtDigital);
            this.Controls.Add(this.rbtFisico);
            this.Controls.Add(this.rbtAgotado);
            this.Controls.Add(this.rbtDisponible);
            this.Controls.Add(this.cboValor);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.cboISBN);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.cboTitulo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboISBN;
        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboValor;
        private System.Windows.Forms.RadioButton rbtDisponible;
        private System.Windows.Forms.RadioButton rbtAgotado;
        private System.Windows.Forms.RadioButton rbtFisico;
        private System.Windows.Forms.RadioButton rbtDigital;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btoIngresar;
        private System.Windows.Forms.Button btnCSV;
    }
}

