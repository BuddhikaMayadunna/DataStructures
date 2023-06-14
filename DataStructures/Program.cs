// See https://aka.ms/new-console-template for more information
using DataStructures;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine($"_________________________________");
        Console.WriteLine($"Queues");
        Console.WriteLine($"_________________________________");

        Queues<int> queue = new Queues<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Display();
        Console.WriteLine($"Queue peek : {queue.Peek()}");
        Console.WriteLine($"Queue empty : {queue.IsEmpty()}");


        queue.Dequeue();

        queue.Display();
        Console.WriteLine($"Queue peek : {queue.Peek()}");
        Console.WriteLine($"Queue empty : {queue.IsEmpty()}");

        Console.WriteLine($"_________________________________");
        Console.WriteLine($"Stacks");
        Console.WriteLine($"_________________________________");
        Stacks<int> stack = new Stacks<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Top item : {stack.Top()}");
        foreach (var item in stack.ItemsStack.ToList())
        {
            Console.WriteLine($"Pop : {stack.Pop()}");
        }

        Console.ReadLine();
    }
}