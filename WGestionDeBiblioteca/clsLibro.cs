using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionDeBiblioteca
{
    internal class clsLibro
    {

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public string Editorial { get; set; }
        public string Clasificacion { get; set; }
        public int Valor { get; set; }
        public string Estado { get; set; }


        public clsLibro(string titulo, string autor, int isbn, string editorial, string clasificacion, int valor, string estado)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Editorial = editorial;
            Clasificacion = clasificacion;
            Valor = valor;
            Estado = estado;
            
        }
    }
}
