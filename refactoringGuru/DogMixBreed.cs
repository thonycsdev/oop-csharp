namespace RefactoringGuru
{
    class DogMixBreed : IDogsCheck
    {
        public string checkAnimalInfo(Dog dog)
        {
            if (dog._weight < 5)
            {
                return $"This dog is named {dog._name}, it's a {dog._breed}, and it weighs {dog._weight} kilograms, so it's a {DogSizes.toDescribeString(DogSizesEnum.tiny)} dog.";
            }

            if (dog._weight >= 5 && dog._weight <= 30)
            {
                return $"This dog is named {dog._name}, it's a {dog._breed}, and it weighs {dog._weight} kilograms, so it's a {DogSizes.toDescribeString(DogSizesEnum.medium)} dog.";
            }

            if (dog._weight > 30)
            {
                return $"This dog is named {dog._name}, it's a {dog._breed}, and it weighs {dog._weight} kilograms, so it's a {DogSizes.toDescribeString(DogSizesEnum.large)} dog.";
            }
            return "";
        }
    }
}