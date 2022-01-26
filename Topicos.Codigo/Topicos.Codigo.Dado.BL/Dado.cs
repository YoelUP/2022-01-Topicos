namespace Topicos.Codigo.Dado.BL
{
    /// <summary>
    /// Clase Business Logic de Dado
    /// </summary>
    public class Dado
    {
        const int _NoInicializado = -1;
        private int _valor;

        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Dado()
        {
            Valor = _NoInicializado;
        }

        public Dado(int valor)
        {
            Valor = valor;
        }

        /// <summary>
        /// Metodo Tirar sin Parametros
        /// </summary>
        public void Tirar()
        {
            var random = new Random();
            int elNumero = random.Next(1, 6);
            Valor = elNumero;
        }

        /// <summary>
        /// Metodo Tirar con Parametros
        /// </summary>
        public void Tirar(int cantidadVeces)
        {
            for (int i = 0; i < cantidadVeces; i++)
            {
                this.Tirar();
            }
        }
    }
}