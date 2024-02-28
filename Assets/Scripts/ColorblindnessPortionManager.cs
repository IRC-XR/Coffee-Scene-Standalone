using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ColorblindnessPortionManager : MonoBehaviour
{
    private int pillsRemaining = 12;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject[] boxes;
    [SerializeField] public int pillsCorrectlySorted = 0;
    public static IDictionary<string, int> score_end = new Dictionary<string, int>();
    public static Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "";
        scene = SceneManager.GetActiveScene();
        score_end[scene.name] = -1;
        pillsCorrectlySorted = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void decrementPillCount()
    {
        pillsRemaining--;
        if (pillsRemaining == 0)
        {
            displayScore();
            Time.timeScale = 0;
        }
    }

    public void displayScore()
    {
        //int pillsCorrectlySorted = 0;
        MeshRenderer m_score = scoreText.GetComponent<MeshRenderer>();
        for (int i = 0; i < boxes.Length; i++)
        {
            pillsCorrectlySorted += boxes[i].GetComponent<Box>().getNumberOfCorrectPillsReceived();
        }
        scoreText.text = "Number of pills correctly sorted: " + pillsCorrectlySorted.ToString() + " / 12";
        m_score.enabled = true;
        if (score_end[scene.name] == -1)
        {
            score_end[scene.name] = pillsCorrectlySorted;
        }
    }
}
