namespace DesingPatternSamples.Behavioral.Visitor
{
    public class Doctor : IVisitor
    {
        //The following Property store the Name of the Doctor
        public string Name { get; set; }
        //Initializing the Name Property using Class Constructor
        public Doctor(string name)
        {
            Name = name;
        }
        //The Following is the Method we want to execute for each element of the collection or Data Structure
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Doctor: {Name} did the health checkup of the child: {kid.KidName}");
        }
    }
}
