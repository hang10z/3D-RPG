using UnityEngine;
using System.Collections;

public class BaseArmor : BaseStatItem      //BaseArmor <-BaseStatItem <- BaseItem (Class Inheritance)
    {         

    public enum ArmorTypes
    {
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
