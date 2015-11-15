using UnityEngine;
using System.Collections;

public class TestLoadScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	    LoadInformation.LoadAllInformation();
        //Debug
        Debug.Log("Player Name " + GameInformation.PlayerName);
       // Debug.Log("Player Class " + newPlayer.PlayerClass.CharacterClassName);
       // Debug.Log("Player Description " + newPlayer.PlayerClass.CharacterClassDescription);
        Debug.Log("Player Level " + GameInformation.PlayerLevel);
        Debug.Log("Player Endurance " + GameInformation.Endurance);
        Debug.Log("Player Dexterity " + GameInformation.Dexterity);
        Debug.Log("Player Strength " + GameInformation.Strength);
        Debug.Log("Player Charm " + GameInformation.Charm);
        Debug.Log("Player Intellect " + GameInformation.Intellect);
        Debug.Log("Player Evasion " + GameInformation.Evasion);
        Debug.Log("Player Spirit " + GameInformation.Spirit);
        Debug.Log("Player Luck " + GameInformation.Luck);
        Debug.Log("Player Speed " + GameInformation.Speed);
        Debug.Log("Player HP " + GameInformation.Hp);
        Debug.Log("Player MP " + GameInformation.Mp);
        Debug.Log("Player Gold " + GameInformation.gold);



        }
	
	// Update is called once per frame
	void Update () {
	
	}
}
