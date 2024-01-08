using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pizzaria
{
    class Oven
    {
        public static void Bake(Pizza pizza)
        {
            var jsonString = JsonSerializer.Serialize(pizza);
            Console.WriteLine(jsonString);
            Console.WriteLine($"Baked in {pizza.TimeInTheOven} minutes");
        }
    }
}