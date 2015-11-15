using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class GameInformation : MonoBehaviour {



    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    //Player Stats
	public static string PlayerName { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int PlayerLevel { get; set; }
    public static int Endurance { get; set; }
    public static int Dexterity { get; set; }
    public static int Strength { get; set; }
    public static int Charm { get; set; }
    public static int Intellect { get; set; }
    public static int Evasion { get; set; }
    public static int Spirit { get; set; }
    public static int Luck { get; set; }
    public static int Speed { get; set; }
    public static int Hp { get; set; }
    public static int Mp { get; set; }
    public static int currentXp { get; set; }
    public static int requiredXP { get; set; }
    public static int gold { get; set; }

    //Equipment
    public static BaseArmor ArmorPieceHead { get; set; }

    }
