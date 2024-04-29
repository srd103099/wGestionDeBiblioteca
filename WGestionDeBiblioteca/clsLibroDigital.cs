using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionDeBiblioteca
{
    internal class clsLibroDigital : clsLibro
    {
        private int NumeroDescargas { get; set; }
        private int NumerosVendidos { get; set; }
        public clsLibroDigital(string titulolibro, string autorlibro, string isbnlibro, string editoriallibro, string clasificacionlibro, double valorlibro, string estadolibro, int numerosdescargas, int numerosvendidos)
            : base(titulolibro, autorlibro, isbnlibro, editoriallibro, clasificacionlibro, valorlibro, estadolibro)
               {
                    NumeroDescargas = numerosdescargas;
                    NumerosVendidos = numerosvendidos;
               }

        
    }
}
