using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int D;
        int a;
        int b;
        int c;

        Console.WriteLine("Моля въведете стойността на a:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Моля въведете стойността на b:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Моля въведете стойността на c:");
        c = Convert.ToInt32(Console.ReadLine());

        D = b * b - 4 * a * c;
        Console.WriteLine($"Дискриминантата е: {D} ");

        if (D > 0)
        {
            Console.WriteLine("Квадратното уравнение има 2 различни корена");
        }

        else if (D==0) 
        {
            Console.WriteLine("Квадратното уравнение има 2 едни и същи корена");
        }

        else if (D < 0) 
        {
            Console.WriteLine("Квадратното уравнение няма корени");
        }

    }
}