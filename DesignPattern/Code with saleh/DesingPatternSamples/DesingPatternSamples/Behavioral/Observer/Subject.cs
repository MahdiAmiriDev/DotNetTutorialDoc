namespace DesingPatternSamples.Behavioral.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }


        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            Availability = availability;
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                 + ProductName + ", product Price : "
                 + ProductPrice + " is Now available. So, notifying all Registered users ");
            Console.WriteLine();

            foreach (IObserver observer in _observers)
            {
                //By Calling the Update method, we are sending notifications to observers
                observer.Update(Availability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
            _observers.Remove(observer);
        }
    }
}
