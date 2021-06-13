using System;
using System.Runtime.InteropServices;

namespace ChainOfResponsability
{
    /// <summary>
    /// Elemento de cadena
    /// </summary>
    public class Deposito : IManejadorTransaccion
    {
        private IManejadorTransaccion Next;
        
        public void SetNextManager(IManejadorTransaccion next)
        {
            Next = next;
        }

        public void ExecTransaccion(Transaccion transaccion)
        {
            if (transaccion.Tipo == TipoTransaccion.Deposito)
            {
                Console.WriteLine($"Nuevo valor deposito {transaccion.Cantidad + transaccion.Balance}");
            }
            else
            {
                Next.ExecTransaccion(transaccion);
            }
        }
    }
}