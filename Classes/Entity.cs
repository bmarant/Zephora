using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZephorasWorld.Classes
{
    public enum EntityGender {Male, Female, Unknown}
    public enum EntityClass {Magician, Rogue, Cleric, Paladin, Necromancer,Druid, Beastlord,Ranger,Enchanter,Wizard,Warrior, Unknown}


 

    public abstract class Entity
    {

        #region Field Region
        protected Random rand;
        protected EntityGender _gender;
        protected EntityClass _characterclass;
        protected string _name;
        protected int _strength;
        protected int _dexterity;
        protected int _wisdom;
        protected int _health;
        protected int _strengthModifier, _dexterityModifier, _wisdomModifier, _healthModifier;
        

#endregion

        #region Property Region

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public EntityGender Gender
        {
            get { return _gender; }
             set { _gender = value; }
        }
        public int Strength
        {
            get { return _strength + _strengthModifier; }
            set { _strength = value; }
        }
        public int Dexterity
        {
            get { return _dexterity + _dexterityModifier; }
            set { _dexterity = value; }
        }
        public int Wisdom
        {
            get { return _wisdom + _wisdomModifier; }
            set { _wisdom = value; }
        }
        public int Health
        {
            get { return _health + _healthModifier; }
             set { _health = value; }
        }

        public EntityClass CharacterClass
        {
            get { return _characterclass; }
            set { _characterclass = value; }
        }
        #endregion
      
        #region Constructors Region

        public Entity()
        {

            Random rands = new Random();
                Name = "";  
                Gender = EntityGender.Unknown;
                CharacterClass = EntityClass.Unknown; 
                Strength = rands.Next(80, 110);
                Dexterity = rands.Next(85, 100);
                Wisdom = rands.Next(115, 134);
                Health = rands.Next(90, 100);

                
                


         


        }
       
        

        #endregion
       
        #region Method Region



        #endregion

    }


}

