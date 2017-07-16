using Conan.Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conan.Generator.ViewModels
{
    public class NpcViewModel : AbstractNpc
    {
        public bool IsMinion { get; set; }
        public bool IsToughend { get; set; }
        public bool IsNemesis { get; set; }

        public NpcViewModel() { }

        public NpcViewModel(AbstractNpc npc) : base (npc)
        {
            IsMinion = false;
            IsNemesis = false;
            IsToughend = false;

            switch (npc.Type)
            {
                case NpcType.Minion:
                    IsMinion = true;
                    break;
                case NpcType.Toughend:
                    IsToughend = true;
                    break;
                case NpcType.Nemesis:
                    IsNemesis = true;
                    break;
                default:
                    break;
            }
        }
    }
}