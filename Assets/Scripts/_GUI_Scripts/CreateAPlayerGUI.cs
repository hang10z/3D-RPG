using UnityEngine;
using System.Collections;

public class CreateAPlayerGUI : MonoBehaviour {

    public enum CreateAPlayerStates
    {
        CLASSSELECTION,      //Display all class types
        STATALLOCATION,       //Allocate Stats
        FINALSETUP           // Add Name and misc items, gender

    }

    //Create a public instance so it is accessible to our DisplayCreatePLayerFunctions Script
    public static CreateAPlayerStates currentState;

    //Create an instance of the DisplayCreatePlayerFunctions Script
    private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();


    // Use this for initialization
    void Start()
        {

        //Start on first Character Creation Screen
        currentState = CreateAPlayerStates.CLASSSELECTION;

        }

    // Update is called once per frame
    void Update()
        {
        switch (currentState)
            {
            case (CreateAPlayerStates.CLASSSELECTION):
                break;
            case (CreateAPlayerStates.STATALLOCATION):
                break;
            case (CreateAPlayerStates.FINALSETUP):
                break;
            }

        }

    void OnGUI()
        {
        //
        displayFunctions.DisplayCommonGUIElements();

        if (currentState == CreateAPlayerStates.CLASSSELECTION)
            {
            //Display Class Selection Function
            displayFunctions.DisplayClassSelections();
            }

        if (currentState == CreateAPlayerStates.STATALLOCATION)
            {
            //Display Stat Allocation Function
            displayFunctions.DisplayStatAllocation();
            }

        if (currentState == CreateAPlayerStates.FINALSETUP)
            {
            //Display Final Setup Function
            displayFunctions.DisplayFinalSetup();
            }
        }
}
