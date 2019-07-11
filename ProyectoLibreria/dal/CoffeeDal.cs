using ProyectoLibreria.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibreria.dal
{
    public class CoffeeDal
    {
        const int TAMPAGINA=20;

        public static List<Coffee> ListarTodo(int pagina)
        {
            using(var grupo=new Model1() )
            {
                return grupo.Coffee
                    .Include("Brand") // esto son left join
                    .Include("CoffeeType") // esto son left join
                    .OrderBy( c => c.Title )
                    .Skip((pagina-1)*TAMPAGINA) // PAGINA 1 = (1-1)*20 = 0 
                    .Take(TAMPAGINA) 
                    .ToList(); // ef-> sql
            }
        }

        public static List<Coffee> ListarPorTipo(int tipo,string nombre,int pagina)
        {
            using (var grupo = new Model1())
            {
                return grupo.Coffee
                    .Include("Brand") // esto son left join
                    .Include("CoffeeType") // esto son left join
                    .Where( c =>c.TypeId==tipo )
                    .Where(c=>c.Title.Contains(nombre)) // title like '%nombre%'
                    .OrderBy(c => c.Title)
                    .Skip((pagina - 1) * TAMPAGINA) // PAGINA 1 = (1-1)*20 = 0 
                    .Take(TAMPAGINA)
                    .ToList();
            }
        }

        public static int NumPagina(int tipo)
        {
            using(var grupo=new Model1())
            {
                if (tipo==0) // si tipo es cero entonces no hay tipo seleccionado
                {
                    return (int)Math.Ceiling( (double)grupo.Coffee.Count() / TAMPAGINA );

                } else
                {
                    int num=grupo.Coffee
                        .Where(c => c.TypeId == tipo)
                        .Count();
                    return (int)Math.Ceiling((double)num/TAMPAGINA);
                }
            }
        } // fin NumPagina
    } // fin clase
}  // fin namespace
