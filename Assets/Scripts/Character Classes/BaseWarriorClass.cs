namespace Assets.Scripts.Character_Classes
{
    public class BaseWarriorClass : BaseCharacterClass {

        public BaseWarriorClass()
        {
            CharacterClassName = "Warrior";
            CharacterClassDescription =
                "Warriors are the bread and butter tank of the game, they have high strength and low intellect";
            Dexterity = 10;
            Endurance = 15;
            Intellect = 5;
            Strength = 25;


        }
    }
}
