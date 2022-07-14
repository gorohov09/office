using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Офис
{
    class Program
    {
        static void Main(string[] args)
        {
            Intern[] arr_intern = new Intern[50];
            Departament[] arr_departament = new Departament[10];
            arr_intern[0].add_intern(arr_intern, arr_departament);
            Console.WriteLine(arr_intern[0].jobtitle); 
        }
    }
}
