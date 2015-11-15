using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class DisplayCreatePlayerFunctions : MonoBehaviour
{

    private int classSelection;

    private string [] classSelectionNames = new string[] { "Mage", "Warrior", "Hitman", "Medic"};

    public void DisplayClassSelections()
    {
        //A list of Toggle Buttons, Each Button Will be Different Class
        //List of classes and stats
        //Selection Grid
        classSelection = GUI.SelectionGrid(new Rect(50,50,250,300), classSelection, classSelectionNames, 2);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));

    }

    private string FindClassDescription(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        }else if (classSelection == 2)
        {
            BaseCharacterClass tempClass = new BaseHitManClass();
            return tempClass.CharacterClassDescription;

        }else if (classSelection == 3)
        {
            BaseCharacterClass tempClass = new BaseMedicClass();
            return tempClass.CharacterClassDescription;
        }

        return "Character Description";

    }

    /*private string FindClassStatValues(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            string tempStats = "Stamina " + tempClass.Dexterity;


            return "Character Description";
        }
    }*/

    public void DisplayStatAllocation()
    {
        //List of Stats with + and - buttons
        //Have a total amount of points to allocate
    }

    public void DisplayFinalSetup()
    {
        //Gender and Looks, Name and Bio
    }

    public void DisplayCommonGUIElements()
    {
        GUI.Label(new Rect(Screen.width/2, 32, 250, 250), "CREATE NEW PLAYER");
    }
    
}
