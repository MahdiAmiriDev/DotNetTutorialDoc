namespace DesingPatternSamples.Behavioral.Memento
{
    public class Memento
    {
        //The following Variable is going to Hold the Internal State of the Originator object
        public LEDTV LedTV { get; set; }
        //Initializing the Internal State of Originator Object using Constructor
        public Memento(LEDTV ledTV)
        {
            LedTV = ledTV;
        }
        //This Method is going to return the Internal State of the Originator
        public string GetDetails()
        {
            return "Memento [LedTV=" + LedTV.GetDetails() + "]";
        }
    }
}
