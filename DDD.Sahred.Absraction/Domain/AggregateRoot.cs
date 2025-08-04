using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Abstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get;protected set; }
        public int Version { get; protected set; }
        public bool _isIncremented { get; protected set; }
        public void IncrementedVersion()
        {
            if (_isIncremented) return;
            Version++;
            _isIncremented = true;
        }


        private List<IDomainEvent> _events = new List<IDomainEvent>();
        public IEnumerable<IDomainEvent> Events => _events;

        protected void RaiseDomainEvent(IDomainEvent @event)
        {
            if(_events.Any() && !_isIncremented)
            {
                Version++;
                _isIncremented = true;

            }
            _events.Add(@event);
        }
    }
}
