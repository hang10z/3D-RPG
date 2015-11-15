using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class BaseMedicClass : BaseCharacterClass {

    public BaseMedicClass()
    {
        CharacterClassName = "Medic";
        CharacterClassDescription = "A medic specializes in healing and buffing";

        Dexterity = 15;
        Endurance = 15;
        Intellect = 15;
        Strength = 10;
        Spirit = 5;
        Luck = 5;
        Charm = 5;
        Evasion = 15;
        Speed = 15;
        Hp = 100;
        Mp = 50;
        Gold = 100;

        }

	
}
