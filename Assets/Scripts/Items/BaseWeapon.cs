using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {    //BaseWeapon <-BaseStatItem <- BaseItem (Class Inheritance)

    public enum WeaponTypes
    {
        NOT_SET,
        SWORD,
        KNUCKLE,
        STAFF,
        DAGGER,
        BOW,
        GUN,
        BOOK,
        THROW
    }

    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
