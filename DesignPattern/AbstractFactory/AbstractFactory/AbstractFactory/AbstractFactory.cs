namespace AbstractFactory
{

    public interface ISmartPhone
    {
        string GetDetails();
    }

    public interface IAccessory
    {
        string GetDetails();
    }

    public interface IFactory
    {
        ISmartPhone GetSmartPhone();

        IAccessory GetAccessory();
    }

    public class Galaxy:ISmartPhone
    {
        public string GetDetails()
        {
            return "I am samsung galaxy";
        }
    }

    public class IPhone:ISmartPhone
    {
        public string GetDetails()
        {
            return "I am apple iphone";
        }
    }

    public class Buds : IAccessory
    {
        public string GetDetails()
        {
            return "I am samsung Buds";
        }
    }

    public class Airpod : IAccessory
    {
        public string GetDetails()
        {
            return "I am apple Airpod";
        }
    }

    public class SamsungFactory:IFactory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new Galaxy();
        }

        public IAccessory GetAccessory()
        {
            return new Buds();
        }
    }

    public class AppleFactory : IFactory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new IPhone();
        }

        public IAccessory GetAccessory()
        {
            return new Airpod();
        }
    }
}
