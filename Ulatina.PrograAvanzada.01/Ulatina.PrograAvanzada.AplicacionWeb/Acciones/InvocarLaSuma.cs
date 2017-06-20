using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AplicacionWeb.Acciones
{
    public class InvocarLaSuma
    {
        public string CalcularSuma(string valor1, string valor2)
        {
            string elResultado;
            //parsear los elementos
            double val1 = Parsear(valor1);
            double val2 = Parsear(valor2);
            //instanciar el wcf
            var elCliente = new OperacionesMatematicas.Service1Client();
            //invocar el metodo del wc
            var elResultadoNumerico = elCliente.Sumar(val1,val2);
            //convertir el resultado a string
            elResultado = elResultadoNumerico.ToString();
            //retornar
            return elResultado;
        }

        private double Parsear(string elNumeroEnString)
        {
            double elResultado;
            double.TryParse(elNumeroEnString, out elResultado);
            return elResultado;
        }
    }
}