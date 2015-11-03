using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;


public class CreateNewPotion : MonoBehaviour
{

    private BasePotion newPotion;

    //TODO: PLEASE EXPAND THE POTION LEVELS
    private string[] potionNames = new string[4] {"Small", "Medium", "Large", "Full"};

    //TODO: PLEASE CREATE POTION DESCRIPTIONS
    private string[] potionDescriptions = new string[2] {"Test Description 1", "Test Description 2"};




	// Use this for initialization
	void Start () {

	    CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.PotionType);
        Debug.Log(newPotion.ItemId);
        //Debug.Log(newPotion.Intellect);


        }

    private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = potionNames[Random.Range(0, 3)] + " Potion";
        newPotion.ItemDescription = potionDescriptions[Random.Range(0, 1)];
        newPotion.ItemId = Random.Range(200, 299);
        ChoosePotionType();

    }

    private void ChoosePotionType()
        {
        var enumLength = Enum.GetValues(typeof(BasePotion.PotionTypes)).Length;
        var randomTemp = Random.Range(1, enumLength);
        newPotion.PotionType = (BasePotion.PotionTypes)randomTemp;
        }

    }
