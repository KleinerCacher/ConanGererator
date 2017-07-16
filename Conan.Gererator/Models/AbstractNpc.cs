using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conan.Npc.Generator.Models
{
    public class AbstractNpc
    {
        public int ID { get; set; }
        public string Name  { get; set; }

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

        public virtual int Vigor { get; }
        public virtual int Resolve { get; }
    }
}
