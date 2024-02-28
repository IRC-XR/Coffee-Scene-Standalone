using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class TimerScript : MonoBehaviour
{

    //https://www.youtube.com/watch?v=x-C95TuQtf0
    //https://answers.unity.com/questions/847122/stop-and-pause-timer.html
    public TMP_Text timer;
    private float time;
    private bool paused;
    private bool done = false;

    public static IDictionary<string, string> time_end = new Dictionary<string, string>();
    public static Scene scene;

    void Start()
    {
        Time.timeScale = 0;
        time = Time.timeSinceLevelLoad;
        scene = SceneManager.GetActiveScene();
        time_end[scene.name] = "Time";
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        //Debug.Log("Time:" + time);
        string min = ((int)time / 60).ToString();
        string sec = (time % 60).ToString("f2"); // ("f");
        timer.text = min + ":" + sec;
        getTime();
    }

    public void getTime()
    {
        time_end[scene.name] = timer.text;
    }

}
