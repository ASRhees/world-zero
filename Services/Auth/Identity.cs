using Common;

namespace Services.Auth
{
    public class Identity
    {
        public Key<int> UserId { get; set; }
        public Key<string> Role { get; set; }
        public IdentityName Name { get; set; }
        public Attribute Attributes { get; set; }
        public Permission Permissions { get; set; }
    }
}