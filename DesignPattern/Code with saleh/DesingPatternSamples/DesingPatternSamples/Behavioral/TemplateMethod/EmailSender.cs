using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Behavioral.TemplateMethod
{
    public abstract class EmailSender
    {
        private readonly string _receipt;
        protected EmailSender(string receipt)
        {
            _receipt = receipt;
        }

        public void SendEmail(string to)
        {
            GetSubject();
            GetBody();
        }

        public abstract void GetSubject();

        public abstract void GetBody();
    }
}
