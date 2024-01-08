namespace Pizzaria
{
    interface IBaseBuilder
    {
        Pizza pizza { get; }
        IBaseBuilder ChangeDough(string dough);
        IBaseBuilder AddSauces(List<string> sauces);
        IBaseBuilder AddToppings(List<string> toppings);
        IBaseBuilder SetTimer(int ovenTime);


    }
}