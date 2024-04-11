using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com a classe Iphone
            Iphone iphone = new Iphone("123456789", "iPhone 12", "123456789012345", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            // Teste com a classe Nokia
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");

            Console.ReadLine();
        }
    }
}
