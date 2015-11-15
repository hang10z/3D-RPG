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
            Spirit = 5;
            Luck = 5;
            Charm = 5;
            Evasion = 10;
            Speed = 10;
            Hp = 100;
            Mp = 0;
            Gold = 100;


            }
    }
}
