using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Rpg.ItemSystem.Editor
{

    public partial class ISQualityDatabaseEditor                 //Database Editor Class Broken up into several scripts
    {
        
        //list all of the stored qualities in the database
        void ListView()
        {
            _scrollPos= EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));

            DisplayQualities();

            EditorGUILayout.EndScrollView();

        }
        
        void DisplayQualities()
        {
            for(int cnt = 0; cnt < qualityDatabase.Count; cnt++)
            {
                GUILayout.BeginHorizontal("Box");

                //Sprite
                if (qualityDatabase.Get(cnt).Icon)
                    selectedTexture = qualityDatabase.Get(cnt).Icon.texture;
                else
                    selectedTexture = null;

                if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
                {
                    int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                    EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
                    selectedIndex = cnt;
                }

                string commandName = Event.current.commandName;
                if (commandName == "ObjectSelectorUpdated")
                {
                    if (selectedIndex != -1)
                    {
                        qualityDatabase.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                        selectedIndex = -1;
                        
                    }
                    Repaint();

                }

                GUILayout.BeginVertical();
                //Name
                qualityDatabase.Get(cnt).Name = GUILayout.TextField(qualityDatabase.Get(cnt).Name);

                //Delete button
                if (GUILayout.Button("DELETE", GUILayout.Width(62), GUILayout.Height(20)))
                {
                    if(EditorUtility.DisplayDialog("Delete Quality", "Are you sure that you want to delete " + qualityDatabase.Get(cnt).Name + " from the database?", "DELETE", "CANCEL"))
                    {
                        qualityDatabase.Remove(cnt);
                    }
                }
                GUILayout.EndVertical();
                GUILayout.EndHorizontal();
            }
        }

    }
}
