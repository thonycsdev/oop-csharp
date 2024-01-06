using System.Reflection;

namespace RefactoringGuru
{
    class Dog
    {
        public string _name { get; private set; }
        public string _breed { get; private set; }
        public int _weight { get; private set; }
        public readonly IDogsCheck _dogsCheck;

        public Dog(string name, int weight) : this(name, "mixed-breed", weight) { }
        public Dog(string name, string breed, int weight)
        {
            _breed = breed;
            _name = name;
            _weight = weight;
            _dogsCheck = new DogLucky();
        }


        public void Describe()
        {
            var result = _dogsCheck.checkAnimalInfo(this);
            Console.WriteLine(result);
        }

    }
}