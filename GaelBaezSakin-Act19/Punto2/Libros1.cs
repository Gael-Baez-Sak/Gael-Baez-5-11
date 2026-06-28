using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //En el primer archivo, declarar las propiedades Título, Autor y Páginas.Validar que la
    //cantidad de páginas sea mayor a 10.Valores cargados desde consola
    partial class Libros
    {
        private string titulo;
        private int paginas;
        private string autor;

        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }
        public int Paginas
        {
            set
            {
                if (value > 10)
                {
                    paginas = value;
                }
            }
            get
            {
                return paginas;
            }
        }
        public string Autor
        {
            set
            {
                autor = value;
            }
            get
            {
                return autor;
            }
        }
    }
}
