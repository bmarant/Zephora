using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZephorasWorld.Classes
{
   public class Player :Entity
    {

        Random rand = new Random();

        public Player()
            :base()
        {

        }
        public Player(string name, EntityGender eGender, EntityClass eClass) 
            :base()
        {
            Name = name;
            Gender = eGender;
           CharacterClass = eClass;
        }

        public Player(string name) : base()
        {
            Name = name;
        }

        public Player(string name, EntityGender eGender, EntityClass eClass, int dexterity, int strength, 
            int wisdom, int health) 
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            Dexterity = dexterity;
            Strength = strength;
            Health = health;
            Wisdom = wisdom;
        }

     
       
          
   
    }
}
