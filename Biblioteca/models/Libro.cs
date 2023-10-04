using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.models
{
    internal class Libro
    {
        private int _Id;
        private string _Titulo = "";
        private string _Autor = "";
        private int _AñoPublicacion;
        private bool _Disponible;

        public int Id
        {
            get { return _Id; }
            set { if(value >= 0) _Id = value;}
        }
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value.Trim();}
        }

        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value.Trim(); }
        }

        public int AñoPublicacion
        {
            get { return _AñoPublicacion; }
            set
             {
                if (value >= 0) { _AñoPublicacion = value; }
                else { _AñoPublicacion = 0; }
             }
        }

        public bool Disponible
        {
            get { return _Disponible; }
            set { _Disponible = value; }
        }

        public Libro(int id, string titulo, string autor, int añoPublicacion, bool disponible) 
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Disponible = disponible;
        }

        public bool Prestar()
        {
            if (Disponible) 
            {
                Disponible = false;
                return true;
            }
            else { return false; }
            
        }

        public bool Devolver()
        {

            this.Disponible = true;
            if (Disponible) 
            {
                return true;
            }
            else return false;
        }

        public string GetInfoLibro()
        {
            return $" Id: {Id}, Titulo: {Titulo}, Autor: {Autor}, Año de publicación: {AñoPublicacion}";
        }

    }
}
