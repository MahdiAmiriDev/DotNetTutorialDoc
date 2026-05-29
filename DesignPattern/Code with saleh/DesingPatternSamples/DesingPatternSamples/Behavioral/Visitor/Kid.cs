namespace DesingPatternSamples.Behavioral.Visitor
{
    public class Kid : IElement
    {
        //The following Property is going to hold the Kid Name
        public string KidName { get; set; }
        //Initializing the KidName Property using Class Constructor
        public Kid(string name)
        {
            KidName = name;
        }
        //The following Method will call the Concrete Visitor Visit method by passing the current Kid Object
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
