namespace DesingPatternSamples.Behavioral.TemplateMethod
{
    public class UpdateEmailSender : EmailSender
    {
        public UpdateEmailSender(string recepit) : base(recepit)
        {

        }

        public override void GetBody()
        {
            Console.WriteLine("this is email update body:");
        }

        public override void GetSubject()
        {
            Console.WriteLine("this is email update subject:");
        }


    }
}
