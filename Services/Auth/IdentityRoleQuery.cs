using Common;
using CQRS;

namespace Services.Auth
{
    public class IdentityRoleQuery : IQuery<PagableEnumerable<Key<int>>>
    {
        
    }
}