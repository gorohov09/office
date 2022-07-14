using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Офис
{
    class Departament
    {
        public int number; // номер департамента
        public static int count_dep = 0; // количество департаментов

        public void add_departament(Departament[] departament)
        {
            Console.WriteLine("Введите номер департамента: ");
            departament[count_dep].number = int.Parse(Console.ReadLine());
            count_dep++;

        }
    }

    
}
