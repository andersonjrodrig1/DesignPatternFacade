using DesignPatternsFacade.Interfaces;
using DesignPatternsFacade.Services;

namespace DesignPatternsFacade
{
    public class RequestFacade
    {
        private readonly IFood _food;
        private readonly ISandwich _sandwich;
        private readonly IDrink _drink;

        public RequestFacade()
        {
            _food = new FoodService();
            _sandwich = new SandwichService();
            _drink = new DrinkService();
        }

        public void RequestBreakfast() => _food.RequestBreakfast();
        public void RequestLunch() => _food.RequestLunch();
        public void RequestDinner() => _food.RequestDinner();
        public void RequestHotDog() => _sandwich.RequestHotDog();
        public void RequestSandwich() => _sandwich.RequestSandwich();
        public void RequestWater() => _drink.RequestWater();
        public void RequestSoda() => _drink.RequestSoda();
        public void RequestJuice() => _drink.RequestJuice();
    }
}
