using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionDeBiblioteca
{
    internal class clsLibro
    {

        public string TituloLibro { get; set; }
        public string AutorLibro { get; set; }
        public string ISBNLibro { get; set; }
        public string EditorialLibro { get; set; }
        public string ClasificacionLibro { get; set; }
        public double ValorLibro { get; set; }
        public string EstadoLibro { get; set; }


        public clsLibro(string titulolibro, string autorlibro, string isbnlibro, string editoriallibro, string clasificacionlibro, double valorlibro, string estadolibro)
        {
            TituloLibro = titulolibro;
            AutorLibro = autorlibro;
            ISBNLibro = isbnlibro;
            EditorialLibro = editoriallibro;
            ClasificacionLibro = clasificacionlibro;
            ValorLibro = valorlibro;
            EstadoLibro = estadolibro;
            
        }

    }
}
