using System;

namespace ChainOfResponsability
{
    /// <summary>
    ///
    /// Escenarios de uso, midleware
    ///
    /// Permite encadenar clases para la ejecucion de metodos
    ///
    ///
    /// Requiere por lo menos tres clases, interfaces
    /// 
    /// - Uno que sera el objeto encadenable, elemento de la cadena
    /// - Otro que permitira encadenar objetos, se encargara de enlazar los elementos
    ///     Debe implementar 2 metodos
    ///         - Metodo 
    /// - Cualquier objeto encadenable, que se puede pasar por la cadema de ejecucion
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // elemento que pasara por la cadena
            Transaccion transaccion = new Transaccion(100,200,TipoTransaccion.Otro);
            
            
            // elementos de cadena
            IManejadorTransaccion deposito = new Deposito();
            IManejadorTransaccion retiro = new Retiro();
            IManejadorTransaccion reembolso = new Reembolso();
            IManejadorTransaccion otro = new Otro();
            
            // se crea la cadena
            deposito.SetNextManager(retiro);
            retiro.SetNextManager(reembolso);
            reembolso.SetNextManager(otro);
            
            
            // ejecucion de cadena
            deposito.ExecTransaccion(transaccion);
        }
    }



    public enum TipoTransaccion
    {
        Deposito,
        Retirio,
        Reembolso,
        Otro
    }

    public class Transaccion
    {
        public float Cantidad { get; set; }
        public float Balance { get; set; }
        public TipoTransaccion Tipo { get; set; }

        public Transaccion(float cantidad, float balance, TipoTransaccion tipo)
        {
            Cantidad = cantidad;
            Balance = balance;
            Tipo = tipo;
        }
        
    }


}