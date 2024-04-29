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
            this.dgvTablaLibroFisico = new System.Windows.Forms.DataGridView();
            this.btoIngresar = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.dgvTablaLibroDigital = new System.Windows.Forms.DataGridView();
            this.btnCSV1 = new System.Windows.Forms.Button();
            this.btoIngresar1 = new System.Windows.Forms.Button();
            this.cboValor1 = new System.Windows.Forms.ComboBox();
            this.cboClasificacion1 = new System.Windows.Forms.ComboBox();
            this.cboEditorial1 = new System.Windows.Forms.ComboBox();
            this.cboISBN1 = new System.Windows.Forms.ComboBox();
            this.cboAutor1 = new System.Windows.Forms.ComboBox();
            this.cboTitulo1 = new System.Windows.Forms.ComboBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblEstado1 = new System.Windows.Forms.Label();
            this.lblClasificacion1 = new System.Windows.Forms.Label();
            this.lblEditorial1 = new System.Windows.Forms.Label();
            this.lblISBN1 = new System.Windows.Forms.Label();
            this.lblAutor1 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblLibroFisico = new System.Windows.Forms.Label();
            this.lblLibroDigital = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboEstado1 = new System.Windows.Forms.ComboBox();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboNumerosDescargas = new System.Windows.Forms.ComboBox();
            this.lblNumeroDescargas = new System.Windows.Forms.Label();
            this.cboLibrosVendidos = new System.Windows.Forms.ComboBox();
            this.lblLibrosVendidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLibroFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLibroDigital)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTitulo.Location = new System.Drawing.Point(962, 54);
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
            this.lblAutor.Location = new System.Drawing.Point(966, 90);
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
            this.lblISBN.Location = new System.Drawing.Point(966, 126);
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
            this.lblEditorial.Location = new System.Drawing.Point(1295, 54);
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
            this.lblClasificacion.Location = new System.Drawing.Point(1259, 90);
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
            this.lblEstado.Location = new System.Drawing.Point(1145, 207);
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
            this.lblValor.Location = new System.Drawing.Point(1325, 126);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(62, 23);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // cboTitulo
            // 
            this.cboTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(1035, 47);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(211, 30);
            this.cboTitulo.TabIndex = 7;
            // 
            // cboAutor
            // 
            this.cboAutor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(1035, 83);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(211, 30);
            this.cboAutor.TabIndex = 8;
            // 
            // cboISBN
            // 
            this.cboISBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboISBN.FormattingEnabled = true;
            this.cboISBN.Location = new System.Drawing.Point(1035, 119);
            this.cboISBN.Name = "cboISBN";
            this.cboISBN.Size = new System.Drawing.Size(211, 30);
            this.cboISBN.TabIndex = 9;
            // 
            // cboEditorial
            // 
            this.cboEditorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(1393, 47);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(211, 30);
            this.cboEditorial.TabIndex = 10;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(1393, 83);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(211, 30);
            this.cboClasificacion.TabIndex = 11;
            // 
            // cboValor
            // 
            this.cboValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Location = new System.Drawing.Point(1393, 119);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(211, 30);
            this.cboValor.TabIndex = 13;
            // 
            // dgvTablaLibroFisico
            // 
            this.dgvTablaLibroFisico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaLibroFisico.Location = new System.Drawing.Point(19, 50);
            this.dgvTablaLibroFisico.Name = "dgvTablaLibroFisico";
            this.dgvTablaLibroFisico.RowHeadersWidth = 51;
            this.dgvTablaLibroFisico.RowTemplate.Height = 24;
            this.dgvTablaLibroFisico.Size = new System.Drawing.Size(937, 238);
            this.dgvTablaLibroFisico.TabIndex = 18;
            // 
            // btoIngresar
            // 
            this.btoIngresar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoIngresar.Location = new System.Drawing.Point(1044, 253);
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
            this.btnCSV.Location = new System.Drawing.Point(1188, 253);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(199, 35);
            this.btnCSV.TabIndex = 20;
            this.btnCSV.Text = "Agregar Archivo CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click_1);
            // 
            // dgvTablaLibroDigital
            // 
            this.dgvTablaLibroDigital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaLibroDigital.Location = new System.Drawing.Point(19, 358);
            this.dgvTablaLibroDigital.Name = "dgvTablaLibroDigital";
            this.dgvTablaLibroDigital.RowHeadersWidth = 51;
            this.dgvTablaLibroDigital.RowTemplate.Height = 24;
            this.dgvTablaLibroDigital.Size = new System.Drawing.Size(937, 238);
            this.dgvTablaLibroDigital.TabIndex = 22;
            // 
            // btnCSV1
            // 
            this.btnCSV1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV1.Location = new System.Drawing.Point(1237, 559);
            this.btnCSV1.Name = "btnCSV1";
            this.btnCSV1.Size = new System.Drawing.Size(199, 35);
            this.btnCSV1.TabIndex = 39;
            this.btnCSV1.Text = "Agregar Archivo CSV";
            this.btnCSV1.UseVisualStyleBackColor = true;
            this.btnCSV1.Click += new System.EventHandler(this.btnCSV1_Click);
            // 
            // btoIngresar1
            // 
            this.btoIngresar1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoIngresar1.Location = new System.Drawing.Point(1093, 559);
            this.btoIngresar1.Name = "btoIngresar1";
            this.btoIngresar1.Size = new System.Drawing.Size(120, 35);
            this.btoIngresar1.TabIndex = 38;
            this.btoIngresar1.Text = "Ingresar";
            this.btoIngresar1.UseVisualStyleBackColor = true;
            this.btoIngresar1.Click += new System.EventHandler(this.btoIngresar1_Click);
            // 
            // cboValor1
            // 
            this.cboValor1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValor1.FormattingEnabled = true;
            this.cboValor1.Location = new System.Drawing.Point(1442, 425);
            this.cboValor1.Name = "cboValor1";
            this.cboValor1.Size = new System.Drawing.Size(211, 30);
            this.cboValor1.TabIndex = 35;
            // 
            // cboClasificacion1
            // 
            this.cboClasificacion1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasificacion1.FormattingEnabled = true;
            this.cboClasificacion1.Location = new System.Drawing.Point(1442, 389);
            this.cboClasificacion1.Name = "cboClasificacion1";
            this.cboClasificacion1.Size = new System.Drawing.Size(211, 30);
            this.cboClasificacion1.TabIndex = 34;
            // 
            // cboEditorial1
            // 
            this.cboEditorial1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEditorial1.FormattingEnabled = true;
            this.cboEditorial1.Location = new System.Drawing.Point(1442, 353);
            this.cboEditorial1.Name = "cboEditorial1";
            this.cboEditorial1.Size = new System.Drawing.Size(211, 30);
            this.cboEditorial1.TabIndex = 33;
            // 
            // cboISBN1
            // 
            this.cboISBN1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboISBN1.FormattingEnabled = true;
            this.cboISBN1.Location = new System.Drawing.Point(1084, 425);
            this.cboISBN1.Name = "cboISBN1";
            this.cboISBN1.Size = new System.Drawing.Size(211, 30);
            this.cboISBN1.TabIndex = 32;
            // 
            // cboAutor1
            // 
            this.cboAutor1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor1.FormattingEnabled = true;
            this.cboAutor1.Location = new System.Drawing.Point(1084, 389);
            this.cboAutor1.Name = "cboAutor1";
            this.cboAutor1.Size = new System.Drawing.Size(211, 30);
            this.cboAutor1.TabIndex = 31;
            // 
            // cboTitulo1
            // 
            this.cboTitulo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitulo1.FormattingEnabled = true;
            this.cboTitulo1.Location = new System.Drawing.Point(1084, 353);
            this.cboTitulo1.Name = "cboTitulo1";
            this.cboTitulo1.Size = new System.Drawing.Size(211, 30);
            this.cboTitulo1.TabIndex = 30;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblValor1.Location = new System.Drawing.Point(1374, 432);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(62, 23);
            this.lblValor1.TabIndex = 29;
            this.lblValor1.Text = "Valor:";
            // 
            // lblEstado1
            // 
            this.lblEstado1.AutoSize = true;
            this.lblEstado1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblEstado1.Location = new System.Drawing.Point(1194, 513);
            this.lblEstado1.Name = "lblEstado1";
            this.lblEstado1.Size = new System.Drawing.Size(74, 23);
            this.lblEstado1.TabIndex = 28;
            this.lblEstado1.Text = "Estado:";
            // 
            // lblClasificacion1
            // 
            this.lblClasificacion1.AutoSize = true;
            this.lblClasificacion1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblClasificacion1.Location = new System.Drawing.Point(1308, 396);
            this.lblClasificacion1.Name = "lblClasificacion1";
            this.lblClasificacion1.Size = new System.Drawing.Size(128, 23);
            this.lblClasificacion1.TabIndex = 27;
            this.lblClasificacion1.Text = "Clasificacion:";
            // 
            // lblEditorial1
            // 
            this.lblEditorial1.AutoSize = true;
            this.lblEditorial1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblEditorial1.Location = new System.Drawing.Point(1344, 360);
            this.lblEditorial1.Name = "lblEditorial1";
            this.lblEditorial1.Size = new System.Drawing.Size(92, 23);
            this.lblEditorial1.TabIndex = 26;
            this.lblEditorial1.Text = "Editorial:";
            // 
            // lblISBN1
            // 
            this.lblISBN1.AutoSize = true;
            this.lblISBN1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblISBN1.Location = new System.Drawing.Point(1015, 432);
            this.lblISBN1.Name = "lblISBN1";
            this.lblISBN1.Size = new System.Drawing.Size(63, 23);
            this.lblISBN1.TabIndex = 25;
            this.lblISBN1.Text = "ISBN:";
            // 
            // lblAutor1
            // 
            this.lblAutor1.AutoSize = true;
            this.lblAutor1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblAutor1.Location = new System.Drawing.Point(1015, 396);
            this.lblAutor1.Name = "lblAutor1";
            this.lblAutor1.Size = new System.Drawing.Size(65, 23);
            this.lblAutor1.TabIndex = 24;
            this.lblAutor1.Text = "Autor:";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTitulo1.Location = new System.Drawing.Point(1011, 360);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(67, 23);
            this.lblTitulo1.TabIndex = 23;
            this.lblTitulo1.Text = "Titulo:";
            // 
            // lblLibroFisico
            // 
            this.lblLibroFisico.AutoSize = true;
            this.lblLibroFisico.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroFisico.Location = new System.Drawing.Point(393, 9);
            this.lblLibroFisico.Name = "lblLibroFisico";
            this.lblLibroFisico.Size = new System.Drawing.Size(191, 37);
            this.lblLibroFisico.TabIndex = 42;
            this.lblLibroFisico.Text = "Libro Fisico";
            // 
            // lblLibroDigital
            // 
            this.lblLibroDigital.AutoSize = true;
            this.lblLibroDigital.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroDigital.Location = new System.Drawing.Point(393, 309);
            this.lblLibroDigital.Name = "lblLibroDigital";
            this.lblLibroDigital.Size = new System.Drawing.Size(201, 37);
            this.lblLibroDigital.TabIndex = 43;
            this.lblLibroDigital.Text = "Libro Digital";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(1225, 204);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(211, 30);
            this.cboEstado.TabIndex = 44;
            // 
            // cboEstado1
            // 
            this.cboEstado1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado1.FormattingEnabled = true;
            this.cboEstado1.Location = new System.Drawing.Point(1274, 506);
            this.cboEstado1.Name = "cboEstado1";
            this.cboEstado1.Size = new System.Drawing.Size(211, 30);
            this.cboEstado1.TabIndex = 45;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.Location = new System.Drawing.Point(1456, 559);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(106, 35);
            this.btnEliminar1.TabIndex = 40;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1407, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 35);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboNumerosDescargas
            // 
            this.cboNumerosDescargas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumerosDescargas.FormattingEnabled = true;
            this.cboNumerosDescargas.Location = new System.Drawing.Point(1084, 461);
            this.cboNumerosDescargas.Name = "cboNumerosDescargas";
            this.cboNumerosDescargas.Size = new System.Drawing.Size(211, 30);
            this.cboNumerosDescargas.TabIndex = 47;
            // 
            // lblNumeroDescargas
            // 
            this.lblNumeroDescargas.AutoSize = true;
            this.lblNumeroDescargas.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDescargas.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblNumeroDescargas.Location = new System.Drawing.Point(965, 468);
            this.lblNumeroDescargas.Name = "lblNumeroDescargas";
            this.lblNumeroDescargas.Size = new System.Drawing.Size(113, 23);
            this.lblNumeroDescargas.TabIndex = 46;
            this.lblNumeroDescargas.Text = "#Descargas:";
            // 
            // cboLibrosVendidos
            // 
            this.cboLibrosVendidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibrosVendidos.FormattingEnabled = true;
            this.cboLibrosVendidos.Location = new System.Drawing.Point(1442, 461);
            this.cboLibrosVendidos.Name = "cboLibrosVendidos";
            this.cboLibrosVendidos.Size = new System.Drawing.Size(211, 30);
            this.cboLibrosVendidos.TabIndex = 49;
            // 
            // lblLibrosVendidos
            // 
            this.lblLibrosVendidos.AutoSize = true;
            this.lblLibrosVendidos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosVendidos.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblLibrosVendidos.Location = new System.Drawing.Point(1334, 464);
            this.lblLibrosVendidos.Name = "lblLibrosVendidos";
            this.lblLibrosVendidos.Size = new System.Drawing.Size(102, 23);
            this.lblLibrosVendidos.TabIndex = 48;
            this.lblLibrosVendidos.Text = "#Vendidos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 608);
            this.Controls.Add(this.cboLibrosVendidos);
            this.Controls.Add(this.lblLibrosVendidos);
            this.Controls.Add(this.cboNumerosDescargas);
            this.Controls.Add(this.lblNumeroDescargas);
            this.Controls.Add(this.cboEstado1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblLibroDigital);
            this.Controls.Add(this.lblLibroFisico);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnCSV1);
            this.Controls.Add(this.btoIngresar1);
            this.Controls.Add(this.cboValor1);
            this.Controls.Add(this.cboClasificacion1);
            this.Controls.Add(this.cboEditorial1);
            this.Controls.Add(this.cboISBN1);
            this.Controls.Add(this.cboAutor1);
            this.Controls.Add(this.cboTitulo1);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblEstado1);
            this.Controls.Add(this.lblClasificacion1);
            this.Controls.Add(this.lblEditorial1);
            this.Controls.Add(this.lblISBN1);
            this.Controls.Add(this.lblAutor1);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.dgvTablaLibroDigital);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btoIngresar);
            this.Controls.Add(this.dgvTablaLibroFisico);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLibroFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLibroDigital)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTablaLibroFisico;
        private System.Windows.Forms.Button btoIngresar;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.DataGridView dgvTablaLibroDigital;
        private System.Windows.Forms.Button btnCSV1;
        private System.Windows.Forms.Button btoIngresar1;
        private System.Windows.Forms.ComboBox cboValor1;
        private System.Windows.Forms.ComboBox cboClasificacion1;
        private System.Windows.Forms.ComboBox cboEditorial1;
        private System.Windows.Forms.ComboBox cboISBN1;
        private System.Windows.Forms.ComboBox cboAutor1;
        private System.Windows.Forms.ComboBox cboTitulo1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblEstado1;
        private System.Windows.Forms.Label lblClasificacion1;
        private System.Windows.Forms.Label lblEditorial1;
        private System.Windows.Forms.Label lblISBN1;
        private System.Windows.Forms.Label lblAutor1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblLibroFisico;
        private System.Windows.Forms.Label lblLibroDigital;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboEstado1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboNumerosDescargas;
        private System.Windows.Forms.Label lblNumeroDescargas;
        private System.Windows.Forms.ComboBox cboLibrosVendidos;
        private System.Windows.Forms.Label lblLibrosVendidos;
    }
}

