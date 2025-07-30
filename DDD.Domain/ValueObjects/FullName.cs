using DDD.Domain.Exception.CourseManagementException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public record FullName
    {
        public string Value { get; }
        public FullName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new FullNameNullOrEmptyException();
            if (value.Length > 50)
                throw new InvalidFullNameLenghtException(50);

            Value = value;

        }

        public static implicit operator string(FullName full) => full.Value;
        public static implicit operator FullName(string full) => new (full);
    }
}
