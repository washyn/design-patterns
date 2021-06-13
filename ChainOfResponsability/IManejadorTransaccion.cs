namespace ChainOfResponsability
{
    /// <summary>
    /// Encadenador
    /// </summary>
    public interface IManejadorTransaccion
    {
        void SetNextManager(IManejadorTransaccion next);
        /// <summary>
        /// Puede ser un ITransaccion
        /// </summary>
        /// <param name="next"></param>
        void ExecTransaccion(Transaccion transaccion);
    }
}