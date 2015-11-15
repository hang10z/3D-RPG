using UnityEngine;
using System.Collections;

public static class IncreaseExperience {

    private static int xpToGive;
    private static LevelUp levelUpScript = new LevelUp();

    public static void AddExperience()
    {
        xpToGive = GameInformation.PlayerLevel*100;
        GameInformation.currentXp += xpToGive;
        CheckIfPlayerLeveled();
        
        
        Debug.Log(xpToGive);
    }

    public static void AddExplorationExp()
    {
        xpToGive = GameInformation.PlayerLevel*10;
        GameInformation.currentXp += xpToGive;
        CheckIfPlayerLeveled();
        Debug.Log(xpToGive);
        }


    private static void CheckIfPlayerLeveled()
    {
        if (GameInformation.currentXp >= GameInformation.requiredXP)
            {
            //Then player has leveled up
            levelUpScript.LevelUpCharacter();
            //TODO: CREATE LEVEL UP METHOD


            }
        }
}
