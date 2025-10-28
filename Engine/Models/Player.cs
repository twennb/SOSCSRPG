using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        public string Name { get; set; } // defines a Name attribute of type string where the value can be defined "set" and read "get"
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; } 
        public int Level { get; set; }
        public int Gold { get; set; }

    }
}
