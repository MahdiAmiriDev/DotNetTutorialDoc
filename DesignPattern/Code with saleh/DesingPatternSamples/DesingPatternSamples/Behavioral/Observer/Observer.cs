namespace DesingPatternSamples.Behavioral.Observer
{
    public class Observer : IObserver
    {
        //The following Property is going to hold the observer's name
        public string UserName { get; set; }
        //Creating the Observer
        public Observer(string userName)
        {
            UserName = userName;
        }
        //Registering the Observer with the Subject
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        //Removing the Observer from the Subject
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        //Observer will get a notification from the Subject using the following Method
        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
