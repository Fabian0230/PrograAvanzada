using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ulatina.PrograAvanzada.AplicacionWeb
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        

        protected void cldFechaEnviada_SelectionChanged(object sender, EventArgs e)
        {
            //lblFechaRecibida.Text = cldFechaEnviada.SelectedDate.ToString();
            //lblFechaRecibida.Text = cldFechaEnviada.SelectedDate.ToString("dd/mm/yyyy");
            lblFechaRecibida.Text = cldFechaEnviada.SelectedDate.ToShortDateString();
        }
    }
}