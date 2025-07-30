using DDD.Domain.Exception.CourseManagementException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public record Title
    {
        public  string Value { get;  }
        public Title(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new TitleNullOrEmptyException();
            if (value.Length > 50)
                throw new InvalidTitleLenghtException(50);

            Value = value;

        }

        public static implicit operator string (Title title) => title.Value;    
        public static implicit operator Title(string value) => new Title(value);
    }
}
