

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

//using DesingPatternSamples.Creational.Singleton;

//Singleton singleton = Singleton.GetInstance();

//singleton.Print("hello");

//var singleton2 = Singleton.GetInstance();

//singleton2.Print("every body");

//Console.ReadKey();






//------------------------------------------- Structural ------------------------------------------




//------------------------------------------- Adapter


//using DesingPatternSamples.Structural.Adapter;

//HekmatPaymentAdapter hekmatPaymentAdapter = new(new HekmatPayment());

//PaymentProcessor paymentProcessor = new(hekmatPaymentAdapter);

//paymentProcessor.Process(2343);

//Console.ReadKey();






//------------------------------------------- Bridge

//using DesingPatternSamples.Structural.Bridge;

//AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
//samsungRemoteControl.SwitchOn();
//samsungRemoteControl.SetChannel(202);
//samsungRemoteControl.SwitchOff();
//Console.ReadKey();




//------------------------------------------- Composite

//using DesingPatternSamples.Structural.Composite;
//using DesingPatternSamples.Structural.DataMapper;

//ProductCatalog productCatalog = new ProductCatalog();

//productCatalog.AddProduct(new Mobile());
//productCatalog.AddProduct(new LapTop());
//productCatalog.AddProduct(new Tv());

//productCatalog.PrintNames();
//productCatalog.PrintSumOfPrice();

//Console.ReadKey();






//------------------------------------------- Data Mapper



//using DesingPatternSamples.Structural.DataMapper;


//// Creating a Product instance
//Product product = new Product
//{
//    Id = 1,
//    Name = "Example Product",
//    Price = 29.99
//};

//// Using the mapper to convert Product to ProductDto
//ProductMapper mapper = new ProductMapper();
//ProductDto productDto = mapper.MapToDto(product);

//// Using the mapper to convert ProductDto to Product
//Product convertedProduct = mapper.MapToEntity(productDto);


//Console.WriteLine("{0} {1} {2}",convertedProduct.Name,convertedProduct.Id,convertedProduct.Price);

//Console.ReadKey();





//------------------------------------------- Decorator


//using DesingPatternSamples.Structural.Decorator;

//var simpleNotification = new SimpleNotification();

//Console.WriteLine(simpleNotification.Send());

//EmailNotificationDecorator emailNotificationDecorator = new(simpleNotification);

//Console.WriteLine(emailNotificationDecorator.Send());

//SmsNotificationDecorator smsNotificationDecorator = new(simpleNotification);

//Console.WriteLine(smsNotificationDecorator.Send());

//Console.ReadKey();




//------------------------------------------- Facade


//using DesingPatternSamples.Structural.Facade;

//var orderFacade = OrderFacade.GetInstance();

//if (orderFacade.PlaceOrder(12)) ;
//    Console.WriteLine("process order successfully... !");

//Console.ReadKey();



//------------------------------------------- Flyweight

//using DesingPatternSamples.Structural.Flyweight;

//var factory = new CharacterFactory();

//var player1 = new CharacterClient("player 1", factory, 184, 75, "black");

//player1.Render();

//var player2 = new CharacterClient("player 2", factory, 184, 75, "black");

//player2.Render();

//var player3 = new CharacterClient("player 3", factory, 190, 88, "blonde");


//player3.Render();

//Console.ReadKey();






//------------------------------------------- Proxy
//using DesingPatternSamples.Behavioral;
//using DesingPatternSamples.Structural.Proxy;

//var weatherProxy = new WeatherServiceProxy("hi","hello");

//weatherProxy.Request();

//Console.ReadKey();




//------------------------------------------- Chain of responsibility


//using DesingPatternSamples.Behavioral;

//ATM atm = new ATM();
//Console.WriteLine("Requested Amount 4600");
//atm.Withdraw(4600);
//Console.WriteLine("\nRequested Amount 1900");
//atm.Withdraw(1900);
//Console.WriteLine("\nRequested Amount 600");
//atm.Withdraw(600);
//Console.WriteLine("\nRequested Amount 750");
//atm.Withdraw(750);
//Console.Read();






