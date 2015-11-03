using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class CreateNewScroll : MonoBehaviour
{

    private BaseScroll newScroll;

    //TODO: We need to completely think out the scrolls and create something that works, this is a temp holder script
    private string[] scrollNames = new string[4] {"Air", "Water", "Earth", "Fire"};
    private string[] scrollDescriptions = new string[2] {"Scroll Description Test 1", "Scroll Description Test 2"};

    // Use this for initialization
    private void Start()
    {
        CreateScroll();

        Debug.Log(newScroll.ItemName);
        Debug.Log(newScroll.ItemDescription);
        Debug.Log(newScroll.SpellEffectID);
        Debug.Log(newScroll.ItemId);


        }

    private void CreateScroll()
    {
        newScroll = new BaseScroll();
        newScroll.ItemName = scrollNames[Random.Range(0, scrollNames.Length)] + " Scroll";
        newScroll.ItemDescription = scrollDescriptions[Random.Range(0, scrollDescriptions.Length)];
        newScroll.ItemId = Random.Range(300, 399);
        newScroll.SpellEffectID = Random.Range(500, 599);
    }

}
