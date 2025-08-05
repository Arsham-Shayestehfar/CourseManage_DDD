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
        private int _experience;
        private double _rating;
        private LinkedList<Course> _courses;

        internal Instructor(BaseId id, FullName fullName, Biography biography) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
            _experience = 3;
            _rating = 0;
        }

        internal Instructor(BaseId id, FullName fullName, Biography biography,int experience) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
            _experience = experience;
            _rating = 0;
        }
        internal Instructor(BaseId id, FullName fullName, Biography biography, int experience,double rating) : base(id)
        {
            _fullName = fullName;
            _biography = biography;
            _experience = experience;
            _rating = rating;
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
