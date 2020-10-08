using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para obtener los datos:
            //1. Instanciar la clase del contexto
            using (EF_FundamentalsEntities1 DB = new EF_FundamentalsEntities1())
            {
                // 2. Creo un objeto var al que se le asignan los valores de las tablas
                var lst = DB.GENTE;
                foreach (var item in lst)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
        }
    }
}
