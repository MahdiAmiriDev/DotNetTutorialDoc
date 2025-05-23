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


var kordanGarden = new Prototype("kordan garden");

Console.WriteLine(kordanGarden.GardenName);

var shahriarGarden =  (Prototype)kordanGarden.Clone();

shahriarGarden.GardenName = "bagh amir arsalan";

Console.WriteLine( shahriarGarden.GardenName);