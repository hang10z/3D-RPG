using UnityEngine;
using System.Collections;

public class LevelUp
{

    public int maxPlayerLevel = 50;

    public void LevelUpCharacter()
    {
        //Check to see if current xp > than required xp

        if (GameInformation.currentXp > GameInformation.requiredXP)
        {
            GameInformation.currentXp -= GameInformation.requiredXP;
        }
        else
        {
            GameInformation.currentXp = 0;
        }
        if (GameInformation.PlayerLevel < maxPlayerLevel)
        {
            //Give Player Stats + level
            GameInformation.PlayerLevel += 1;
            GameInformation.Dexterity += 2;
            GameInformation.Endurance += 2;
            GameInformation.Spirit += 2;
            GameInformation.Strength += 2;
            GameInformation.Intellect += 2;
            GameInformation.Luck += 1;
            GameInformation.Charm += 1;
            GameInformation.Evasion += 1;
            GameInformation.Speed += 1;
            GameInformation.Hp += 100;
            GameInformation.Mp += 50;
            //TODO:Give money?
            //TODO:Give Items?  What do we want to give for level up?
            }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }
        
        
        //Determine the next amount of required xp
        DetermineRequiredXP();

    }

    private void DetermineRequiredXP()
    {
        //Linear XP Progression
        //TODO:FIND A BETTER XP ALGORITHM
        int temp = (GameInformation.PlayerLevel*1000) + 250;
        GameInformation.requiredXP = temp;

    }
}
