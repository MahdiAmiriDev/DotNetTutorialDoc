using AbstractFactory;


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


















//---------------------- Adapter ------------------------------------------------------------------------------------



//ترجمه می شود به چیزی که ما می خواهیم
IPaymentGateway GetGateway(string name)
{
    if (name == "tejarat")
        return new TejaratAdapter(new TejaratPayment());

    return new PasargardAdapter(new PasargardPayment());
}



var gateway = GetGateway("tejarat");

gateway.ProcessPayment(2323);



var pasargardGateway = GetGateway("pasargard");

pasargardGateway.ProcessPayment(6743);





















