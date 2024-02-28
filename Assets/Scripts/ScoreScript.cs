using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{

    public TMP_Text og_score;
    public Image og_image;
    public TMP_Text og_time;
    public TMP_Text cb_score;
    public Image cb_image;
    public TMP_Text cb_time;
    public Sprite o_i;
    public Sprite c_i;

    void Start()
    {
        //score_end[scene.name] = -1;
        //time_end[scene.name] = "Time";
        displayScore();
    }

    public void homeBtn()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void displayScore()
    {

        
        List<string> keys = new List<string>(ColorblindnessPortionManager.score_end.Keys);
        og_score.text = "Score: " + ColorblindnessPortionManager.score_end["Colorblind Portion Scene"].ToString();
        og_time.text = "Time: " + TimerScript.time_end["Colorblind Portion Scene"];
        og_image.sprite = o_i;

        cb_score.text = "Score: " + ColorblindnessPortionManager.score_end["Color Blind Scene 2"].ToString();
        cb_time.text = "Time: " + TimerScript.time_end["Color Blind Scene 2"];
        cb_image.sprite = c_i;

    }
}
