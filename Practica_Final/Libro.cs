using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final
{
    public class Libro : Empresa
    {
        public string Autor { get; set; }
        public int Fecha_Publicacion { get; set; }
    }
}
