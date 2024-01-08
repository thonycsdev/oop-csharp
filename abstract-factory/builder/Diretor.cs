namespace Builder
{
    class Director
    {
        public static void Build(IDatabaseBuilder builder)
        {
            builder.BuildCommand();
            builder.BuildConnection();
            builder.SetSettings();
        }
    }
}