namespace Assets.Scripts.Character_Classes
{
    public class BaseMageClass : BaseCharacterClass {

        public BaseMageClass()
        {
            CharacterClassName = "Mage";
            CharacterClassDescription =
                "The mage is a master of the arcane arts, he has the highest intellect, but is physically feeble and weak";
            Dexterity = 15;
            Endurance = 10;
            Intellect = 25;
            Strength = 5;

        }
	
    }
}
