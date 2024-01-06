namespace RefactoringGuru
{
    class DogLucky : IDogsCheck
    {
        private IDogsCheck nextCheck = new DogTina();
        public string checkAnimalInfo(Dog dog)
        {
            if (dog._name == "Lucky" && dog._breed == "german shepherd" && dog._weight == 40)
            {
                return "This dog is named Lucky, it's a german shepherd, and it weighs 40 kilograms, so it's a large dog.";
            }
            return nextCheck.checkAnimalInfo(dog);
        }
    }
}