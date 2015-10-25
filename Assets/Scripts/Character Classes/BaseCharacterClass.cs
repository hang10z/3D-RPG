using UnityEngine;

namespace Assets.Scripts.Character_Classes
{
    public class BaseCharacterClass
    {

        private string characterClassName;
        private string characterClassDescription;

        //Stats
        private int dexterity;  //  Hit % / accuracy
        private int endurance;  //  Physical atk Resistance
        private int spirit;     //  Magic atk Resistance
        private int strength;   //  Melee atk Modifier
        private int intellect;  //  Magic atk Modifier
        private int vitality;   //  Health per lvl Modifier
        private int mana;       //  Magic per lvl Modifier
        private int evasion;    //  Physical Dodge
        private int speed;      //  Rate of turn
        private int hp;         //  HP
        private int mp;         //  MP


        //Getter and Setters
        public string CharacterClassName
        {
            get { return characterClassName; }
            set { characterClassName = value; }
        }
        public string CharacterClassDescription
        {
            get { return characterClassDescription; }
            set { characterClassDescription = value; }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }

        public int Endurance
        {
            get { return endurance; }
            set { endurance = value; }
        }

        public int Spirit
        {
            get { return spirit; }
            set { spirit = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Intellect
        {
            get { return intellect; }
            set { intellect = value; }
        }

        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; }
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public int Evasion
        {
            get { return evasion; }
            set { evasion = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Mp
        {
            get { return mp; }
            set { mp = value; }
        }
    }
}
