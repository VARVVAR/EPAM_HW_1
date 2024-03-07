using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select the number of notebooks: ");
            int NtBook = int.Parse(Console.ReadLine());

            Console.Write("Select value of the notebook: ");
            float ValueBook = float.Parse(Console.ReadLine());

            Console.Write("Select the number of pens: ");
            int Pen = int.Parse(Console.ReadLine());

            Console.Write("Select value of the pen: ");
            float ValuePen = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"quantity notebooks: {NtBook}\t Cost notebooks: {ValueBook * NtBook}$\nquantity pens: {Pen}\t Cost Pens: {ValuePen * Pen}$");
            //Console.WriteLine($"Total quantity of Product: {NtBook + Pen}");
            Console.WriteLine($"\nTotal amount: {ValueBook * NtBook + ValuePen * Pen}$");
            Console.Read();



        }
    }
}
