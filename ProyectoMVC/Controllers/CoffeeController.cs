using ProyectoLibreria.dal;
using ProyectoLibreria.db;
using ProyectoLibreria.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.Models;

namespace ProyectoMVC.Controllers
{
    public class CoffeeController : Controller
    {
        // /Coffee/Index/
        // /Coffee/

        public ActionResult Index()
        {
            int pagina=1;
            ViewBag.lista=CoffeeDal.ListarTodo(pagina);
            int totalPaginas=CoffeeDal.NumPagina(0);
            ViewBag.listapagina=PaginaServicio.CrearPagina(pagina, totalPaginas,0,""
                ,"/Coffee/Index/");

            Pagina tmp2=new Pagina(); // using WebForm.Models
            Coffee tmp=new Coffee();


            return View();
        }
    }
}