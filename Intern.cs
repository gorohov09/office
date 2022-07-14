using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Офис
{
    class Intern : Worker
    {
        int internship; // кол-во месяцев для стажировки (по договору)
        public static int count_intern = 0;
        public Intern(Intern intern)
        {
            Random random = new Random();
            intern.ID = random.Next(1000, 6000);
            intern.jobtitle = "Интерн";
        }

        public void add_intern(Intern[] intern, Departament[] departament)
        {
            
            Console.WriteLine("Введите фамилию интерна: ");
            intern[count_intern].fio.surname = Console.ReadLine();
            Console.WriteLine("Введите имя интерна: ");
            intern[count_intern].fio.name = Console.ReadLine();
            Console.WriteLine("Введите отчество интерна: ");
            intern[count_intern].fio.patronymic = Console.ReadLine();

            Console.WriteLine("Введите номер департамента, в котором будет числиться интерн: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < departament.Length; i++)
            {
                if (num == departament[i].number)
                    intern[count_intern].departament.number = num ;
                else
                    Console.WriteLine("В базе нет департамента с таким номером!");
            }
            Console.WriteLine("Введите возраст интерна: ");
            intern[count_intern].age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите зарплату интерна: ");
            intern[count_intern].salary = double.Parse(Console.ReadLine());

            count_intern++; count_worker++;
        }




    }
}
