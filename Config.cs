using System.ComponentModel;
using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace ScpForce
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The list of the RoleTypes to convert players OnRoundEnded")]
        public List<RoleType> Roles { get; set; } = new List<RoleType>
        {
            RoleType.Scp049,
            RoleType.Scp0492,
            RoleType.Scp096,
            RoleType.Scp106,
            RoleType.Scp93989,
            RoleType.NtfCommander
        };
    }
}
