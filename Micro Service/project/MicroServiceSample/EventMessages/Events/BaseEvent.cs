using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMessages.Events
{
    public class BaseEvent
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow; 
        }
    }
}
