using System;

namespace Singleton
{
    
    /// <summary>
    /// Metodos y objetos
    /// Un metodo q se encarga de crear el objeto,
    ///     el cual asegura solo una instancia de otro objeto, puede ser el mismo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // error el objeto no es instanciable
            // var a = new DatabaseConexion();
            // var b = DatabaseConexion.CreateConexion();

            var f = DatabaseConexion.CreateConexion();
            var g = DatabaseConexion.CreateConexion();
            var h = DatabaseConexion.CreateConexion();


            Console.WriteLine(f.GetHashCode());
            Console.WriteLine(g.GetHashCode());
            Console.WriteLine(h.GetHashCode());
            
        }
    }



    class DatabaseConexion
    {
        private static DatabaseConexion _conexion;
        
        private DatabaseConexion()
        {
            
        }

        public static DatabaseConexion CreateConexion()
        {
            if (_conexion == null)
            {
                _conexion = new DatabaseConexion();
            }
            return _conexion;
        }
    }
    
}