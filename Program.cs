using System;

namespace DesignPatternsFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new RequestFacade();

            Console.WriteLine("\n------- Pedidos de Bebida --------");
            facade.RequestWater();
            facade.RequestSoda();
            facade.RequestJuice();

            Console.WriteLine("\n------- Pedidos de Comida --------");
            facade.RequestBreakfast();
            facade.RequestLunch();
            facade.RequestDinner();

            Console.WriteLine("\n------- Pedidos de Lanche --------");
            facade.RequestHotDog();
            facade.RequestSandwich();
        }
    }
}
