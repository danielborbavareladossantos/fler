using System;
using Data;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando aplicação!");
            ProductDbContext context = new ProductDbContext();
        }
    }
}
