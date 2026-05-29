namespace DesingPatternSamples.Behavioral.Visitor
{
    public class School
    {
        private static readonly List<IElement> Elements = new List<IElement>();
        static School()
        {
            Elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }
        //The following Method Accepts the Concrete Visitor Object as a Parameter
        public void PerformOperation(IVisitor visitor)
        {
            // Loop Through Each Element of the Collection or Data Structure
            foreach (var kid in Elements)
            {
                //Calling Accept Method of the Element Object by passing the Visitor Object as an argument
                kid.Accept(visitor);
            }
        }
    }
}
