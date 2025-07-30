using DDD.Domain.Exception.CourseManagementException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public record Description
    {
        public string Value { get; }
        public Description(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new DescriptionNullOrEmptyException();
            if (value.Length > 500)
                throw new InvalidDescriptionLenghtException(500);

            Value = value;

        }

        public static implicit operator string(Description description) => description.Value;
        public static implicit operator Description(string value) => new Description(value);
    }
}
