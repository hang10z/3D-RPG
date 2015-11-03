using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;



public class CreateNewPlayer : MonoBehaviour
{


    private BasePlayer newPlayer;
    private string playerName = "PLEASE ENTER A NAME FOR YOUR HERO!";

    private enum PlayerClasses
    {
        MAGE,
        WARRIOR,
        HITMAN,
        MEDIC
    }

    private PlayerClasses selectedClass;

	// Use this for initialization
	void Start () {

	newPlayer = new BasePlayer();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


     void OnGUI()
     {
         playerName = GUILayout.TextArea(playerName);

        if(GUILayout.Toggle(selectedClass == PlayerClasses.MAGE, "MAGE CLASS"))selectedClass = PlayerClasses.MAGE;
        if (GUILayout.Toggle(selectedClass == PlayerClasses.WARRIOR, "WARRIOR CLASS")) selectedClass = PlayerClasses.WARRIOR;
        if (GUILayout.Toggle(selectedClass == PlayerClasses.HITMAN, "HITMAN CLASS")) selectedClass = PlayerClasses.HITMAN;
        if (GUILayout.Toggle(selectedClass == PlayerClasses.MEDIC, "MEDIC CLASS")) selectedClass = PlayerClasses.MEDIC;


         if (GUILayout.Button("CREATE"))
         {
             if (selectedClass == PlayerClasses.MAGE)
             {
                 newPlayer.PlayerClass = new BaseMageClass();
             }else if (selectedClass == PlayerClasses.WARRIOR)
             {
                 newPlayer.PlayerClass = new BaseWarriorClass();
             }else if (selectedClass == PlayerClasses.HITMAN)
             {
                 newPlayer.PlayerClass = new BaseHitManClass();
             }else if (selectedClass == PlayerClasses.MEDIC)
             {
                 newPlayer.PlayerClass = new BaseMedicClass();
             }

             //Setup the player Stats
             newPlayer.PlayerLevel = 1;
             newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
             newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
             newPlayer.Strength = newPlayer.PlayerClass.Strength;
             newPlayer.Charm = newPlayer.PlayerClass.Charm;
             newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
             newPlayer.Evasion = newPlayer.PlayerClass.Evasion;
             newPlayer.Spirit = newPlayer.PlayerClass.Spirit;
             newPlayer.Luck = newPlayer.PlayerClass.Luck;
             newPlayer.Speed = newPlayer.PlayerClass.Speed;
             newPlayer.Hp = newPlayer.PlayerClass.Hp;
             newPlayer.Mp = newPlayer.PlayerClass.Mp;
             newPlayer.PlayerName = playerName;

            //Calls Another Script to Save Info to Unity Prefs,
             SaveInformation.SaveAllInformation();

            //Debug
            Debug.Log("Player Name " + newPlayer.PlayerName);
            Debug.Log("Player Class " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Description " + newPlayer.PlayerClass.CharacterClassDescription);
            Debug.Log("Player Level " + newPlayer.PlayerLevel);
            Debug.Log("Player Endurance " + newPlayer.Endurance);
            Debug.Log("Player Dexterity " + newPlayer.Dexterity);
            Debug.Log("Player Strength " + newPlayer.Strength);
            Debug.Log("Player Charm " + newPlayer.Charm);
            Debug.Log("Player Intellect " + newPlayer.Intellect);
            Debug.Log("Player Evasion " + newPlayer.Evasion);
            Debug.Log("Player Spirit " + newPlayer.Spirit);
            Debug.Log("Player Luck " + newPlayer.Luck);
            Debug.Log("Player Speed " + newPlayer.Speed);
            Debug.Log("Player HP " + newPlayer.Hp);
            Debug.Log("Player MP " + newPlayer.Mp);
            }


        }

    //Save the info into the information file.
    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Endurance = newPlayer.Endurance;
        GameInformation.Dexterity = newPlayer.Dexterity;
        GameInformation.Strength = newPlayer.Strength;
        GameInformation.Charm = newPlayer.Charm;
        GameInformation.Intellect = newPlayer.Intellect;
        GameInformation.Evasion = newPlayer.Evasion;
        GameInformation.Spirit = newPlayer.Spirit;
        GameInformation.Luck = newPlayer.Luck;
        GameInformation.Speed = newPlayer.Speed;
        GameInformation.HP = newPlayer.Hp;
        GameInformation.MP = newPlayer.Mp;
        }

}
