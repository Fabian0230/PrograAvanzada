using System;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Acciones
{
    public class Sumar
    {
        public double CalculeLaSuma(double valor1, double valor2)
        {
            var laEspecificacion = new Especificaciones.RealiceLaSuma();
            double elResultado = laEspecificacion.Calcule(valor1, valor2);
            return elResultado;
        }
    }
}