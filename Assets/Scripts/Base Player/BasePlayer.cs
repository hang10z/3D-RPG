using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class BasePlayer
{

    private string playerName;
    private int playerLevel;

    private BaseCharacterClass playerClass;

    //STATS
    private int dexterity;  //  Hit % / accuracy / crit
    private int endurance;  //  Physical atk Resistance
    private int spirit;     //  Magic atk Resistance
    private int strength;   //  Melee atk Modifier
    private int intellect;  //  Magic atk Modifier
    private int luck;       //  Health per lvl Modifier
    private int charm;      //  Magic per lvl Modifier
    private int evasion;    //  Physical Dodge
    private int speed;      //  Rate of turn
    private int hp;         //  HP
    private int mp;         //  MP

    private int gold;       // currency
    private int currentXP;  // Current XP Value
    private int requiredXP; // Level Requirement XP Value


    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Spirit
    {
        get { return spirit; }
        set { spirit = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }

    public int Charm
    {
        get { return charm; }
        set { charm = value; }
    }

    public int Evasion
    {
        get { return evasion; }
        set { evasion = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }

    public int Mp
    {
        get { return mp; }
        set { mp = value; }
    }

    public int CurrentXp
    {
        get { return currentXP; }
        set { currentXP = value; }
    }

    public int RequiredXp
    {
        get { return requiredXP; }
        set { requiredXP = value; }
    }

    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }
}
