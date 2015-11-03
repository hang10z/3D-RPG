using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour
    {

    //TODO:Expand the BattleStates, Like Animations and Such
    public enum BattleStates
        {
        START,
        PLAYERCHOICE,
        PLAYERANIMATION,
        ENEMYCHOICE,
        ENEMYANIMATION,
        LOSE,
        WIN
        }

    private BattleStates currentState;

    // Use this for initialization
    void Start()
        {
        currentState = BattleStates.START;

        }


    void Update()
        {


        Debug.Log(currentState);


        switch (currentState)
            {
            case (BattleStates.START):

                //TODO:SETUP BATTLE FUNCTION
                break;
            case (BattleStates.PLAYERCHOICE):

                //TODO:PLAYER CHOICE FUNCTIONS
                break;

            case (BattleStates.PLAYERANIMATION):

                break;

            case (BattleStates.ENEMYCHOICE):

                break;

            case (BattleStates.ENEMYANIMATION):

                break;

            case (BattleStates.LOSE):

                break;

            case (BattleStates.WIN):

                break;
            }

        //TEST BUTTON TO SHOW STATES
     
        }

    public void OnGUI()
        {
        if (GUILayout.Button("NEXT STATE"))
            {
                if (currentState == BattleStates.START)
                {
                    currentState = BattleStates.PLAYERCHOICE;
                }else if (currentState == BattleStates.PLAYERCHOICE)
                {
                    currentState = BattleStates.PLAYERANIMATION;
                }else if (currentState == BattleStates.PLAYERANIMATION)
                {
                    currentState = BattleStates.ENEMYCHOICE;
                }else if (currentState == BattleStates.ENEMYCHOICE)
                {
                    currentState = BattleStates.ENEMYANIMATION;
                }else if (currentState == BattleStates.ENEMYANIMATION)
                {
                    currentState = BattleStates.WIN;
                }else if (currentState == BattleStates.WIN)
                {
                    currentState = BattleStates.LOSE;
                }else if (currentState == BattleStates.LOSE)
                {
                    currentState = BattleStates.START;
                }
            }
        }

}
