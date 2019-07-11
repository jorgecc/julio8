using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm.Models
{
    public class Pagina
    {
        public string Pag { set; get;}
        public string Url { set; get;}


        // generar el constructor automaticamente 
        // con quick action
        public Pagina(string pag, string url)
        {
            Pag = pag;
            Url = url;
        }

        public Pagina()
        {
        }
    }
}