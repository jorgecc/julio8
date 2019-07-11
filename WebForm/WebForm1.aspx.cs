using ProyectoLibreria.dal;
using ProyectoLibreria.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.Models;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
             
                if (IsPostBack==false) { 
                string pagT = Request.QueryString["pag"];
                string filtroT = Request.QueryString["filtro"];

                if (pagT==null || pagT=="")
                {
                    // cuando se carga la pagina por primera vez
                    DropDownList1.DataSource = CoffeTypeDal.ListarTodo();
                    DropDownList1.DataBind();

                    GridView1.DataSource = CoffeeDal.ListarTodo(1);
                    GridView1.DataBind();

                    var paginas = PaginaServicio.CrearPagina(1
                            , CoffeeDal.NumPagina(0),0,"WebForm1.aspx");
                    Repeater1.DataSource = paginas;
                    Repeater1.DataBind();
                } 
                else
                {
                    // convertir la pagina y filtro en numero
                    int pag=Convert.ToInt32(pagT);
                    int filtro=Convert.ToInt32(filtroT);

                    // cargar el combobox
                    DropDownList1.DataSource = CoffeTypeDal.ListarTodo();
                    DropDownList1.DataBind();
                    
                    DropDownList1.SelectedValue=filtro.ToString(); // <-
                    
                    // cargar la grilla usando ese filtro
                    if (filtro==0) { 
                        GridView1.DataSource = CoffeeDal.ListarTodo(pag);
                    } else
                    {
                        GridView1.DataSource = CoffeeDal.ListarPorTipo(filtro, pag);
                    }
                    GridView1.DataBind();
                    // cargar la paginacion usando ese filtro
                    var paginas = PaginaServicio.CrearPagina(pag
                        , CoffeeDal.NumPagina(filtro), filtro, "WebForm1.aspx");
                  
                    Repeater1.DataSource = paginas;
                    Repeater1.DataBind();


                }
               
            } else
            {
                // cambio la seleccion

                // que quiero hacer? 
                // 1) Leer el tipo de cafe
                int tipoCafe=Convert.ToInt32(DropDownList1.SelectedItem.Value);
                // 2) Listar la grilla usando ese tipo de cafe
                GridView1.DataSource = CoffeeDal.ListarPorTipo(tipoCafe,1);
                GridView1.DataBind();
                // 3) Generar la paginacion usando ese tipo de cafe
                var paginas = PaginaServicio.CrearPagina(1
                    , CoffeeDal.NumPagina(tipoCafe), tipoCafe, "WebForm1.aspx");

                Repeater1.DataSource = paginas;
                Repeater1.DataBind();
            }
            } catch(Exception ex)
            {
                Panel1.Visible=true;
            }
        } // fin page_load
    }
}