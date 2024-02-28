using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PillSortingRAScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] pills = new GameObject[9];
    [SerializeField] string topName;
    public GameObject top;
    bool opened;
    private double points = 0;
    public TMP_Text score;
    //public FinalScoreRAScript final;

    void Start()
    {
        opened = false;
        points = 0;
    }

    // Update is called once per frame
    //https://answers.unity.com/questions/1575010/how-to-set-game-objects-with-same-tag-to-not-activ.html
    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 45f && opened == true)
        {
            foreach (GameObject p in pills)
            {
                p.SetActive(true);
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == topName)
        {
            Debug.Log("Collision Broken: " + collision.gameObject.name);
            opened = true;
            top.transform.parent = null;
            addPoints();
            displayScore();
           // top.SetActive(false);
            //gameObject.GetComponent<FixedJoint>().connectedBody = collision.gameObject.rigidbody;
            //jointCreated = true;
            //}
        }
    }

    public void addPoints()
    {
        points = points + 10;
        FinalScoreRAScript.score_end[SceneManager.GetActiveScene().name] = System.Math.Floor(points);
    }

    public void displayScore()
    {
        score.text = "Score: " + System.Math.Floor(points);
    }


}
