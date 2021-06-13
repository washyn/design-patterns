using System;

namespace Facade
{
    /// <summary>
    ///
    /// Partes
    /// 
    ///     Objetos o logiaca interna, compleja
    ///     Fachada, expone metodos de facil uso
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var facade = new Facade();
            facade.Endender();
            
            
        }
    }












    class Facade
    {
        private Computadora _computadora;

        public Facade()
        {
            var teclado = new Teclado();
            var mouse = new Mouse();
            _computadora = new Computadora(teclado, mouse);
        }
        
        // metodos q le interesan al cliente

        public void Endender()
        {
            Console.WriteLine("encendidoooo....");
            _computadora.Encender();
        }
        
        
    }

    class Computadora
    {
        public Computadora(Teclado teclado, Mouse mouse)
        {
            // throw new NotImplementedException();
        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo pc");
        }
    }

    class Mouse
    {
        
    }

    class Teclado
    {
        
    }
}