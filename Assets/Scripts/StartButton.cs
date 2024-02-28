using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Oculus.Interaction.Surfaces;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;


namespace Oculus.Interaction
{
    public class StartButton : MonoBehaviour
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private GameObject table;
        //[SerializeField] private GameObject main_canvas;

        // Start is called before the first frame update
        //  void Start()
        // {
        //     GetComponent<Button>().onClick.AddListener(BeginColorblindnessSection);
        //  }

        public void BeginColorblindnessSection()
        {
            // script1 = GameObject.Find("CBCanvas").GetComponent<RayInteractable>();
            //script1.enabled = false;
            Time.timeScale = 1;
            canvas.enabled = false;
            // main_canvas.SetActive(false);
            table.SetActive(true);
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name.Contains("2")) { 
                GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(6);
            }
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().ActivateColorblindnessFilter();
        }

        public void EndColorBlindnessSection()
        {
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(0);
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().ActivateColorblindnessFilter();
        }
    }
}
