using DesignPatternsFacade.Interfaces;
using System;

namespace DesignPatternsFacade.Services
{
    public class DrinkService : IDrink
    {
        public void RequestJuice()
        {
            Console.WriteLine("Obter um Suco!");
        }

        public void RequestSoda()
        {
            Console.WriteLine("Obter um Refrigerante!");
        }

        public void RequestWater()
        {
            Console.WriteLine("Obter uma Água!");
        }
    }
}
