using System.Collections.Generic;

namespace Lab21.Controllers
{
    public static class CoffeeRepository
    {
        public static ICollection<string> GetInitialCoffees()
        {
            var coffees = new List<string>()
            {
                "Expresso",
                "Americano",
                "Macchiato",
                "Caffe Latte",
                "Cappuccino"
            };

            return coffees;
        }
    }
}
