namespace Assets.Scripts.Character_Classes
{
    public class BaseCharacterClass
    {

        private string characterClassName;
        private string characterClassDescription;

        //Stats
        private int dexterity;
        private int endurance;
        private int strength;
        private int intellect;

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
    }
}
