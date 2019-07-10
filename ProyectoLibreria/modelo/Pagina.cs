using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm.Models
{
    public class Pagina
    {
        public int Pag { set; get;}
        public string Url { set; get;}


        // generar el constructor automaticamente 
        // con quick action
        public Pagina(int pag, string url)
        {
            Pag = pag;
            Url = url;
        }

        public Pagina()
        {
        }
    }
}