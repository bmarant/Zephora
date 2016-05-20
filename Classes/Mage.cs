using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ZephorasWorld.Classes
{

 
    class Mage : Entity
    {
      //  Random rand = new Random();
        public Mage()
             :base()
        {
          
        }

        public Mage(string name, EntityGender gender)
        {
            Name = name;
            Gender = gender;
            _wisdom = rand.Next(3, 8);
        }

        public Mage(string name, EntityGender gender, int strength, int wisdom, int dexterity, int health)
        {
            _name = name;
            _gender = gender;
            _strength = strength;
            _dexterity = dexterity;
            _wisdom = wisdom;
            _health = health;
        }
    }
}
