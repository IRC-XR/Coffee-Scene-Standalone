using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour

{

    public static List<string> previousScenes = new List<string>();
    public GameObject disorderMenu;
    public GameObject userMenu;
    public GameObject mainMenu;
    public bool mainmenuActive = true;
    public bool disorderMenuActive = false;
    public bool userMenuActive = false;
    [SerializeField] private Button studentbtn = null;
    [SerializeField] private Button patientbtn = null;
    [SerializeField] private Button rabtn = null;
    [SerializeField] private Button cbbtn = null;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void userTypeMenu()
    {

        mainMenu.SetActive(false);
        mainmenuActive = false;
        userMenuActive = true;
        userMenu.SetActive(true);
        studentbtn.onClick.AddListener(delegate { disorderTypeMenu("Student"); });
        patientbtn.onClick.AddListener(delegate { disorderTypeMenu("Patient"); });

    }

    public void disorderTypeMenu(string userType)
    {

        userMenuActive = false;
        userMenu.SetActive(false);
        disorderMenuActive = true;
        disorderMenu.SetActive(true);
        rabtn.onClick.AddListener(delegate { getStarted("RA"); });
        cbbtn.onClick.AddListener(delegate { getStarted("CB"); });

    }



    public void AboutDisorders()
    {
        //    MainMenuPanel.Visible = false;
        //   WhichDisorderPanel.Visible = true;

        previousScenes.Insert(0, SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("AboutDisordersScene");
    }

    public void Tutorial()
    {
        previousScenes.Insert(0, SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("TutorialScene");
    }


    public void getStarted(string disorderType)
    {
        if (disorderType == "RA") {
            previousScenes.Insert(0, SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("MorningHygiene");
        }
        else if (disorderType == "CB")
        {
            previousScenes.Insert(0, SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Colorblind Portion Scene");
        }
    }

}
