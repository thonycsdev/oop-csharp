namespace RefactoringGuru
{
    class DogTina : IDogsCheck
    {
        private DogMixBreed nextCheck = new DogMixBreed();
        public string checkAnimalInfo(Dog dog)
        {
            if (dog._name == "Tina" && dog._breed == "shar pei" && dog._weight == 25)
            {
                return "This dog is named Tina, it's a shar pei, and it weighs 25 kilograms, so it's a medium dog.";
            }
            return nextCheck.checkAnimalInfo(dog);
        }
    }
}