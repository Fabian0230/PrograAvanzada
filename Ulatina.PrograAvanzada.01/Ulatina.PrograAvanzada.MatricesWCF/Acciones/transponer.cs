using System;

namespace Acciones
{
    internal class transponer
    {
        public transponer()
        {
        }

        internal double [,] CalcularTranspuesta(double[,] laMatriz)
        {
            var laEspecificacion= new Especificaciones.transpuesta();
            var elResultado = laEspecificacion.CalcularTranspuesta(laMatriz);
            return elResultado;
        }
    }
}