using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction.Surfaces;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


namespace Oculus.Interaction
{
    public class PauseMenuScript : MonoBehaviour
    {

        //https://www.youtube.com/watch?v=raAkiG3H8WY
        //https://www.youtube.com/watch?v=x-C95TuQtf0
        //https://answers.unity.com/questions/847122/stop-and-pause-timer.html

        public GameObject gamePausedMenu;
        public GameObject quitMenu;
        public bool pauseMenuActive = false;
        public bool quitMenuActive = false;
        public GameObject pauseCanvas;
        public Canvas subCanvas;
        [SerializeField] private RayInteractable script;
        public bool raycastSet = false;
        public static IDictionary<string, int> score_end = new Dictionary<string, int>();


        //void Start()
        //{
        //    //subCanvas.transform.localScale = new Vector3(0, 0, 0);
        //}

        public void pauseGameBtn()
        {
            Time.timeScale = 0;
            if (raycastSet == false)
            {
                toggleRaycast();
            }

            if (quitMenuActive == true)
            {
                quitMenu.SetActive(false);
                quitMenuActive = false;
            }
            subCanvas.enabled = true;
            gamePausedMenu.SetActive(true);
            pauseCanvas.SetActive(true);
            pauseMenuActive = true;
        }

  
        public void cancelPauseMenuBtn()
        {
            pauseMenuActive = false;
            gamePausedMenu.SetActive(false);
            subCanvas.enabled = false;
            Time.timeScale = 1;
        }

        public void helpBtn()
        {
            pauseMenuActive = false;
            gamePausedMenu.SetActive(false);
            subCanvas.enabled = false;
            MainMenuScript.previousScenes.Insert(0, SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("TutorialScene");
        }

        public void quitBtn()
        {
            Time.timeScale = 0;

            if (raycastSet == false)
            {
                toggleRaycast();
            }

            if (pauseMenuActive == true)
            {
                gamePausedMenu.SetActive(false);
                pauseMenuActive = false;
            }
            pauseCanvas.SetActive(true);
            subCanvas.enabled = true;
            quitMenuActive = true;
            quitMenu.SetActive(true);

        }

        public void leaveGameBtn()
        {
            quitMenu.SetActive(false);
            quitMenuActive = false;
            SceneManager.LoadScene("MainMenuScene");
        }

        public void continueGameBtn()
        {
            if (raycastSet == true)
            {
                toggleRaycast();
            }
            if (quitMenuActive == true)
            {
                quitMenu.SetActive(false);
                quitMenuActive = false;
            }
            else if (pauseMenuActive == true)
            {
                gamePausedMenu.SetActive(false);
                pauseMenuActive = false;
            }
            subCanvas.enabled = false;
            Time.timeScale = 1;
        }

        public void toggleRaycast()
        {
            script = GameObject.Find("PauseMenuCanvas").GetComponent<RayInteractable>();
            if (raycastSet == false)
            {
                script.enabled = true;
                raycastSet = true;
            }
            else
            {
                script.enabled = false;
                raycastSet = false;
            }

        }

        public void doneBtn()
        {
            //works if built carefully but has caused issues e.g. when building out with both sides of the application present. Scenes often progress to the wrong scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}


//public void controllerSwitchBtn()
//{
//    gamePausedMenu.SetActive(false);
//    pauseMenuActive = false;
//    controllerMenuActive = true;
//    controllerMenu.SetActive(true);

//}

//public void cancelControllerBtn()
//{
//    controllerMenu.SetActive(false);
//    controllerMenuActive = false;
//    gamePausedMenu.SetActive(true);
//}