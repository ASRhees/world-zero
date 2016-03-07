using System.Collections.Generic;
using Common;

namespace Services.Auth
{
    public class Role
    {
        public Key<string> Name { get; private set; }
        public Permission Permission { get; private set; }

        public Role(Key<string> name, Permission permission)
        {
            Name = name;
            Permission = permission;
        }

        public static readonly Role Admin = new Role(new Key<string>("Administrator"), 0),
            Mod = new Role(new Key<string>("Moderator"), 0),
            User = new Role(new Key<string>("User"), 0);

        public static Role Parse(string value)
        {
            
        }

        public static IDictionary<Key<string>, Permission> Predefined { get; } = new Dictionary<Key<string>, Permission>()
        {
            { Admin.Name, Admin.Permission },
            { Mod.Name, Mod.Permission },
            { User.Name, User.Permission }
        };
    }
}