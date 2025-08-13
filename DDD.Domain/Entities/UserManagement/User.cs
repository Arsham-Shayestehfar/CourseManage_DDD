using DDD.Domain.DomainEvents;
using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Domain;

namespace DDD.Domain.Entities.UserManagement;

public class User:AggregateRoot<BaseId>
{

    private UserName _userName;
    private Password _password;
    private Email _email;
    private bool _isConfirmed;
    private LinkedList<UserRole> _userRoles;
    private LinkedList<CourseAttendee> _courseAttendees;
    internal User(BaseId id, UserName userName, Password password, Email email, bool isConfirmed)
    {
        Id = id;
        _userName = userName;
        _password = password;
        _email = email;
        _isConfirmed = isConfirmed;
        
        RaiseDomainEvent(new UserRegisteredEvent(this));
    }

    public User()
    {
            
    }


}
