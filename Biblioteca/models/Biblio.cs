using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.models
{
    internal class Biblioteca
    {
        private List<Libro> Libros;
        private int cantidadLibros = 0;

        public Biblioteca()
        {
            Libros = new List<Libro>();
        }

        public bool AgregarLibro(string titulo, string autor, int añoPublicacion)
        {
            if (titulo != "" & autor != "" & añoPublicacion != 0)
            {
                this.cantidadLibros++;
                Libro libro = new Libro(this.cantidadLibros, titulo, autor, añoPublicacion, true);
                Libros.Add(libro);
                return true;
            }
            else return false;                    
          
            
        }

        public bool PrestarLibro(int id)
        {
            int posLibro = Libros.FindIndex(Libro => Libro.Id == id);
            if (posLibro != -1)
            {
                if (Libros[posLibro].Prestar())
                {
                    return true;
                }
                else return false;
            }
            else return false;
            
        }


        public bool DevolverLibro(int id)
        {
            int posLibro = Libros.FindIndex(Libro => Libro.Id == id);
            if (posLibro != -1)
            {
                if (Libros[posLibro].Devolver())
                {
                    return true;
                }
                else return false;
            }
            else return false;

        }


        public string MostrarEstadoLibro(int id)
        {
            int posLibro = Libros.FindIndex(Libro => Libro.Id == id);
            if (posLibro != -1)
            {
                if (Libros[posLibro].Disponible)
                {
                    return "Disponible.";
                }
                else
                    return "No disponible.";
            }
            else return "No se encontró el libro indicado.";

        }        

        public void MostrarLibros()
        {
            foreach (Libro libro in Libros)
            {
                Console.WriteLine(libro.GetInfoLibro());
            }
        }

    }
}
