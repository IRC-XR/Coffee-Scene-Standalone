using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TutorialScript : MonoBehaviour
{
    public void Tutorial()
    {
        //    MainMenuPanel.Visible = false;
        //   WhichDisorderPanel.Visible = true;
        string prev = MainMenuScript.previousScenes[0];
        MainMenuScript.previousScenes.Insert(0, SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(prev);
    }
}