//------------------------------------------- Command


//using DesingPatternSamples.Behavioral.Command;

////Create an Instance of Receiver
//Document document = new Document();

////Create the Command Object by passing the Receiver Instance
//ICommand openCommand = new OpenCommand(document);
//ICommand saveCommand = new SaveCommand(document);
//ICommand closeCommand = new CloseCommand(document);


////Create the Invoker instance by passing the command objects
//MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);

////Giving command to the Invoker to do the operation
//menu.ClickOpen();
//menu.ClickSave();
//menu.ClickClose();


//Console.ReadKey();




//------------------------------------------- Iterator


// Build a collection
//using DesingPatternSamples.Behavioral.Iterator;

//ConcreteCollection collection = new ConcreteCollection();
//collection.AddEmployee(new Employee("Anurag", 100));
//collection.AddEmployee(new Employee("Pranaya", 101));
//collection.AddEmployee(new Employee("Santosh", 102));
//collection.AddEmployee(new Employee("Priyanka", 103));
//collection.AddEmployee(new Employee("Abinash", 104));
//collection.AddEmployee(new Employee("Preety", 105));

//// Create iterator
//Iterator iterator = collection.CreateIterator();
////looping iterator      
//Console.WriteLine("Iterating over collection:");

//for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
//{
//    Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
//}
//Console.Read();









//------------------------------------------- Mediator


//using DesingPatternSamples.Behavioral.Mediator;
//using DesingPatternSamples.Behavioral.Memento;

//IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
////Create instances of Colleague i.e. Creating users
//User Ram = new ConcreteUser("Ram");
//User Dave = new ConcreteUser("Dave");
//User Smith = new ConcreteUser("Smith");
//User Rajesh = new ConcreteUser("Rajesh");
//User Sam = new ConcreteUser("Sam");
//User Pam = new ConcreteUser("Pam");
//User Anurag = new ConcreteUser("Anurag");
//User John = new ConcreteUser("John");

//facebookMediator.RegisterUser(Ram);
//facebookMediator.RegisterUser(Dave);
//facebookMediator.RegisterUser(Smith);
//facebookMediator.RegisterUser(Rajesh);
//facebookMediator.RegisterUser(Sam);
//facebookMediator.RegisterUser(Pam);
//facebookMediator.RegisterUser(Anurag);
//facebookMediator.RegisterUser(John);

////One of the users Sending one Message in the Facebook Group
//Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
//Console.WriteLine();
////Another user Sending another Message in the Facebook Group
//Rajesh.Send("What is Design Patterns? Please explain ");
//Console.Read();




//--------------------------- Memento





//Creating an Instance of the Originator and setting the current state as a 42-Inch Led TV
//using DesingPatternSamples.Behavioral.Memento;

//Originator originator = new Originator
//{
//    LedTV = new LEDTV("42-Inch", "60000", false)
//};
////Storing the Internal State (Memento i.e. the Current Led TV) of the Originator in the Caretaker i.e. Store Room
////First, Create an instance of the Caretaker
//Caretaker caretaker = new Caretaker();
////Second Create a snapshot or memento of the current internal state of the originator
//Memento memento = originator.CreateMemento();
////Third, store the memento or snapshot in the store room i.e. Caretaker
//caretaker.AddMemento(memento);
////Changing the Originator Current State to 46-Inch
//originator.LedTV = new LEDTV("46-Inch", "80000", true);
////Again storing the Internal State (Memento) of the Originator in the Caretaker i.e. Store Room
////Create the memento or snapshot of the current internal state of the originator
//memento = originator.CreateMemento();
////Store the memento in the Caretaker
//caretaker.AddMemento(memento);
////Again, Changing the Originator Current State to 50-Inch
//originator.LedTV = new LEDTV("50-Inch", "100000", true);
////The Current State of the Originator is now 50-Inch Led TV
//Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());
////Restoring the Originator to one of its previous states
////We have added two Memento to the Caretaker
////Index-0 means the First memento i.e. 42 Inch LED TV
////Index-1 means the Second memento i.e. 46 Inch LED TV
//Console.WriteLine("\nOriginator Restoring to 42-Inch LED TV");
//originator.SetMemento(caretaker.GetMemento(0));
//Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());
//Console.ReadKey();











