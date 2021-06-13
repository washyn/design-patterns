using System;
using System.Collections.Generic;

namespace Observer
{
    
    
    /// <summary>
    /// Uno a muchos, cuando un objeto cambio todos los demas se
    /// enteran de su cambio
    ///
    ///
    ///
    /// Al parecer hay una manera mejor de hacer esto
    /// IMPLEMENTAR DE OTRA MANERA
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Producto g = new Producto(5);
            
            Usuario a = new Usuario();
            Usuario b = new Usuario();
            Usuario c = new Usuario();
            
            // el equivalete a sucribe, cuando un objeto se suscribe al cambio
            // de otro
            g.AddObserver(a);
            g.AddObserver(b);
            
            g.Venta();
            





        }
    }



    /// <summary>
    /// Objeto q sera notificado
    ///
    /// Objeto observador
    /// 
    /// </summary>
    class Usuario : IObserver
    {
        public void Notification(string message)
        {
            Console.WriteLine(message);
        }
    }

    /// <summary>
    /// Objeto notificador
    ///
    /// objeto observado, objeto q modificara su estructura
    /// 
    /// </summary>
    class Producto : IObservable
    {
        private List<IObserver> _observers;
        
        public int Stock { get; set; }

        public Producto(int stock)
        {
            Stock = stock;
            _observers = new List<IObserver>();
        }
        
        public void Venta()
        {
            Stock -= 1;
            Console.WriteLine("Producto vendido");
            // notifi to all observers
            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Notification("El producto se vendio");
            }
        }

        public void RemoveObserver()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Metodo que deben implementar los objetos q quieran ser notificados
    ///
    /// Se implementa en los objetos que estan interesados en el cambio
    /// 
    /// </summary>
    interface IObserver
    {
        void Notification(string message);
    }


    interface IObservable
    {
        
        void AddObserver(IObserver observer);
        
        
        void NotifyObservers();
        
        // opctional
        void RemoveObserver();
    }
    
     
    
    
    
    
    
}