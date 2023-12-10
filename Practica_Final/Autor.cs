using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final
{
    public class Autor
    {
        public string QueryMaxAutor(List<Libro> Datos_Libro)
        {




            var AutorCounting = Datos_Libro.GroupBy(c => c.Autor)
                                  .Select(grupo => new
                                  {
                                      todosAutores = grupo.Key,
                                      cant_Autores = grupo.Count()
                                  });

            var maximo = AutorCounting.Where(m => m.cant_Autores >= 1).Max(d => d.cant_Autores);

            return maximo.ToString();


        }
        public List<Seleccion> QueryListRazas(List<Libro> Datos_Libro)
        {
            List<Seleccion> valores = new List<Seleccion>();


            var AutoresCounting = Datos_Libro.GroupBy(c => c.Autor)
                                  .Select(grupo => new
                                  {
                                      todosAutores = grupo.Key,
                                      cant_Autores = grupo.Count()
                                  });


            foreach (var i in AutoresCounting)
            {
                valores.Add(new Seleccion
                {
                    Nombre = i.todosAutores,
                    Cantidad = i.cant_Autores,
                });

            }






            return valores;


        }
    }
}
