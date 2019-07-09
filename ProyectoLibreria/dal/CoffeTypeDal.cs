using ProyectoLibreria.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibreria.dal
{
    public class CoffeTypeDal
    {
        public static List<CoffeeType> ListarTodo()
        {
            using(var grupo=new Model1())
            {
                return grupo.CoffeeType
                    .OrderBy( ct => ct.Name)
                    .ToList();
            }
        }
    }
}
