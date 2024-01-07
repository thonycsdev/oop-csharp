namespace Builder
{
    interface IPizzaBuilder : IBuilderBase<Pizza>
    {
        PizzaBuilder AddDough();
        PizzaBuilder AddSauce(string sauceName);
        PizzaBuilder AddTopping(string toppingName);
    }

}
