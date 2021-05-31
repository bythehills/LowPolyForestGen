using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject cam;
    
    public void goToGame()
    {
        EditorSceneManager.LoadScene("Main"); //loads main scene
    }

    public void optionSummer()
    {
        PlayerPrefs.SetString("Theme", "Summer"); //playerprefs stores input across scenes
    }

    public void optionFall()
    {
        PlayerPrefs.SetString("Theme", "Fall");

    }
    public void reloadScene()
    {
        EditorSceneManager.LoadScene("Main"); 
    }

    public void quitScene()
    {
        EditorSceneManager.LoadScene("StartScreen");
    }
}
