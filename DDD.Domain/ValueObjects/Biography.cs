using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain.Exception.CourseManagementException;

namespace DDD.Domain.ValueObjects
{
    public record Biography
    {
        public string Value { get; }
        public Biography(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new BiographyNullOrEmptyException();
            if (value.Length > 500)
                throw new InvalidBiographyLenghtException();

            Value = value;

        }

        public static implicit operator string(Biography biography) => biography.Value;
        public static implicit operator Biography(string bio) => new(bio);
    }
}
