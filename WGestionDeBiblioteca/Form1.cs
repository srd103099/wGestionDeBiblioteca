using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGestionDeBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Se agrega informacion al ComboBox para Libros Fisicos
            dgvTablaLibroFisico.Columns.Add("Título", "Título");
            dgvTablaLibroFisico.Columns[0].Width = 150;
            dgvTablaLibroFisico.Columns.Add("Autor", "Autor");
            dgvTablaLibroFisico.Columns[1].Width = 150;
            dgvTablaLibroFisico.Columns.Add("ISBN", "ISBN");
            dgvTablaLibroFisico.Columns[2].Width = 150;
            dgvTablaLibroFisico.Columns.Add("Editorial", "Editorial");
            dgvTablaLibroFisico.Columns[3].Width = 150;
            dgvTablaLibroFisico.Columns.Add("Clasificación", "Clasificación");
            dgvTablaLibroFisico.Columns[4].Width = 150;
            dgvTablaLibroFisico.Columns.Add("Valor", "Valor");
            dgvTablaLibroFisico.Columns[5].Width = 150;
            dgvTablaLibroFisico.Columns.Add("Estado", "Estado");
            dgvTablaLibroFisico.Columns[6].Width = 150;
            // Se agrega informacion al ComboBox para Libros Digitales
            dgvTablaLibroDigital.Columns.Add("Título", "Título");
            dgvTablaLibroDigital.Columns[0].Width = 150;
            dgvTablaLibroDigital.Columns.Add("Autor", "Autor");
            dgvTablaLibroDigital.Columns[1].Width = 150;
            dgvTablaLibroDigital.Columns.Add("ISBN", "ISBN");
            dgvTablaLibroDigital.Columns[2].Width = 150;
            dgvTablaLibroDigital.Columns.Add("Editorial", "Editorial");
            dgvTablaLibroDigital.Columns[3].Width = 150;
            dgvTablaLibroDigital.Columns.Add("Clasificación", "Clasificación");
            dgvTablaLibroDigital.Columns[4].Width = 150;
            dgvTablaLibroDigital.Columns.Add("Valor", "Valor");
            dgvTablaLibroDigital.Columns[5].Width = 150;
            dgvTablaLibroDigital.Columns.Add("Estado", "Estado");
            dgvTablaLibroDigital.Columns[6].Width = 150;
            dgvTablaLibroDigital.Columns.Add("No. Descargas", "No. Descargas");
            dgvTablaLibroDigital.Columns[7].Width = 150;
            dgvTablaLibroDigital.Columns.Add("Unidades Vendidas", "Unidades Vendidas");
            dgvTablaLibroDigital.Columns[8].Width = 100;

            #region [Combo Título libros físicos]
            cboTitulo.Items.Add("Cien años de soledad");
            cboTitulo.Items.Add("Billy Elliot");
            cboTitulo.Items.Add("Así habló Zaratustra");
            cboTitulo.Items.Add("Romeo y Julieta");
            #endregion

            #region [Combo Autor libros físicos]
            cboAutor.Items.Add("Gabriel García Márquez");
            cboAutor.Items.Add("Melvin Burgess");
            cboAutor.Items.Add("Friedrich Nietzsche");
            cboAutor.Items.Add("William Shakespeare");
            #endregion

            #region [Combo ISBN Libros fisicos]
            cboISBN.Items.Add("9788497592208 - Cien años de soledad");
            cboISBN.Items.Add("978-958-00-0027-3 - Billy Elliot");
            cboISBN.Items.Add("9788420650913 - Así habló Zaratustra");
            cboISBN.Items.Add("9788466751735 - Romeo y Julieta");
            #endregion

            #region [Editorial Libros Físicos]
            cboEditorial.Items.Add("DEBOLSILLO - Cien años de soledad");
            cboEditorial.Items.Add("EDICIONES SM - Billy Elliot");
            cboEditorial.Items.Add("ALIANZA - Así habló Zaratustra");
            cboEditorial.Items.Add("ANAYA - Romeo y Julieta");
            #endregion

            #region [Clasificación Libros Físicos]
            cboClasificacion.Items.Add("Realismo Mágico - Cien años de soledad");
            cboClasificacion.Items.Add("Musical - Billy Elliot");
            cboClasificacion.Items.Add("poesía y filosofía - Así habló Zaratustra");
            cboClasificacion.Items.Add("Tragedia - Romeo y Julieta");
            #endregion

            #region [Valor Libros Físicos]
            cboValor.Items.Add("124000");
            cboValor.Items.Add("57000");
            cboValor.Items.Add("155000");
            cboValor.Items.Add("29600");
            #endregion

            // Se agrega informacion al ComboBox de LibrosDigitales

            #region [Combo Título Libros Digitales]
            cboTitulo1.Items.Add("El principito");
            #endregion

            #region [Combo Autor Libros Digitales]
            cboAutor1.Items.Add("ANTOINE DE SAINT EXUPERY");
            #endregion

            #region [Combo ISBN Libros digitales]
            cboISBN1.Items.Add("9789584282460 - El principito");
            #endregion

            #region [Combo Editorial Libros Digitales]
            cboEditorial1.Items.Add("PLANETA JUNIOR - El principito");
            #endregion

            #region [Combo Clasificación Libros Digitales]
            cboClasificacion1.Items.Add("Infantil - El principito");
            #endregion

            #region [Combo Valor Libros Digitales]
            cboValor1.Items.Add("37.000 - El principito");
            #endregion

            #region [Combo Numero de descargas libros digitales]
            cboNumerosDescargas.Items.Add("500.000 - El principito");
            #endregion

            #region [Combo Libros Vendidos Digitales]
            cboLibrosVendidos.Items.Add("50.000 - El principito");
            #endregion

            #region [Combo Estado del Libro]
            cboEstado.Items.Add("Disponible");
            cboEstado.Items.Add("Agotado");
            #endregion

            
        }

        private Stream myStream;
        int counter = 0;
        string line;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvTablaLibroFisico.Rows.Clear();
        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
           

            if (!double.TryParse(cboValor.Text, out double valor))
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
                return;
            }

            clsLibroFisico InfolibroFisico = new clsLibroFisico(cboTitulo.Text, cboAutor.Text, cboISBN.Text, cboEditorial.Text, cboClasificacion.Text, valor, cboEstado.Text);
            // Agregar los datos del libro al DataGridView
            dgvTablaLibroFisico.Rows.Add(InfolibroFisico.TituloLibro, InfolibroFisico.AutorLibro, InfolibroFisico.ISBNLibro, InfolibroFisico.EditorialLibro, InfolibroFisico.ClasificacionLibro, Convert.ToInt32(InfolibroFisico.ValorLibro), InfolibroFisico.EstadoLibro);

        }
        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            dgvTablaLibroDigital.Rows.Clear();

        }
        private void btoIngresar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTitulo.Text) ||
               string.IsNullOrWhiteSpace(cboAutor.Text) ||
               string.IsNullOrWhiteSpace(cboISBN.Text) ||
               string.IsNullOrWhiteSpace(cboEditorial.Text) ||
               string.IsNullOrWhiteSpace(cboClasificacion.Text) ||
               string.IsNullOrWhiteSpace(cboValor.Text) ||
               string.IsNullOrWhiteSpace(cboLibrosVendidos.Text) ||
               string.IsNullOrWhiteSpace(cboNumerosDescargas.Text)
               )
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!double.TryParse(cboValor1.Text, out double valor1))
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
                return;
            }
            if (!int.TryParse(cboLibrosVendidos.Text, out int vendidos))
            {
                MessageBox.Show("Por favor, ingrese un número válido de libros vendidos.");
                return;
            }
            if (!int.TryParse(cboNumerosDescargas.Text, out int descargas))
            {
                MessageBox.Show("Por favor, ingrese un número válido de libros vendidos.");
                return;
            }

            string titulolibro = cboTitulo1.Text;
            string autorlibro = cboAutor1.Text;
            string isbnlibro = cboISBN1.Text;
            string editoriallibro = cboEditorial1.Text; 
            string clasificacionlibro = cboClasificacion.Text;
            double valorlibro = Convert.ToInt32(cboValor1.Text);
            string estadolibro = cboEstado1.Text;
            int numerosdescargas = Convert.ToInt32(cboNumerosDescargas.Text);
            int numerosvendidos = Convert.ToInt32(cboLibrosVendidos.Text);

            clsLibroDigital InfoLibroDigital = new clsLibroDigital(cboTitulo1.Text, cboAutor1.Text, cboISBN1.Text, cboEditorial1.Text, cboClasificacion1.Text, valor1, cboEstado1.Text, vendidos, descargas);            // Agregar los datos del libro al DataGridView
            dgvTablaLibroDigital.Rows.Add(InfoLibroDigital.TituloLibro, InfoLibroDigital.AutorLibro, InfoLibroDigital.ISBNLibro, InfoLibroDigital.EditorialLibro, InfoLibroDigital.ClasificacionLibro, InfoLibroDigital.ValorLibro, InfoLibroDigital.EstadoLibro, numerosdescargas,numerosvendidos );

        }

        private void btnCSV_Click_1(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Titulo";
            col0.Width = 200;
            col0.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Autor";
            col1.Width = 200;
            col1.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "ISBN";
            col2.Width = 200;
            col2.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Editorial";
            col3.Width = 200;
            col3.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Clasificacion";
            col4.Width = 200;
            col4.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Valor";
            col5.Width = 200;
            col5.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col5);
            
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Estado";
            col6.Width = 200;
            col6.ReadOnly = true;
            dgvTablaLibroFisico.Columns.Add(col6);

            char delimitador = ';';
            String[] valores;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.csv) | *.csv;";

                  

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {

                        using (myStream)
                        {

                            System.IO.StreamReader file = new StreamReader(openFileDialog.FileName);

                            while ((line = file.ReadLine()) != null)
                            {
                                if (counter >= 1)
                                {
                                    valores = line.Split(delimitador);
                                    dgvTablaLibroFisico.Rows.Add(valores.ToArray());
                                    counter++;
                                }
                                else
                                {

                                    counter++;

                                }
                            }
                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCSV1_Click(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Titulo";
            col0.Width = 200;
            col0.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Autor";
            col1.Width = 200;
            col1.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "ISBN";
            col2.Width = 200;
            col2.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Editorial";
            col3.Width = 200;
            col3.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Clasificacion";
            col4.Width = 200;
            col4.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Valor";
            col5.Width = 200;
            col5.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "No. de Descargas";
            col6.Width = 200;
            col6.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "No. Libros Vendidos";
            col7.Width = 200;
            col7.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col7);

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Estado";
            col8.Width = 200;
            col8.ReadOnly = true;
            dgvTablaLibroDigital.Columns.Add(col8);

            char delimitador = ';';
            String[] valores;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.csv) | *.cvs;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {

                        using (myStream)
                        {

                            System.IO.StreamReader file = new StreamReader(openFileDialog.FileName);

                            while ((line = file.ReadLine()) != null)
                            {
                                if (counter >= 1)
                                {
                                    valores = line.Split(delimitador);
                                    dgvTablaLibroDigital.Rows.Add(valores.ToArray());
                                    counter++;
                                }
                                else
                                {

                                    counter++;

                                }
                            }
                            file.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }
    }
    
}

