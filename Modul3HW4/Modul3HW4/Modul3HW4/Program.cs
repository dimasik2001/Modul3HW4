using System;

namespace Modul3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Task");
            var firstTask = new DelegateTask();
            firstTask.Run();
            var secondTask = new LINQTask();
            secondTask.Run();
        }
    }
}
