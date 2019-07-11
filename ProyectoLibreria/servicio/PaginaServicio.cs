using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForm.Models;

namespace ProyectoLibreria.servicio
{
    public class PaginaServicio
    {
        public static List<Pagina> CrearPagina(int pagActual,int maxPagina
                ,int filtro,string pagina)
        {
            int paginaInicial=pagActual-3;
            int paginaFinal=pagActual+3;
            if (paginaInicial<=0)
            {
                paginaInicial=1;
            }
            if (paginaFinal>maxPagina)
            {
                paginaFinal=maxPagina;
            }

            var r=new List<Pagina>();
            for(int i= paginaInicial; i<= paginaFinal; i++)
            {
                r.Add(new Pagina(i,pagina+"?pag="+i+"&filtro="+filtro));
            }

            return r;
        }
    }
}
