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
            //1.Instanciar la clase del contexto
            using (EF_FundamentalsEntities1 DB = new EF_FundamentalsEntities1())
            {
                /*
                 * // Para insertar - add() un registro en la db                
                GENTE oGente = new GENTE(); // 1.1 Instancio un objeto de la clase gente
                oGente.NOMBRE = "Jhon"; // 1.2 Asigno para cada campo del registro en la tabla, el dato correspondiente
                oGente.EDAD = 38;
                oGente.ID_SEXO = 1;

                //1.3 Agrego los campos a la tabla de la db
                DB.GENTE.Add(oGente); // 1.3.1 De la instancia de la DB, para el campo Gente, agrege el objeto de la tabla llenado oGente
                DB.SaveChanges(); // 1.4 Guardo los cambios
                */

                /*
                // Para implementar un edit()
                GENTE oGente = DB.GENTE.Find(2); // 2.1 Instancio un objeto de la clase GENTE, al cual se le va a asignar el balor de la DB.GENTE y que sea el id encontrado, enviado como parametro
                oGente.EDAD = 26; // 2.2 Se le asigna el nuevo valor a la edad
                DB.Entry(oGente).State = System.Data.Entity.EntityState.Modified; // 2.3 Se le inica al EF que el objeto sufio cambios
                DB.SaveChanges(); // 2.3 Se guardan los cambios
                */

                // Para eliminar un registro
                GENTE oGente2 = DB.GENTE.Find(3); // 3.1 Instancio objeto, al cual se le va a asignar el registro de la tabla GENTE con id 3
                DB.GENTE.Remove(oGente2); // 3.2 Le indico al contexto que, elimine el registro con el objeto instanciado
                DB.SaveChanges(); // 3.3. Guardo los cambios

                //Para obtener los datos:
                var lst = DB.GENTE; // 3.1 Creo un objeto var al que se le asignan los valores de las tablas
                foreach (var oGente_ in lst) // 3.2. Hago un recorrido de los elementos recolectados en la variable
                {
                    Console.WriteLine(oGente_.NOMBRE + ", Edad: " + oGente_.EDAD + ", Sexo: " + oGente_.SEXO.NOMBRE); // 3.3. Muestro en pantalla el campo nombre para el objeto recorrido
                }
                Console.ReadKey();
            }
        }
    }
}
