using System;

namespace Decorator
{
    /// <summary>
    /// Al parecer se utiliza un compuesto(Composite)... para poder implementar
    ///
    /// Se hace un wraper
    /// 
    /// Objetos
    ///     Objeto decorador -> obtien el valor del objeto a decorar y le agrega mas funcionalidad
    ///     Objedo decorado
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // old
            // IPizza hawainaa = new PizzaHawaiana();
            IPizza hawainaa = new QuesoExtra(new PizzaHawaiana());
            Console.WriteLine(hawainaa.Description());
            Console.WriteLine(hawainaa.Price());
            
            
            
        }
    }



    class PizzaHawaiana : IPizza
    {
        public string Description()
        {
            return "Pizza hawainana";
        }

        public int Price()
        {
            return 8;
        }
    }
    

    interface IPizza
    {
        string Description();
        int Price();
    }

    class QuesoExtra: IPizza
    {
        private IPizza _pizza;

        public QuesoExtra(IPizza pizza)
        {
            _pizza = pizza;
        }
        
        public string Description()
        {
            return _pizza.Description() + "queso extra";
        }

        public int Price()
        {
            return _pizza.Price() + 4;
        }
    }
    
    
}