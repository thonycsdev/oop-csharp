
using Pizzaria;


// var year = 2024;
// var month = 1;
// var day = 04;

// var internationalPizzaDay = new DateTime(year, month, day);

// Console.WriteLine(internationalPizzaDay.Year);
// Console.WriteLine(internationalPizzaDay.DayOfWeek);


// DateTime internationalPizzaDay2 = internationalPizzaDay.AddYears(-1);
// Console.WriteLine(internationalPizzaDay2.Year);

// Rectangle rectangle = new Rectangle(10, 10);
// var rectangleArea = rectangle.CalculateArea();
// Console.WriteLine(rectangleArea);
// rectangle.DummyMethod();

// var triangle = new Triangle(10, 5);
// Console.WriteLine(triangle.ToString());


// var booking = new HotelBooking("Anthony", DateTime.Now, 3);
// booking.PrintInformation();



// var dog = new Dog("Jhin", "Beagle", 20);

// dog.Describe();

// var pizza = PizzaBuilder
// .Configure()
// .AddDough()
// .AddSauce(sauceList[0])
// .AddTopping(toppingsList[0])
// .AddTopping(toppingsList[1])
// .Build();


// Console.WriteLine(pizza.Describe());


// var esfirra = EsfirraBuilder
// .Configure()
// .AddDough()
// .AddSauce(sauceList[1])
// .AddSauce(sauceList[0])
// .AddSauce(sauceList[2])
// .AddTopping(toppingsList[2])
// .Build()
// .Describe();

// Console.WriteLine(esfirra);




// IDatabaseBuilder postgresSqlBuilder = new PostgresDatabaseBuilder();

// Builder.Director.Build(postgresSqlBuilder);
// Database pgsql = postgresSqlBuilder.Database;
// pgsql.Connection.Open();
// pgsql.Connection.Close();




IBaseBuilder parmeBuilder = new ParmeBuilder();
IBaseBuilder dominosBuilder = new DominosBuilder();

var sauceList = new List<string>
{
    "Ketchup",
    "Mostarda",
    "Water"
};

var toppingsList = new List<string>
{
    "Calabria",
    "Queijo",
    "Carne Moida"
};

Director.BuildVanillaParme(parmeBuilder);

// parmeBuilder.AddSauces(sauceList);
// parmeBuilder.AddToppings(toppingsList);
// parmeBuilder.SetTimer(30);

Oven.Bake(parmeBuilder.pizza);
Oven.Bake(dominosBuilder.pizza);