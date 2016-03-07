using System;

namespace Services.Auth
{
    [Flags]
    public enum Attribute
    {
        Disabled = 1,
        Suspended = 2,
        Unverified = 4
    }
}