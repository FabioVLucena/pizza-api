using ContosoPizza.Models;

namespace ContosoPizza.Data;

public static class DbInitializer
{
    public static void Initialize(PizzaContext context)
    {
        if (context.Pizzas.Any())
        {
            return; //DB has been seeded
        }

        var pizzas = new Pizza[]
        {
            new Pizza
                {
                    Name = "Strognoff",
                    IsGlutenFree = false
                },
            new Pizza
                {
                    Name = "Champion",
                    IsGlutenFree = false
                },
            new Pizza
                {
                    Name = "Meat Strognoff",
                    IsGlutenFree = false
                }
        };

        context.Pizzas.AddRange(pizzas);
        context.SaveChanges();
    }
}
