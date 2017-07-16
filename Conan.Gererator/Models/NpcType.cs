using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conan.Generator.Models
{
    [Flags]
    public enum NpcType
    {
        Minion = 2,
        Toughend = 4,
        Nemesis = 8
    }
}