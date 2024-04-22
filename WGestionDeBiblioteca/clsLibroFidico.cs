using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionDeBiblioteca
{
    internal class clsLibroFisico
    {

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public string Editorial { get; set; }
        public string Clasificacion { get; set; }
        public string Genero { get; set; }
        public int Valor { get; set; }
        public bool Estado { get; set; }

        public bool LibroFisico { get; set; }


        public clsLibroFisico(string titulo, string autor, int isbn, string editorial, string clasificacion, string genero, int valor, bool libroFisico)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Editorial = editorial;
            Clasificacion = clasificacion;
            Genero = genero;
            Valor = valor;
            Estado = false;
            LibroFisico = false;
        }

        public void LibroDisponible()
        {

            Estado = true;

        }

        public void LibroNoDisponible()
        {
            Estado = true;

        }

        public void LibroDisponibleFisico() 
        {

            LibroFisico = true;
        
        }


    }


}
