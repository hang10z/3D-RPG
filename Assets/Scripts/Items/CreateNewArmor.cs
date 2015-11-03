using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;

public class CreateNewArmor : MonoBehaviour
{

    private BaseArmor newArmor;
    private string[] armorNames = new string[4] {"Common", "Magical", "Rare", "Legendary"};
    private string[] armorDescriptions = new string[2] {"Description Type 1 Test", "Description Type 2 Test"};
    //TODO: REPLACE ARMOR DESCRIPTIONS WITH REAL ONES
    //TODO: REPLACE ARMOR NAMES WITH REAL NAME TYPES

	// Use this for initialization
	void Start () {
        CreateArmor();
        Debug.Log(newArmor.ItemName);
        Debug.Log(newArmor.ItemDescription);
        Debug.Log(newArmor.ArmorType);
        Debug.Log(newArmor.ItemId);
        Debug.Log(newArmor.Intellect);

        }

    private void CreateArmor()
    {
        newArmor = new BaseArmor();
        newArmor.ItemName = armorNames[Random.Range(0, 3)] + " Armor";
        newArmor.ItemDescription = armorDescriptions[Random.Range(0, 1)];
        newArmor.ItemId = Random.Range(1, 99);
        ChooseArmorType();
        newArmor.Strength = Random.Range(1, 5);
        newArmor.Dexterity = Random.Range(1, 5);
        newArmor.Evasion = Random.Range(1, 5);
        newArmor.Hp = Random.Range(30, 100);
        newArmor.Intellect = Random.Range(1, 5);
        //TODO: MAKE THE STATS FOR ARMOR MEANINGFUL 
        }

    private void ChooseArmorType()
    {
        var enumLength = Enum.GetValues(typeof(BaseArmor.ArmorTypes)).Length;
        var randomTemp = Random.Range(1, enumLength);
        newArmor.ArmorType = (BaseArmor.ArmorTypes)randomTemp;
        }

	// Update is called once per frame
	void Update () {
	
	}
}
