

//----------------------  Static factory sample

//using DesingPatternSamples.StaticFactory;

//var dataReader = DataProcessor.CreateDataReader("json");

//dataReader.ReadData("test.json");

//Console.ReadKey();





//--------------------------------------- Simple Factory sample



//using DesingPatternSamples.Creational.StaticFactory;

//SimpleFactoryDataProcessor simpleFactory = new();

//var tv = simpleFactory.CreateProduct("TV", "no desc", "Gplus", 1_000_004);
//var mobile = simpleFactory.CreateProduct("GalaxyS", "no desc", "Samsung", 1_234_004);


//Console.WriteLine("tv name is {0} and price is {1}", tv.GetName(), tv.GetPrice());

//Console.WriteLine("mobile name is {0} and price is {1}", mobile.GetName(), mobile.GetPrice());




//------------------------------------------- Factory Method

//using DesingPatternSamples.Creational.FactoryMethod;

//var creditCardFactory = new CreditCardFactory("58907528", "765", "12/12");

//var creditCardPayment = creditCardFactory.CreatePaymentMethod();

//creditCardPayment.ProcessPayment();

//Console.ReadKey();




//------------------------------------------- Abstract Factory

//using DesingPatternSamples.Creational.Abstract_Factory;

//var windowsUiFactory = new WindowsUiFactory();

//var button = windowsUiFactory.CreateButton();

//var checkBox = windowsUiFactory.CreateCheckBox();

//button.RenderButton();

//checkBox.RenderCheckBox();

//Console.ReadKey();



//------------------------------------------- Builder

//using DesingPatternSamples.Creational.Builder;

//var normalBuilding = new BuildingDirector(new NormalBuilding());

//var building = normalBuilding.GetBuilding();

//building.PrintReport();

//Console.ReadKey();




//------------------------------------------- Prototype

//using DesingPatternSamples.Creational.Prototype;

//PermanentEmployee pEmp = new()
//{
//    Department = "IT",
//    Name="preyanka chopra",
//    Type = "admin"
//};

//pEmp.ShowDetails();


//var emp2 = pEmp.GetClone();

//emp2.Name = "ayshovaria";
//emp2.Type = "admin";
//emp2.Department = "learning";

//emp2.ShowDetails();

//Console.ReadKey();



//------------------------------------------- Singleton

using DesingPatternSamples.Creational.Singleton;

Singleton singleton = Singleton.GetInstance();

singleton.Print("hello");

var singleton2 = Singleton.GetInstance();

singleton2.Print("every body");

Console.ReadKey();
