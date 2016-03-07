using Common;
using CQRS;

namespace Services.Auth
{
    public class CreateIdentityCommand : Command
    {
        private Key<int> UserId { get; set; }
        private IdentityName Name { get; set; }
    }
}