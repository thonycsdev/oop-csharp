using Abstract;

namespace Builder
{
    interface IDatabaseBuilder
    {
        void BuildCommand();
        void BuildConnection();
        void SetSettings();
        Database Database { get; }
    }
}