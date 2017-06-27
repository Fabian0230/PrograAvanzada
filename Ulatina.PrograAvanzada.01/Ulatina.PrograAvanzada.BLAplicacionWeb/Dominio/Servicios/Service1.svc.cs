using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        //servicios, invocan una accion 
        public double Sumar(double valor1, double valor2)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.Sumar();
            elResultado = laAccion.CalculeLaSuma(valor1,valor2);
            return elResultado;
        }

        
    

    //public double Restar(double valor1, double valor2)
    //{
    //    //double elResultado;
    //    //var laAccion = new Dominio.Acciones.Restar();
    //    //elResultado = laAccion.ObtengaLaFecha();
    //    //return elResultado;
    //}

    //public double Multiplicar(double valor1, double valor2)
    //{
    //    double elResultado;
    //    var laAccion = new Dominio.Acciones.Multiplicar();
    //    elResultado = laAccion.ObtengaLaFecha();
    //    return elResultado;
    //}

    //public double Dividir(double valor1, double valor2)
    //{
    //    double elResultado;
    //    var laAccion = new Dominio.Acciones.Dividir();
    //    elResultado = laAccion.ObtengaLaFecha();
    //    return elResultado;
    //}







    public string WhatDayIsToday()
        {
            string elResultado;
            var laAccion = new Dominio.Acciones.ObtenerFechaActual();
            elResultado = laAccion.ObtengaLaFecha();
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
