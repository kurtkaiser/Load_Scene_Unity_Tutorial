using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Need this
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        ListSceneNames();
    }

    public static void ListSceneNames()
    {
        string result = "";
        if (SceneManager.sceneCount > 0)
        {
            // Loops through all scene, uses sceneCount for this
            for (int n = 0; n < SceneManager.sceneCount; ++n)
            {
                // Gets the scene at index n
                Scene scene = SceneManager.GetSceneAt(n);
                result += scene.name;
                // Returns true if scene is loaded
                if (scene.isLoaded)
                {
                    result = result + " (Loaded, ";
                }
                else
                {
                    result = result + " (Not Loaded, ";
                }
                // Returns true if a scene has been modified
                if (scene.isDirty)
                {
                    result = result + "Dirty, ";
                }
                else
                {
                    result = result + "Clean, ";
                }
                // Returns the scene's index in build settings
                if (scene.buildIndex >= 0)
                {
                    result = result + " in build)\n";
                }
                else
                {
                    result = result + " NOT in build)\n";
                }
            }
        }
        else
        {
            result = "No open Scenes.";
        }
        Debug.Log("Scene Summary: " + result + " Ok");
    }

    void SceneByName()
    {
        SceneManager.GetSceneByName("Hello");
    }

    void SceneByPath()
    {
        SceneManager.GetSceneByPath("Assets/Scenes/MyScene.unity");
    }
}