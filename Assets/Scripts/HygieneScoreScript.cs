using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Timers;
using UnityEngine.SceneManagement;

public class HygieneScoreScript : MonoBehaviour
{
    private double points = 0;
    public TMP_Text score;
    List<Collider> collided = new List<Collider>();
    ArrayList already_added = new ArrayList();
    [SerializeField] private string toothbrushTag;
    //public GameObject tb;
    public GameObject tp;
    float timeToBrush = 0.0f;
    bool doneBrushing = false;
    //public FinalScoreRAScript final;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
       // final = new FinalScoreRAScript();

    }

    // Update is called once per frame
    void Update()
    {
        if(tp.active == true)
        {
            timeToBrush += Time.deltaTime;
            int seconds = (int)timeToBrush % 60;
            if(seconds == 10)
            {
                BrushingTeeth();
            }
        }
    }

    public void addPoints()
    {
        points = points + 33.34;
        FinalScoreRAScript.score_end[SceneManager.GetActiveScene().name] = System.Math.Floor(points);
    }

    public void displayScore()
    {
        score.text = "Score: " + System.Math.Floor(points);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!collided.Contains(other))
        {
            collided.Add(other);
            if (other.gameObject.CompareTag(toothbrushTag))
            {
                if (other.name.Contains("Toothbrush") && !already_added.Contains("Toothbrush"))
                {
                    already_added.Add("Toothbrush");
                    tp.SetActive(true);
                    addPoints();
                    displayScore();
                    //BrushingTeeth();
                }
            }
        }
    }
    void BrushingTeeth()
    {
        tp.SetActive(false);
        addPoints();
        displayScore();
    }


}
