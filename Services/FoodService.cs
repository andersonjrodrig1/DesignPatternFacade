using DesignPatternsFacade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsFacade.Services
{
    public class FoodService : IFood
    {
        public void RequestBreakfast()
        {
            Console.WriteLine("Obter Café da Manha!");
        }

        public void RequestDinner()
        {
            Console.WriteLine("Obter Jantar!");
        }

        public void RequestLunch()
        {
            Console.WriteLine("Obter Almoço!");
        }
    }
}
