using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_KTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime currentDate = DateTime.Now; //отримує поточну дату та час
            Console.WriteLine("Поточна дата та час: " + currentDate);
            Console.Write("Введіть кількість годин, які потрібно додати: ");
            string inputHours = Console.ReadLine();
            int additionalHours = Convert.ToInt32(inputHours);
            DateTime futureDate = currentDate.AddHours(additionalHours);// Кількість годин додається до поточної дати
            Console.WriteLine("Дата і час через " + additionalHours + " годин(и): " + futureDate);
            Console.ReadLine();
        }
    }
}
