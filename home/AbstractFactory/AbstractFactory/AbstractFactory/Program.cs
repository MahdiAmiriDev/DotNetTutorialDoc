using AbstractFactory;
using System.Diagnostics.Contracts;


//--------------- Abstract Factory -----------

//IntroduceFactoryProducts(new AppleFactory());


//IntroduceFactoryProducts(new SamsungFactory());


//void IntroduceFactoryProducts(IFactory factory)
//{
//    var smartPhone = factory.GetSmartPhone();

//    Console.WriteLine(smartPhone.GetDetails());

//    var accessory = factory.GetAccessory();

//    Console.WriteLine(accessory.GetDetails());

//}







//------------ Factory Mehtod ------------------------------------------------------------------------------------------------


//WriteCarpetInformation(new TabrizCarpetFactory().CreateCarpet());


//void WriteCarpetInformation(ICarpet carpet)
//{
//    Console.WriteLine($"the sku is:{carpet.GetSku}");
//    Console.WriteLine($"the city is:{carpet.ManufacturerCity}");
//    Console.WriteLine($"the brand is:{carpet.GetBrand}");
//}











//------------ Prototype------------------------------------------------------------------------------------------------------------


//with clone

//var kordanGarden = new Prototype(new List<Flower>() { new Flower("abbasi") },"kordan garden");

//Console.WriteLine(kordanGarden.GardenName);

//var shahriarGarden =  (Prototype)kordanGarden.Clone();

//shahriarGarden.GardenName = "bagh amir arsalan";

//Console.WriteLine( shahriarGarden.GardenName);



////with ctor
//var tehranGarden = new Prototype(kordanGarden.Flowers,kordanGarden.GardenName);

//tehranGarden.Flowers[0].Name = "zanbagh";
//tehranGarden.GardenName = "tehran";

//Console.WriteLine(tehranGarden.Flowers[0].Name);
//Console.WriteLine(tehranGarden.GardenName);


//var xmlGarden =  tehranGarden.DeepCopyXml();

//if (xmlGarden != null)
//{

//    xmlGarden.Flowers.Add(new Flower("xml"));
//    xmlGarden.GardenName = "xml";
//    xmlGarden.Flowers[0].Name = "xml flower";
//    Console.WriteLine(xmlGarden.GardenName);
//    Console.WriteLine(xmlGarden.Flowers[0].Name);
//}

//Console.WriteLine(tehranGarden.Flowers[0].Name);
//Console.WriteLine(tehranGarden.GardenName);

//var jsonGarden = await xmlGarden.DeepCopyJsonAsync();

//if (jsonGarden != null)
//{

//    jsonGarden.Flowers.Add(new Flower("Json"));
//    jsonGarden.GardenName = "json";
//    jsonGarden.Flowers[0].Name = "json flower";
//    Console.WriteLine(jsonGarden.GardenName);
//    Console.WriteLine(jsonGarden.Flowers[0].Name);
//}

//Console.WriteLine(tehranGarden.Flowers[0].Name);
//Console.WriteLine(tehranGarden.GardenName);

//Console.WriteLine(xmlGarden.GardenName);
//Console.WriteLine(xmlGarden.Flowers[0].Name);

//Console.WriteLine(jsonGarden.GardenName);
//Console.WriteLine(jsonGarden.Flowers[0].Name);












//------------ Singleton ------------------------------------------------------------------------------------------------------------



//var mars = new Planet("mars", 5);
//var mericury = new Mars();
//var mericury2 = mericury.GetInstance();


//LoggerProvider.LogError("log error");

//LoggerProvider.LogInfo("log info");















//---------------------- Adapter ------------------------------------------------------------------------------------



//ترجمه می شود به چیزی که ما می خواهیم
//IPaymentGateway GetGateway(string name)
//{
//    if (name == "tejarat")
//        return new TejaratAdapter(new TejaratPayment());

//    return new PasargardAdapter(new PasargardPayment());
//}



//var gateway = GetGateway("tejarat");

//gateway.ProcessPayment(2323);



//var pasargardGateway = GetGateway("pasargard");

//pasargardGateway.ProcessPayment(6743);





//------------------------- Bridge --------------------------------------------




//var callOfDuty = new ShootingGame(GetPlatform(PlatformType.Pc));

//callOfDuty.Play();


//IPlatform GetPlatform(PlatformType platformType)
//{
//    switch (platformType)
//    {
//        case PlatformType.Pc:
//            return new PcPlatform();
//            break;
//        case PlatformType.Console:
//            return new ConsolePlatform();
//            break;
//        case PlatformType.Mobile:
//            return new MobilePlatform();
//            break;
//        default:
//            throw new ArgumentException("unknow paltform");
//    }

//}







//------------------------- Composite --------------------------------------------------------------------------------


////مدیرعامل
//var ceo = new Manager("karim", "ceo",100);

////head of markting
//var cmo = new Manager("ahmad", "head of markting", 100);

////head of tech
//var cto = new Manager("hamid", "head of tech", 100);

//var developer = new Developer("mahdi", "developer-1", 100);
//var developer2 = new Developer("bahram", "developer-2", 100);

//var contentWriter = new Developer("mahsa", "writer1", 100);
//var contentWriter2 = new Developer("masomeh", "writer2", 100);

//cto.AddEmployee(developer);
//cto.AddEmployee(developer2);

//cmo.AddEmployee(contentWriter);
//cmo.AddEmployee(contentWriter2);

//ceo.AddEmployee(cmo);
//ceo.AddEmployee(cto);

//ceo.Display();

