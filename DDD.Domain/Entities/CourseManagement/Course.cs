
using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CourseManagement
{
    public class Course:AggregateRoot<BaseId>
    {
        
       
     

        private Title _title;
        private Description _description;
        public bool IsFree { get; set; }
        private Price _price;
        private BaseId _instructorId;
        private LinkedList<CourseCatalog> _courseCatalogs;
        private LinkedList<CourseAttendee> _courseAttendees;

        internal Course(BaseId id,Title title, Description description, bool isFree, Price price, BaseId instructorId) 
        {
            Id = id;
            _title = title;
            _description = description;
            IsFree = isFree;
            _price = price;
            _instructorId = instructorId;
        }
        public Course()
        {
            
        }

    }
}
