namespace RefactoringGuru
{
    enum DogSizesEnum
    {
        tiny,
        medium,
        large,
    }
}


namespace RefactoringGuru
{
    static class DogSizes
    {
        public static string toDescribeString(DogSizesEnum dogSizesEnum)
        {
            var dict = new Dictionary<DogSizesEnum, string>()
            {
                {DogSizesEnum.tiny, "Tiny"},
                {DogSizesEnum.medium, "Medium"},
                {DogSizesEnum.large, "Large"}
            };
            return dict[dogSizesEnum];
        }
    }
}