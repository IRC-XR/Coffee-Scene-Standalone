using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScoreRAScript : MonoBehaviour
{
    public TMP_Text hygience_score;
    public Image hygeiene_image;
    public TMP_Text hygiene_time;
    public TMP_Text ps_score;
    public Image ps_image;
    public TMP_Text ps_time;
    public TMP_Text coffee_score;
    public Image coffee_image;
    public TMP_Text coffee_time;
    public Sprite h_i;
    public Sprite ps_i;
    public Sprite c_i;
    public static IDictionary<string, double> score_end = new Dictionary<string, double>();
   

    // Start is called before the first frame update
    void Start()
    {
        displayScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void homeBtn()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void displayScore()
    {


        //List<string> keys = new List<string>(ColorblindnessPortionManager.score_end.Keys);
        hygience_score.text = "Score: " + score_end["MorningHygiene"].ToString();
        hygiene_time.text = "Time: " + TimerScript.time_end["MorningHygiene"];
        hygeiene_image.sprite = h_i;

        ps_score.text = "Score: " + score_end["PillSortingRA"].ToString();
        ps_time.text = "Time: " + TimerScript.time_end["PillSortingRA"];
        ps_image.sprite = ps_i;


        coffee_score.text = "Score: " + score_end["MakingCoffeeScene"].ToString();
        coffee_time.text = "Time: " + TimerScript.time_end["MakingCoffeeScene"];
        coffee_image.sprite = c_i;

    }
}
