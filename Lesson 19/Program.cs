using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
            new Computer() {Code = 1,NameOfType = "Acer", TypeOfProcessor = "intel Core", ChactotaOfProcessor = "2.2 Ггц", VOfOperative = "16 ГБ", VOfHardDriver = "1 Тб", VOfVideoCard= "3 ГБ", Cost = 125000, Current=50},
            new Computer() {Code = 2,NameOfType = "Apple", TypeOfProcessor = "intel Celeron", ChactotaOfProcessor = "2.4 Ггц", VOfOperative = "8 ГБ", VOfHardDriver = "512 Мб", VOfVideoCard= "4 ГБ", Cost = 225000, Current=10},
            new Computer() {Code = 3,NameOfType = "Lenovo", TypeOfProcessor = "AMD A-6", ChactotaOfProcessor = "1.8 Ггц", VOfOperative = "8 ГБ", VOfHardDriver = "512 Мб", VOfVideoCard= "3 ГБ", Cost = 105000, Current=100},
            new Computer() {Code = 4,NameOfType = "Xiaomi", TypeOfProcessor = "intel Pentium 4", ChactotaOfProcessor = "2.2 Ггц", VOfOperative = "16 ГБ", VOfHardDriver = "1 Тб", VOfVideoCard= "5 ГБ", Cost = 165000, Current=25},
            new Computer() {Code = 5,NameOfType = "Asus", TypeOfProcessor = "intel Core", ChactotaOfProcessor = "2.4 Ггц", VOfOperative = "32 ГБ", VOfHardDriver = "512 Мб", VOfVideoCard= "4 ГБ", Cost = 265000, Current=19},
            new Computer() {Code = 6,NameOfType = "Toshiba", TypeOfProcessor = "intel Core", ChactotaOfProcessor = "2.6 Ггц", VOfOperative = "32 ГБ", VOfHardDriver = "1 Тб", VOfVideoCard= "4 ГБ", Cost = 145000, Current=1},
            };
            Console.WriteLine("Введите название процессора");//все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            string typeofprocessor = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.TypeOfProcessor == typeofprocessor).ToList();
            Print(computers1);
            Console.ReadKey();

            Console.WriteLine("Введите объем опретивной памяти");//все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            string vofoperative = Console.ReadLine();
            List<Computer> computers2 = computers.Where(x => x.VOfOperative == vofoperative).ToList();
            Print(computers2);

            Console.WriteLine("Список, отсортированный по увеличению стоимости");//вывести весь список, отсортированный по увеличению стоимости;
            List<Computer> computers3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computers3);

            Console.WriteLine("Группировка по типу процессора");//вывести весь список, сгруппированный по типу процессора
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.TypeOfProcessor);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Code} {c.NameOfType} {c.ChactotaOfProcessor} {c.VOfOperative} {c.VOfHardDriver} {c.VOfVideoCard} {c.Cost} {c.Current}");
                }
            }

            Computer computer5 = computers.OrderByDescending(x => x.Cost).FirstOrDefault();//найти самый дорогой компьютер;
            Console.WriteLine($"{computer5.Code} {computer5.NameOfType} {computer5.ChactotaOfProcessor} {computer5.VOfOperative} {computer5.VOfHardDriver} {computer5.VOfVideoCard} {computer5.Cost} {computer5.Current}");

            Computer computer6 = computers.OrderByDescending(x => x.Cost).LastOrDefault();//найти самый бюджетный компьютер;
            Console.WriteLine($"{computer6.Code} {computer6.NameOfType} {computer6.ChactotaOfProcessor} {computer6.VOfOperative} {computer6.VOfHardDriver} {computer6.VOfVideoCard} {computer6.Cost} {computer6.Current}");

            Console.WriteLine(computers.Any(x => x.Current > 30));//есть ли хотя бы один компьютер в количестве не менее 30 штук?

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Code} {c.NameOfType} {c.ChactotaOfProcessor} {c.VOfOperative} {c.VOfHardDriver} {c.VOfVideoCard} {c.Cost} {c.Current}");
            }
            Console.WriteLine();
            

        }
    }
}
