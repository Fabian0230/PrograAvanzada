using System;

namespace Acciones
{
    internal class Simetrica
    {
        public Simetrica()
        {
        }

        internal bool CalcularSimetrica(double[,] laMatriz)
        {
            var laEspecificacion = new Especificaciones.Simetrica();
            bool elResultado = laEspecificacion.CalcularSimetrica(laMatriz);
            return elResultado;
        }
    }
}