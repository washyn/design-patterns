using System;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hi!!!");
            
            Transaccion transaccion = new Transaccion(new AlgoritmoB());
            // Transaccion transaccion = new Transaccion(new AlgoritmoA());
            // la propiedad privada de transaccion Strategy puede ser publica para poder cambiarla en tienpo
            // de ejecucion

            Console.WriteLine(transaccion.ExetTransaction(45,5));
            
        }
        
    }



    class AlgoritmoA : IStrategy
    {
        public int RealizarOperacion(int n, int m)
        {
            // cuerpo del arlgoritmo complejo
            return n + m;
        }
    }

    class AlgoritmoB : IStrategy
    {
        public int RealizarOperacion(int n, int m)
        {
            // cuerpo del arlgoritmo complejo
            return n - m;
        }
    }

    interface IStrategy
    {
        int RealizarOperacion(int n,int m);
    }


    /// <summary>
    /// Contexto
    /// </summary>
    class Transaccion
    {
        private IStrategy _strategy;

        public Transaccion(IStrategy strategy)
        {
            _strategy = strategy;
        }

        
        /// <summary>
        /// Ejecuta el algoritmo
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int ExetTransaction(int i, int j)
        {
            return _strategy.RealizarOperacion(i, j);
        }
        
    }

}