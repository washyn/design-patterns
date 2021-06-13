using System;

namespace ChainOfResponsability
{
    /// <summary>
    /// Elemento encadenable
    /// </summary>
    public class Retiro : IManejadorTransaccion
    {
        private IManejadorTransaccion Next;
        
        public void SetNextManager(IManejadorTransaccion next)
        {
            Next = next;
        }

        public void ExecTransaccion(Transaccion transaccion)
        {
            if (transaccion.Tipo == TipoTransaccion.Retirio)
            {
                Console.WriteLine($"Nuevo valor retiro {transaccion.Cantidad - transaccion.Balance}");
            }
            else
            {
                Next.ExecTransaccion(transaccion);
            }
        }
    }
}