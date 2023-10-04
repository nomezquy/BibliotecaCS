namespace Biblioteca.models
{  
    
    class Program
    {
        static void Main (string[] args)
        {
            Ejecucion programa = new Ejecucion();
        }
    }
    

    class Ejecucion
    {
        private Biblioteca biblioteca;

        public Ejecucion()
        {
            this.biblioteca = new Biblioteca();
            this.Menu();

        }

        private void Menu()
        {
            Console.WriteLine("Bienvenido a la biblioteca Dnomezquy");
            Console.WriteLine("");
            Console.WriteLine("Seleccione la opción:");
            Console.WriteLine("");
            Console.WriteLine("1. Agregar libro.");
            Console.WriteLine("2. Prestar un libro.");
            Console.WriteLine("3. Devolver un libro.");
            Console.WriteLine("4. Ver estado de un libro");
            Console.WriteLine("5. Ver lista de libros");
            Console.WriteLine("6 Salir del programa.");
            this.seleccionarOpcion();

        }

        private void seleccionarOpcion()
        {
            Console.WriteLine("Ingrese el número de la opción deseada:");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    this.AgregarEnBiblioteca();
                    break;

                case "2":
                    this.PrestarLibro();
                    break;

                case "3":
                    this.DevolverLibro();
                    break;

                case "4":
                    verEstado();
                    break; 
                
                case "5":
                    biblioteca.MostrarLibros();
                    Menu();
                    break;

                case "6":
                    CerrarApp();
                    break;




            }
        }

        private void AgregarEnBiblioteca()
        {
            Console.WriteLine("Ingresa el titulo del libro: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese el año de publicación: ");
            int año = int.Parse(Console.ReadLine());
             if (biblioteca.AgregarLibro(titulo, autor, año))
            {
                Console.WriteLine("Libro Agregado con exito.");
                Console.WriteLine("Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        private void PrestarLibro()
        {
            Console.WriteLine("Ingrese el ID del libro que desea prestar: ");
            int id = int.Parse(Console.ReadLine());
            if (biblioteca.PrestarLibro(id))
            {
                Console.WriteLine("libro Prestado con exito.");
                Console.WriteLine("Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        private void DevolverLibro()
        {
            Console.WriteLine("Ingrese el ID del libro que desea devolver: ");
            int id = int.Parse(Console.ReadLine());
            if (biblioteca.DevolverLibro(id))
            {
                Console.WriteLine("libro Devuelto con exito.");
                Console.WriteLine("Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        private void verEstado()
        {
            Console.WriteLine("Ingrese el ID del libro que desea ver el estado: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(biblioteca.MostrarEstadoLibro(id));
            Console.WriteLine("Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            Menu();


        }


        private void CerrarApp()
        {
            Console.WriteLine("Sistema cerrado con exito.");
            Console.Clear();
            Console.WriteLine("...Enter to Close");
            Console.ReadLine();
            
        }


    }



}




