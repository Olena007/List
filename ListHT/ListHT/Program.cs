using System;

namespace ListHT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.Start start = new Service.Start();
            start.Run();
        }
    }
}
