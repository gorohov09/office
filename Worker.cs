using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Офис
{
    class Worker
    {
        protected int ID;
        public FIO fio;
        public string jobtitle;
        public Departament departament;
        public int age;
        public double salary;
        public static int count_worker;


        public void add_new()
        {
            Console.WriteLine("Введите фамилию"); 
        }


    }

    
    
}
