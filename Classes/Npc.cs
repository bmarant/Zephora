using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZephorasWorld.Classes
{
    class Npc:Entity
    {





        public Npc()
            : base()
        {

        }
        public Npc(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }
    }
}