using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.MatricesWCF.Dominio.Validaciones
{
    public class TamañoMatriz
    {
        public bool LaMatrizEsCuadra(double[,] laMatriz)
        {
            bool elResultado = false;
            var laCantidadDeColumnas = laMatriz.GetLength(1);
            var laCantidadDeFilas = laMatriz.GetLength(0);
            elResultado = (laCantidadDeColumnas==laCantidadDeFilas);
            return elResultado;
        }

        public bool LaMatricesSonIguales(double[,] laMatriz1, double[,] laMatriz2)
        {
            var laCantidadDeColumnasDeLaMatriz1 = laMatriz1.GetLength(1);
            var laCantidadDeFilasDeLaMatriz1 = laMatriz1.GetLength(0);
            var laCantidadDeColumnasDeLaMatriz2 = laMatriz2.GetLength(1);
            var laCantidadDeFilasDeLaMatriz2 = laMatriz2.GetLength(0);
            bool elResultado =(laCantidadDeColumnasDeLaMatriz1==laCantidadDeColumnasDeLaMatriz2
                &&laCantidadDeFilasDeLaMatriz1==laCantidadDeFilasDeLaMatriz2);
            if (elResultado)
            {
                for (int i = 0; elResultado && i < laCantidadDeColumnasDeLaMatriz2; i++)
                {
                    
                    for (int j = 0; elResultado && j < laCantidadDeFilasDeLaMatriz2; j++)
                    {
                        elResultado= laMatriz1[j, i]==laMatriz2[j,i];

                    }
                }
            }
            return elResultado;
        }
    }
}