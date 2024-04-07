using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LR_12_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводиться список студентів та їх оцінки. Вивести середній бал кожного студента та
            //кількість оцінок вище за середнє по всіх.
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
           var students = new List<Students>()
           {
            new Students("Іван", "Петров", 3, 4, 5, 3, 4),
            new Students("Марія", "Іванова", 4, 4, 4, 3, 5),
            new Students("Олександр", "Скрипаль", 4, 3, 5, 4, 3),
            new Students("Анна", "Коваль", 5, 5, 5, 5, 5),
            new Students("Петро", "Кравчук", 3, 3, 3, 3, 4)
        };
            foreach (var student in students)
            {
                double Average = student.Rating.Average();
                Console.WriteLine($"Студент: {student.Surname, 10} {student.Name,10}  Середній бал: {Average}");
                int AboveAverageCount = student.Rating.Count(r => r > Average);
                Console.WriteLine($"Кількість оцінок вище за середнє по всіх: {AboveAverageCount}");
            }
            Console.ReadLine();
            /*Результат в консолі
             *Студент:     Петров       Іван  Середній бал: 3,8
              Кількість оцінок вище за середнє по всіх: 3
              Студент:    Іванова      Марія  Середній бал: 4
              Кількість оцінок вище за середнє по всіх: 1
              Студент:   Скрипаль  Олександр  Середній бал: 3,8
              Кількість оцінок вище за середнє по всіх: 3
              Студент:     Коваль       Анна  Середній бал: 5
              Кількість оцінок вище за середнє по всіх: 0
              Студент:    Кравчук      Петро  Середній бал: 3,2
              Кількість оцінок вище за середнє по всіх: 1
            */

        }
    }
}
