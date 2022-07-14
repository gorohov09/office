using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Офис
{
    class Employee : Worker
    {
        int treaty; // кол-во месяцев работы, прописанных в трудовом договоре
        public static int count_employee = 0;
        public Employee(Employee employee)
        {
            Random random = new Random();
            employee.ID = random.Next(1000, 6000);
            employee.jobtitle = "Сотрудник";
        }
    }
}
