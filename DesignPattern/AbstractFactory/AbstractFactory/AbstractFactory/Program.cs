using AbstractFactory;


IntroduceFactoryProducts(new AppleFactory());


IntroduceFactoryProducts(new SamsungFactory());


void IntroduceFactoryProducts(IFactory factory)
{
    var smartPhone = factory.GetSmartPhone();

    Console.WriteLine(smartPhone.GetDetails());

    var accessory = factory.GetAccessory();

    Console.WriteLine(accessory.GetDetails());
    
}