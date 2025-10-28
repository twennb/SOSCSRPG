using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    internal class Player
    {
        string Name { get; set; } // defines a Name attribute of type string where the value can be defined "set" and read "get"
        string CharacterClass { get; set; }
        int HitPoints { get; set; }
        int ExperiencePoints { get; set; } 
        int Level { get; set; }
        int Gold { get; set; }

    }
}