//var totalSalaery = ManagerBuilder.GetInstance()
//    .AddManager(ceo)
//    .AddManager(cto)
//    .AddManager(cmo)
//    .AddTeamMember("head of tech", developer)
//    .AddTeamMember("head of tech", developer2)
//    .AddTeamMember("head of markting", contentWriter)
//    .AddTeamMember("head of markting", contentWriter2)
//    .GetTotalSalary();

//Console.WriteLine(totalSalaery);










//------------------------- Decorator --------------------------------------------------------------------------------


//var car1 = new BasicCar(200, "saipa shahin");

//ShowCarInfo(car1);

//var sportDecorator = new SportDecorator(car1);

//var luxuryDecorator = new LuxuryDecorator(car1);

//ShowCarInfo(car1);
//ShowCarInfo(sportDecorator);
//ShowCarInfo(luxuryDecorator);


//void ShowCarInfo(ICar car1)
//{
//    Console.WriteLine($"my car name is {car1.GetDescription()} and my car cost is {car1.GetCost()}");
//}



//Sample 2
//var request = new WebRequest("hello world", true);

//IBackendRequestHandler baseBackend = new BaseBackend();

//baseBackend = new LoggingRequestDecorator(baseBackend);

//baseBackend = new AuthRequestDecorator(baseBackend);

//baseBackend.Handle(request);




//------------------------- Decorator --------------------------------------------------------------------------------

//Order order = new()
//{
//    OrderId = "235",
//    IsValidated = false,
//    IsPaymentProcessed = false,
//    IsInStock = true,
//};

//OrderHandler validationHandler = new ValidationHandler();

//OrderHandler inventoryHandler = new InventoryHandler();

//OrderHandler paymentHandler = new PaymentHandler();

//validationHandler.SetNextHandler(inventoryHandler);
//inventoryHandler.SetNextHandler(paymentHandler);

//validationHandler.HandleOrder(order);
//validationHandler.HandleOrder(order);













//------------------------- Command --------------------------------------------------------------------------------

//var textEditor = new TextEditor();

//var commandManager = new CommandManager();

//commandManager.Execute(new AddTextCommand(textEditor,"welcome"));
////commandManager.Execute(new AddTextCommand(textEditor,"to this "));
////commandManager.Execute(new AddTextCommand(textEditor,"course "));
//commandManager.Execute(new AddTextCommand(textEditor,"thanks !"));
//commandManager.Execute(new RemoveTextCommand(textEditor,"thanks !"));

//textEditor.WriteText();



















//------------------------- Iterator --------------------------------------------------------------------------------




//var bookCollection = new BookCollection();

//bookCollection.AddBook(new Book("num-a", "author-a"));
//bookCollection.AddBook(new Book("num-b", "author-b"));

//var iterator = bookCollection.GetIterator();

//var book = iterator.Next();

//Console.WriteLine(book.Author + " has next {0}",iterator.HasNext());
// book = iterator.Next();
//Console.WriteLine(book.Author + " has next {0}",iterator.HasNext());


















//------------------------- Mediator --------------------------------------------------------------------------------



//var chatRoom = new ChatRoom();

//var user1 = new ChatRoomUser("user1");
//var user2 = new ChatRoomUser("user2");
//var user3 = new ChatRoomUser("user3");

//chatRoom.RegisterUser(user1);
//chatRoom.RegisterUser(user2);
//chatRoom.RegisterUser(user3);

//user1.SendMessage("hello this is user 1");

//Console.ReadKey();












//------------------------- Memento --------------------------------------------------------------------------------


//var bankAccountService = new BackAccountService();

//var state1 = bankAccountService.Deposit(200);
//Console.WriteLine(state1.Balance);
//var state2 = bankAccountService.Deposit(100);
//Console.WriteLine(state2.Balance);
//var state3 = bankAccountService.Deposit(50);
//Console.WriteLine(state3.Balance);

//bankAccountService.Restore(state2);

//Console.WriteLine(bankAccountService.GetBalance());

//Console.ReadKey();













//------------------------- Observer --------------------------------------------------------------------------------

//var weatherStation = new WeatherStation();

//var mobileScreen = new WeatherScreen("mobile app");

//var cityCenterScreen = new WeatherScreen("city center");

//weatherStation.RegisterObserver(mobileScreen);
//weatherStation.RegisterObserver(cityCenterScreen);

//await weatherStation.ProcessWeather(23);
//await Task.Delay(TimeSpan.FromSeconds(2));
//await weatherStation.ProcessWeather(33);









//------------------------- State --------------------------------------------------------------------------------

//var audioPlayer = new AudioPlayer(new PlayState());

//audioPlayer.Play();
//audioPlayer.Pause();
//audioPlayer.Stop();













//------------------------- Strategy --------------------------------------------------------------------------------





//var healthContext = new HealthContext();

//healthContext.SetStrategy(new MentalCare());
//healthContext.ExecuteStrategy();














//------------------------- TemplateMethod --------------------------------------------------------------------------------


//var document = new InvoiceProcessor();

//document.ProcessFile("D:/folder1/invoice.pdf");

//Console.WriteLine();

//var document2 = new PdfReportProcessor();

//document2.ProcessFile("D:/folder2/factor.pdf");

//Console.ReadKey();









//------------ Visitor ------------------------------------------------------------------------------------------------------------

var rectangle = new Rectangle() { Width = 12, Height = 8 };

var circle = new Circle() { Radius = 5 };

rectangle.AcceptVisitor(new AreaCalculator());

circle.AcceptVisitor(new AreaCalculator());

Console.ReadKey();
