using System;
using System.Linq;

namespace Arquitetura.SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string NumeroTransacao = new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine("Hello World!: " + NumeroTransacao);
        }
    }
}
