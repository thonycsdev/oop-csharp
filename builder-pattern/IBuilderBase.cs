
namespace Builder
{
    public interface IBuilderBase<T>
    {
        T Build();
        T GetValue();
    }

}
