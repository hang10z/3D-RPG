using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class GameInformation : MonoBehaviour {



    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

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
    public static int HP { get; set; }
    public static int MP { get; set; }


    }
