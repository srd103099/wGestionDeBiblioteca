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
        }
        private Stream myStream;
        int counter = 0;
            string line;

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archovp (*.txt) | *,txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                btoIngresar.Text = btoIngresar.Text = line;
                                counter++;
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

        private void btoAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Titulo";
            col1.Width = 200;
            col1.ReadOnly = true;
            dgvTabla.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Autor";
            col2.Width = 200;
            col2.ReadOnly = true;
            dgvTabla.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "ISBN";
            col3.Width = 200;
            col3.ReadOnly = true;
            dgvTabla.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Editorial";
            col4.Width = 200;
            col4.ReadOnly = true;
            dgvTabla.Columns.Add(col4);
            
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Clasificacion";
            col5.Width = 200;
            col5.ReadOnly = true;
            dgvTabla.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Genero";
            col6.Width = 200;
            col6.ReadOnly = true;
            dgvTabla.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Valor";
            col7.Width = 200;
            col7.ReadOnly = true;
            dgvTabla.Columns.Add(col7);

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Estado";
            col8.Width = 200;
            col8.ReadOnly = true;
            dgvTabla.Columns.Add(col8);
            
            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.HeaderText = "Fisico / Digital";
            col9.Width = 200;
            col9.ReadOnly = true;
            dgvTabla.Columns.Add(col9);

            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            col10.HeaderText = "Libros Descargados";
            col10.Width = 200;
            col10.ReadOnly = true;
            dgvTabla.Columns.Add(col10);

            DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
            col11.HeaderText = "Libros Vendidos";
            col11.Width = 200;
            col11.ReadOnly = true;
            dgvTabla.Columns.Add(col11);

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
                                    dgvTabla.Rows.Add(valores.ToArray());
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

                clsLibroFisico InformacionLiboFisico = new clsLibroFisico(cboTitulo.Text, cboAutor.Text, (int.Parse(cboISBN.Text)), cboEditorial.Text, cboClasificacion.Text, cboGenero.Text, int.Parse(cboValor.Text));
                clsLibroDigital InformacionLibroDigital = new clsLibroDigital(cboTitulo.Text, cboAutor.Text, (int.Parse(cboISBN.Text)), cboEditorial.Text, cboClasificacion.Text, cboGenero.Text, int.Parse(cboValor.Text));
                if (rbtDisponible.Checked)
                {
                    InformacionLiboFisico.LibroDisponible();

                } 
                else if (rbtAgotado.Checked)
                {
                    InformacionLiboFisico.LibroNoDisponible();

                }
                
                

                

         


                
           

                
                
                

             
            }
        }
    }
}
