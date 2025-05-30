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


var car1 = new BasicCar(200, "saipa shahin");

ShowCarInfo(car1);

var sportDecorator = new SportDecorator(car1);

var luxuryDecorator = new LuxuryDecorator(car1);

ShowCarInfo(car1);
ShowCarInfo(sportDecorator);
ShowCarInfo(luxuryDecorator);


void ShowCarInfo(ICar car1)
{
    Console.WriteLine($"my car name is {car1.GetDescription} and my car cost is {car1.GetCost()}");
}

