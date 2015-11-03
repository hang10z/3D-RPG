using System;
using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using Random = UnityEngine.Random;

public class CreateNewWeapon : MonoBehaviour
{

    private BaseWeapon newWeapon;

    //Temp Weapon List
    private string[] weaponNames = new string[8] {"Acrimony","Agony","Azure Lightning","Balance","Blessed One","Bone","Bonnie’s Bounty","Brawn"};


    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.WeaponType);
        Debug.Log(newWeapon.ItemId);
        Debug.Log(newWeapon.Intellect);


        }

    public void CreateWeapon(){

        newWeapon = new BaseWeapon();

        //assign name to weapon
        //TODO: Make a random Weapon Name Array and Assign
        //newWeapon.TemName = "W" + Random.Range(1,101);
        newWeapon.ItemName = weaponNames[Random.Range(0, weaponNames.Length)];

        //create a weapon description
        //TODO: Make a random Description Array and assign
        newWeapon.ItemDescription = "This is a temp Description";

        //weapon id
        //TODO: Make Sure Random ID is never Assigned Twice
        newWeapon.ItemId = Random.Range(100, 199);

        //stats
        //TODO: The stat generation needs to be changed, need new logic: Stats need to grow in size as Level does; Magic Weapon increases Magic More than Strength.. ETC
        //This section needs to be throughly reworked for good weapon generation
      
        newWeapon.Strength = Random.Range(1, 5);
        newWeapon.Dexterity = Random.Range(1, 5);
        newWeapon.Evasion = Random.Range(1, 5);
        newWeapon.Hp = Random.Range(30, 100);
        newWeapon.Intellect = Random.Range(1, 5);

        //choose type of weapon
        ChooseWeaponType();

        //spell effect id
        //TODO: Remember to Implement Spelleffect ID, and make sure this code makes sense
        newWeapon.SpellEffectID = Random.Range(500, 599);

    }

    private void ChooseWeaponType()
    {
        //First Get the length of the Enum WeaponTypes in the BaseWeapon Script
        //Then generate a random number between 1 and the enum length
        //Then pick the random number, which corresponds to an element in the WeaponTypes Enum and assign it as the weapontype
        var enumLength = Enum.GetValues(typeof(BaseWeapon.WeaponTypes)).Length;
        var randomTemp = Random.Range(1, enumLength);
        newWeapon.WeaponType = (BaseWeapon.WeaponTypes) randomTemp;

    }
}
