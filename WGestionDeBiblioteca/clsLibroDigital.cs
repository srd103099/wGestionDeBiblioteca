using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionDeBiblioteca
{
    internal class clsLibroDigital : clsLibroFisico;
        public int NDescargas { get; set; }

        public int LibrosVendidos { get; set; }
        public bool LibroDigital { get; set; }
        public clsLibroDigital(int ndescargas, int librosvendidos)
        {

            NDescargas = ndescargas;
            LibrosVendidos = librosvendidos;
            LibroDigital = false;
        }

        //public void LibroDisponible()
        //{

        //    Estado = true;

        //}

        //public void LibroNoDisponible()
        //{
        //    Estado = false;

        //}

        //public void LibroDisponobleDigital()
        //{
        //    LibroDigital = true;
        //}


    }
}
