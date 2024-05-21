using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService
{
    static int nextId = 3;

    static List<Pizza> Pizzas { get; }

    static PizzaService()
    {
        Pizzas =
        [
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        ];
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static Pizza Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
        return pizza;
    }

    public static void Update(Pizza pizza)
    {
        int index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }   

    public static void Delete(int id) {
        var pizza = Get(id);
        if (pizza is null)
            return;

        Pizzas.Remove(pizza);
    }
}
