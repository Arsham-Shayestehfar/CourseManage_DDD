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
    }
}
