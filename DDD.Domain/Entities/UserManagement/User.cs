using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities.UserManagement;

public class User:BaseEntity
{

    private UserName _userName;
    private Password _password;
    private Email _email;
    private bool _isConfirmed;
    private LinkedList<UserRole> _userRoles;
    internal User(BaseId id, UserName userName, Password password, Email email, bool isConfirmed, LinkedList<UserRole> userRoles) : base(id)
    {
        _userName = userName;
        _password = password;
        _email = email;
        _isConfirmed = isConfirmed;
        _userRoles = userRoles;
    }

    public User(BaseId id):base(id) 
    {
            
    }


}
