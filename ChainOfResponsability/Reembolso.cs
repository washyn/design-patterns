using System;

namespace ChainOfResponsability
{
    /// <summary>
    /// Elemento de cadena
    /// </summary>
    public class Reembolso : IManejadorTransaccion
    {
        private IManejadorTransaccion Next;
        
        /// <summary>
        /// metodo que se utilizara en la construccion de la cadena
        /// </summary>
        /// <param name="next"></param>
        public void SetNextManager(IManejadorTransaccion next)
        {
            Next = next;
        }

        /// <summary>
        /// Metodo por donde pasara cualquier objeto encadenable(Transaccion)
        /// El cual decidira si ejecutar el siguiente, terminar o realizar alguna modificacion
        /// en la secuencia de la cadena
        /// </summary>
        /// <param name="transaccion"></param>
        public void ExecTransaccion(Transaccion transaccion)
        {
            if (transaccion.Tipo == TipoTransaccion.Reembolso)
            {
                Console.WriteLine($"Nuevo valor reembolso {transaccion.Cantidad + transaccion.Balance}");
                // pero tambien se podria ejecutar el metodo(transaccion y hacer llamado al siguiente)
                // se puede modificar la transaccion
                // y pasarle la transaccion modificada al siguiente para q realize la ejecucion
                // y eventualmente uno de los metodos de ejecucion podria termiar realizando la 
                // ejecucion final
                // Next.ExecTransaccion(transaccion);
            }
            else
            {
                // no se ejecuta nada solo se llama al siguiente elemento en la cadena
                // para q pueda procesar la transaccion
                
                Next.ExecTransaccion(transaccion);
            }
        }
    }
}