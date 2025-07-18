using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.OrderAgg.Services
{
    /// <summary>
    /// برای
    /// entity
    /// ها
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now;
        }
    }

    public class BaseDomainEvent
    {
        public DateTime CreationDate { get; set; }

        public BaseDomainEvent()
        {
            CreationDate = new DateTime();
        }
    }

    /// <summary>
    /// برای aggregate root
    /// </summary>
    class AggregateRoot:BaseEntity
    {
        private readonly List<BaseDomainEvent> _BaseDomainEvents = new();

        public List<BaseDomainEvent> DomaintEvents => _BaseDomainEvents;

        public void Add(BaseDomainEvent e)
        {
            _BaseDomainEvents.Add(e);
        }

        public void Remove(BaseDomainEvent e)
        {
            _BaseDomainEvents?.Remove(e);
        }
    }
}
