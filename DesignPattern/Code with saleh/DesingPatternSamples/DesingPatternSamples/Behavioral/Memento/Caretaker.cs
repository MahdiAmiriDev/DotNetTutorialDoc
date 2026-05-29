namespace DesingPatternSamples.Behavioral.Memento
{
    public class Caretaker
    {
        //This variable is going to hold the List of Mementos that are used by the Originator.
        private List<Memento> LedTvList = new List<Memento>();
        //This Method will add the memento i.e. the internal state of the Originator into the Caretaker i.e. Store Room 
        public void AddMemento(Memento m)
        {
            LedTvList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        //This Method is used to return one of the Previous Originator Internal States which saved in the Caretaker
        public Memento GetMemento(int index)
        {
            return LedTvList[index];
        }
    }
}
