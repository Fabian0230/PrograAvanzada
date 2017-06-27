using System;

namespace Especificaciones
{
    internal class Simetrica
    {
        public Simetrica()
        {
        }

        internal bool CalcularSimetrica(double[,] laMatriz)
        {
            bool elResultado = false;
            //paso1:Determinar si la matriz es cuadrada 
            //acceder validacion
            var laValidacion = new Ulatina.PrograAvanzada.MatricesWCF.Dominio.Validaciones.TamañoMatriz();
            bool laMatrizEsCuadrada = laValidacion.LaMatrizEsCuadra(laMatriz);
            //paso2:Si es cuadrada ,calcular la transpuesta
            var laEspecificacionTranspuesta = new Especificaciones.transpuesta();
            double[,] laMatrizTranspuesta = laEspecificacionTranspuesta.CalcularTranspuesta(laMatriz);
            //paso3:Realizar la comparacion de matrices entre la original y la transpuesta
            elResultado = laValidacion.LaMatricesSonIguales(laMatriz, laMatrizTranspuesta);

            return elResultado;

        }
    }
}