using Abstract;
using Builder;
using Classes;
using RefactoringGuru;
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

var pizza = PizzaBuilder
.Configure()
.AddDough()
.AddSauce("Ketchup")
.AddTopping("Calabria")
.AddTopping("Queijo")
.Build();


Console.WriteLine(pizza.Describe());


var esfirra = EsfirraBuilder
.Configure()
.AddDough()
.AddSauce("Mostarda")
.AddSauce("Ketchup")
.AddSauce("Water")
.AddTopping("Carne Moida")
.Build()
.Describe();

Console.WriteLine(esfirra);




IDatabaseBuilder postgresSqlBuilder = new PostgresDatabaseBuilder();

Director.Build(postgresSqlBuilder);
Database pgsql = postgresSqlBuilder.Database;
pgsql.Connection.Open();
pgsql.Connection.Close();