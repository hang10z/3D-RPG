using UnityEngine;
using System.Collections;

[System.Serializable]

public class BaseArmor : BaseStatItem      //BaseArmor <-BaseStatItem <- BaseItem (Class Inheritance)
    {         

    public enum ArmorTypes
    {
        NO_SET,
        HEAD,
        CHEST,
        SHOULDER,
        ARMS,
        HANDS,
        LEGS,
        FEET,
        NECK,
        RING
    }

    private ArmorTypes armorType;
    private int spellEffectID;

    public ArmorTypes ArmorType
    {
        get { return armorType; }
        set { armorType = value; }
    }

    public int SpellEffectId
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
