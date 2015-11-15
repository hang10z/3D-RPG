using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Rpg.ItemSystem.Editor
{

    public partial class ISQualityDatabaseEditor : EditorWindow     //Database Editor Class Broken up into several scripts
    {
        

        ISQualityDatabase qualityDatabase;
//        ISQuality selectedItem;
        Texture2D selectedTexture;
        int selectedIndex = -1;

        Vector2 _scrollPos;                     //scroll position for listview
        const int SPRITE_BUTTON_SIZE = 46;

        //Create Path and database name
        const string DATABASE_FILE_NAME = @"rpgQualityDatabase.asset";
        const string DATABASE_FOLDER_NAME = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE_NAME;
        


        //Setup the menu shortcuts
        [MenuItem("RPG/Database/Quality Editor %#i")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.titleContent.text = "Quality Database ";
            window.Show();
        }

        void OnEnable()
        {
            qualityDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;
            if (qualityDatabase == null)
            {
                if(!AssetDatabase.IsValidFolder("Assets/" + DATABASE_FOLDER_NAME))
                    AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);

                qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
                AssetDatabase.CreateAsset(qualityDatabase, DATABASE_FULL_PATH);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

//           selectedItem = new ISQuality();
        }



        void OnGUI()
        {
            ListView();
            //AddQualityToDatabase();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }

        void BottomBar()
        {
            //Count
            GUILayout.Label("Qualities: " + qualityDatabase.Count);

            //Add Button
            if (GUILayout.Button("ADD"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }

       /* void AddQualityToDatabase()
        {
            selectedItem.Name = EditorGUILayout.TextField("Name: ", selectedItem.Name);
            if (selectedItem.Icon)
                selectedTexture = selectedItem.Icon.texture;
            else
                selectedTexture = null;

            if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
                {
                int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
                }
            string commandName = Event.current.commandName;
            if(commandName == "ObjectSelectorUpdated")
                {
                selectedItem.Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                Repaint();
                }
            if (GUILayout.Button("Save"))
            {
                if (selectedItem == null)
                    return;

                if (selectedItem.Name == "")
                    return;

                qualityDatabase.Add(selectedItem);

                selectedItem = new ISQuality();
            }

        } */
    }
}
