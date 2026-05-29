using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Behavioral.TemplateMethod
{
    public class WelcomeEmailSender : EmailSender
    {
        public WelcomeEmailSender(string recepit) : base(recepit)
        {

        }
        public override void GetBody()
        {
            Console.WriteLine("this is email body:");
        }

        public override void GetSubject()
        {
            Console.WriteLine("this is email subject:");
        }


    }
}