//--------------------------- Observer


////Create a Product with Out of Stock Status
//using DesingPatternSamples.Behavioral.Observer;

//Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
////User Anurag will be created and the user1 object will be registered to the subject
//Observer user1 = new Observer("Anurag");
//user1.AddSubscriber(RedMI);
////User Pranaya will be created and the user1 object will be registered to the subject
//Observer user2 = new Observer("Pranaya");
//user2.AddSubscriber(RedMI);
////User Priyanka will be created and the user3 object will be registered to the subject
//Observer user3 = new Observer("Priyanka");
//user3.AddSubscriber(RedMI);
//Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
//Console.WriteLine();
//user3.RemoveSubscriber(RedMI);
//// Now the product is available
//RedMI.SetAvailability("Available");
//Console.Read();







//--------------------------------- State



//// Initially ATM Machine in DebitCardNotInsertedState
//using DesingPatternSamples.Behavioral.State;

//ATMMachine atmMachine = new ATMMachine();
//Console.WriteLine("ATM Machine Current state : "
//                + atmMachine.AtmMachineState.GetType().Name);
//Console.WriteLine();
//atmMachine.EnterPin();
//atmMachine.WithdrawMoney();
//atmMachine.EjectDebitCard();
//atmMachine.InsertDebitCard();
//Console.WriteLine();
//// Debit Card has been inserted so the internal state of the ATM Machine
//// has been changed to DebitCardInsertedState
//Console.WriteLine("ATM Machine Current state : "
//                + atmMachine.AtmMachineState.GetType().Name);
//Console.WriteLine();
//atmMachine.EnterPin();
//atmMachine.WithdrawMoney();
//atmMachine.InsertDebitCard();
//atmMachine.EjectDebitCard();
//Console.WriteLine("");
//// Debit Card has been ejected so the internal state of the ATM Machine
//// has been changed to DebitCardNotInsertedState
//Console.WriteLine("ATM Machine Current state : "
//                + atmMachine.AtmMachineState.GetType().Name);
//Console.Read();






//--------------------------------- Strategy

//using DesingPatternSamples.Behavioral.Strategy;

//var shoppingCard = new ShoppingCard();

//shoppingCard.AddItemToShoopingCard(23424);
//shoppingCard.AddItemToShoopingCard(10000);
//shoppingCard.AddItemToShoopingCard(23000);

//shoppingCard.SetDiscountStrategy(new SilverDiscount());

//var total = shoppingCard.CalculatePriceWithDiscount();

//Console.WriteLine(total);

//Console.ReadKey();









//--------------------------------- Template Method


//using DesingPatternSamples.Behavioral.TemplateMethod;
//using DesingPatternSamples.Behavioral.Visitor;

//var welcomeEmailSender = new WelcomeEmailSender("mehdi amiri");

//var updateEmailSender = new UpdateEmailSender("ali soly");

//welcomeEmailSender.SendEmail("abbase");

//updateEmailSender.SendEmail("jafar jackson");

//Console.ReadKey();







//----------------------------------- Visitor

//Create an instance of the object structure i.e. School class
using DesingPatternSamples.Behavioral.Visitor;

School school = new School();
//Create an Instance of the Visitor i.e. Doctor
var visitor1 = new Doctor("James");
//Call the PerformOperation Method by passing the Visitor Object which wants to Visit
//All elements of the ObjectStructure i.e. a collection
//Here, Doctor James will Visit all the Kids at the School
school.PerformOperation(visitor1);
Console.WriteLine();
//Create an Instance of another Visitor i.e. Salesman
var visitor2 = new Salesman("John");
//Call the PerformOperation Method by passing the Visitor Object which wants to Visit
//All elements of the ObjectStructure i.e. a collection
//Here, the Salesman John will Visit all the Kids of the School
school.PerformOperation(visitor2);
Console.Read();
