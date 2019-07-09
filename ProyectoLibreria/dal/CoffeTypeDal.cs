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
                var types=grupo.CoffeeType
                    .OrderBy( ct => ct.Name)
                    .ToList();
                CoffeeType vacio =new CoffeeType();
                vacio.CoffeeTypeId=0;
                vacio.Name="--Seleccione un Tipo--";
                types.Insert(0,vacio); // inserto al comienzo
                return types;
            }
        }
    }
}
