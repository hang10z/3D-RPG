using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

	public enum PotionTypes
	{
	    HP,
        MP,
        CURE,
        DEXTERITY,
        ENDURANCE,
        SPIRIT,
        STRENGTH,
        INTELLECT,
        EVASION,
        SPEED,
        LUCK,
        CHARM
	}

    private PotionTypes potionType;
    private int spellEffectID;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
