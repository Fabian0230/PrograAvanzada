using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.MatricesWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        //invoca un metodo de la accion
        public double [,] transpuesta(double[,] laMatriz)
        {
            var laAccion = new Acciones.transponer();
            var elResultado = laAccion.CalcularTranspuesta(laMatriz);
            return elResultado;
        }

        public bool Simetrica(double[,] laMatriz)
        {
            var laAccion = new Acciones.Simetrica();
            bool elResultado = laAccion.CalcularSimetrica(laMatriz);
            return elResultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
