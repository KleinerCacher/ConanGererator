using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conan.Generator.Models
{
    public class AbstractNpc
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Awareness { get; set; }
        public int Intelligence { get; set; }
        public int Personality { get; set; }
        public int Agility { get; set; }
        public int Brawn { get; set; }
        public int Willpower { get; set; }
        public int Coordination { get; set; }

        public int Combat { get; set; }
        public int Movement { get; set; }
        public int Fortitude { get; set; }
        public int Senses { get; set; }
        public int Knowledge { get; set; }
        public int Social { get; set; }

        public NpcType Type { get; set; }

        public AbstractNpc() { }

        public AbstractNpc(AbstractNpc npc)
        {
            this.ID = npc.ID;
            this.Intelligence = npc.Intelligence;
            this.Knowledge = npc.Knowledge;
            this.Movement = npc.Movement;
            this.Name = npc.Name;
            this.Personality = npc.Personality;
            this.Senses = npc.Senses;
            this.Social = npc.Social;
            this.Type = npc.Type;
            this.Willpower = npc.Willpower;
            this.Fortitude = npc.Fortitude;
            this.Coordination = npc.Coordination;
            this.Combat = npc.Combat;
            this.Brawn = npc.Brawn;
            this.Awareness = npc.Awareness;
            this.Agility = npc.Agility;
        }
    }
}
