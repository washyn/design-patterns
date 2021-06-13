using System;

namespace ChainOfResponsability
{
    /// <summary>
    /// Elemento de cadena
    /// 
    /// </summary>
    public class Otro : IManejadorTransaccion
    {
        private IManejadorTransaccion Next;
        
        public void SetNextManager(IManejadorTransaccion next)
        {
            Next = next;
        }

        public void ExecTransaccion(Transaccion transaccion)
        {
            if (transaccion.Tipo == TipoTransaccion.Otro)
            {
                Console.WriteLine($"Nuevo valor otro {transaccion.Cantidad + transaccion.Balance}");
            }
            else
            {
                // Next.ExecTransaccion(transaccion);
                // Ultimo elemento de cadena
                Console.WriteLine("Ultimo elemento no se puede atender");
                
            }
        }
    }
}