using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionDeBiblioteca
{
    internal class clsLibroFisico : clsLibro
    {
        public clsLibroFisico(string titulolibro, string autorlibro, string isbnlibro, string editoriallibro, string clasificacionlibro, double valorlibro, string estadolibro)
            :base(titulolibro, autorlibro, isbnlibro, editoriallibro, clasificacionlibro, valorlibro, estadolibro)
        {
        }
    }
}
