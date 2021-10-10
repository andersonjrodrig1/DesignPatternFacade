using DesignPatternsFacade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsFacade.Services
{
    public class SandwichService : ISandwich
    {
        public void RequestHotDog()
        {
            Console.WriteLine("Obter um Cachorro Quente!");
        }

        public void RequestSandwich()
        {
            Console.WriteLine("Obter um Sanduíche!");
        }
    }
}
