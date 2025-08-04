
using DDD.Domain.DomainEvents;
using DDD.Domain.Exception.CourseManagementException;
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
            RaiseDomainEvent(new NewCourseCreatedEvent(this));
        }
        public Course()
        {
            
        }

        public void AddCourseAttendee(CourseAttendee courseAttendee)
        {
            var attendeeExists = _courseAttendees.Any(a => a.Id == courseAttendee.Id);
            if (attendeeExists)
            {
                throw new CourseAttendeeAlreadyExistsException();
            }

            _courseAttendees.AddLast(courseAttendee);
            RaiseDomainEvent(new CourseAtendeeAddedEvent(this , courseAttendee));
        }

        private CourseAttendee GetAttendee(BaseId id)
        {
            var attendee = _courseAttendees.SingleOrDefault(a => a.Id == id);

            if (attendee == null)
            {
                throw new CourseAttendeeFoundException();
            }

            return attendee;
        }


        public void RemoveCourseAttendee(BaseId id)
        {
            var attendee = GetAttendee(id);
            _courseAttendees.Remove(attendee);
        }


        #region Course Catalog Activitiess
        public void AddCourseCatalog(CourseCatalog courseCatalog)
        {
            var catalogExists = _courseAttendees.Any(c => c.Id == courseCatalog.Id);
            if (catalogExists)
            {
                throw new CourseCatalogAlreadyExistsException();
            }

            _courseCatalogs.AddLast(courseCatalog);
        }

        public void RemoveCourseCatalog(BaseId id)
        {
            var catalog = GetCourseCatalog(id);
            _courseCatalogs.Remove(catalog);
        }

        private CourseCatalog GetCourseCatalog(BaseId id)
        {
            var catalog = _courseCatalogs.SingleOrDefault(c => c.Id == id);

            if (catalog == null)
            {
                throw new CourseCatalogNotFoundException();
            }

            return catalog;
        }

        #endregion

    }
}
