using Builder;
using Factory;

interface IEsfirraBuilder : IBuilderBase<Esfirra>
{
    EsfirraBuilder AddDough();
    EsfirraBuilder AddSauce(string sauceName);
    EsfirraBuilder AddTopping(string toppingName);
}