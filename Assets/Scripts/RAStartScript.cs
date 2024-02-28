using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Oculus.Interaction.Surfaces;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;


namespace Oculus.Interaction
{
    public class RAStartScript : MonoBehaviour
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private GameObject table;
        //[SerializeField] private GameObject main_canvas;

        // Start is called before the first frame update
        //  void Start()
        // {
        //     GetComponent<Button>().onClick.AddListener(BeginColorblindnessSection);
        //  }

        public void startSection()
        {
            // script1 = GameObject.Find("CBCanvas").GetComponent<RayInteractable>();
            //script1.enabled = false;
            Time.timeScale = 1;
            canvas.enabled = false;
            // main_canvas.SetActive(false);
            if (table != null)
            {
                table.SetActive(true);
            }
            Scene scene = SceneManager.GetActiveScene();
        }
    }
}
