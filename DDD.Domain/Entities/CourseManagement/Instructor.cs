using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CourseManagement
{
    public class Instructor:BaseEntity
    {

        private FullName _fullName;
        private Biography _biography;
        private LinkedList<Course> _courses;

        internal Instructor(BaseId id, FullName fullName, Biography biography) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
        }
        public Instructor(BaseId id):base(id) 
        {
            
        }

        public void UpdateFullName(FullName fullName)
        {
            _fullName = fullName;
        }


    }
}
