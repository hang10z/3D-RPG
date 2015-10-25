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

        }

	
}
