using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities.UserManagement;

public class Role:BaseEntity

{
    private RoleName _roleName;
    private LinkedList<RoleName> _userRoles;
    internal Role(BaseId id, RoleName roleName) : base(id)
    {
        _roleName = roleName;
        
    }

    public Role(BaseId id):base(id) 
    {
        
    }


}
