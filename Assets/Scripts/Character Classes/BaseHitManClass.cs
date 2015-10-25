﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class BaseHitManClass : BaseCharacterClass {

    public BaseHitManClass()
    {
        CharacterClassName = "HitMan";
        CharacterClassDescription = "A Hitman blends in with the everyday people and quickly eliminates his targets";

        Dexterity = 25;
        Endurance = 10;
        Intellect = 15;
        Strength = 5;

        }

	
}
