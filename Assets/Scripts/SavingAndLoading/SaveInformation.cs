using UnityEngine;
using System.Collections;

public class SaveInformation {

    //TODO: STILL NEED TO SAVE THE PLAYER CLASS

    public static void SaveAllInformation()
    {

        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("ENDURANCE", GameInformation.Endurance);
        PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("CHARM", GameInformation.Charm);
        PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);
        PlayerPrefs.SetInt("EVASION", GameInformation.Evasion);
        PlayerPrefs.SetInt("SPIRIT", GameInformation.Spirit);
        PlayerPrefs.SetInt("LUCK", GameInformation.Luck);
        PlayerPrefs.SetInt("SPEED", GameInformation.Speed);
        PlayerPrefs.SetInt("HP", GameInformation.Hp);
        PlayerPrefs.SetInt("MP", GameInformation.Mp);
        PlayerPrefs.SetInt("GOLD", GameInformation.gold);

        //Access Serialized Information example
        if (GameInformation.ArmorPieceHead != null)
        {
            PPSerialization.Save("ARMORPIECEHEAD", GameInformation.ArmorPieceHead);
            Debug.Log("Saved" + GameInformation.ArmorPieceHead+ " via Serialization");

        }
        else
        {
            Debug.Log("Serialization object was null");
        }

        //Debug
        Debug.Log("DEBUG:   SAVED ALL PLAYER INFO");

        }
}
