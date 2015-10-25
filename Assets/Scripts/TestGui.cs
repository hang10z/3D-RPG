using UnityEngine;
using System.Collections;
using Assets.Scripts.Character_Classes;

public class TestGui : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseMageClass();
    private BaseCharacterClass class2 = new BaseWarriorClass();



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGui()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);

        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);


    }
}
