using LinqTasks.Models;

namespace LinqTasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======= ZAD 1 =======");

        IEnumerable<Emp> result = Tasks.Task1();

        foreach (Emp emp in result)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 2 =======");

        IEnumerable<Emp> result2 = Tasks.Task2();

        foreach (Emp emp in result2)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 3 =======");

        int result3 = Tasks.Task3();

        Console.WriteLine(result3);

        Console.WriteLine("======= Zad 4 =======");

        IEnumerable<Emp> result4 = Tasks.Task4();

        foreach (Emp emp in result4)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 5 =======");

        IEnumerable<object> result5 = Tasks.Task5();

        foreach (var emp in result5)
        {
            Console.WriteLine(emp);
        }


        Console.WriteLine("======= Zad 6 =======");

        IEnumerable<object> result6 = Tasks.Task6();

        foreach (var emp in result6)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 7 =======");

        IEnumerable<object> result7 = Tasks.Task7();

        foreach (var emp in result7)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 8 =======");

        bool result8 = Tasks.Task8();

        Console.WriteLine(result8);

        Console.WriteLine("======= Zad 9 =======");

        Emp result9 = Tasks.Task9();

        Console.WriteLine(result9);

        Console.WriteLine("======= Zad 10 =======");

        IEnumerable<object> result10 = Tasks.Task10();

        foreach (var emp in result10)
        {
            Console.WriteLine(emp);
        }


        Console.WriteLine("======= Zad 11 =======");

        IEnumerable<object> result11 = Tasks.Task11();

        foreach (var emp in result11)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 12 =======");

        IEnumerable<object> result12 = Tasks.Task12();

        foreach (Emp emp in result12)
        {
            Console.WriteLine(emp);
        }

        Console.WriteLine("======= Zad 13 =======");

        int [] arr = {1,1,1,1,1,1,10,1,1,1,1};

        var result13 = Tasks.Task13(arr);

        Console.WriteLine(result13);

        Console.WriteLine("======= Zad 14 =======");

        IEnumerable<object> result14 = Tasks.Task14();

        foreach (var dept in result14)
        {
            Console.WriteLine(dept);
        }
    }
}