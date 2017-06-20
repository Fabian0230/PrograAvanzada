using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Acciones
{
    public class ObtenerFechaActual
    {
        //Accion
        public string ObtengaLaFecha()
        {
            //Formas de declarar un objeto
            //Especificaciones.ObtengaFecha laEspecificacion = new Especificaciones.ObtengaFecha();
            var laEspecificacion = new Especificaciones.ObtengaLaFecha();//indica que va a recibir una variable del tipo clase
            string laFecha = laEspecificacion.FormatearUnaFecha(DateTime.Now, "dd/mm/yyyy");
            return laFecha;
        }
    }
}