using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoffeeScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    private double points = 0;
    [SerializeField] private string coffeeIngredientsTag;
    List<Collider> collided = new List<Collider>();
    ArrayList already_added = new ArrayList();
    public TMP_Text score;
    public GameObject cof;
    //public FinalScoreRAScript final;

    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED!");
        if (!collided.Contains(other))
        {
            collided.Add(other);
            if (other.gameObject.CompareTag(coffeeIngredientsTag))
            {
                if (other.name.Contains("Sugar") && !already_added.Contains("Sugar"))
                {
                    Debug.Log("Sugar addeded");
                    already_added.Add("Sugar");
                    addPoints();
                    cof.transform.position = new Vector3(cof.transform.position.x, cof.transform.position.y + 0.015f, cof.transform.position.z);
                    Debug.Log("Sugar " + points);
                    displayScore();
                }
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

    public string getTag()
    {
        return coffeeIngredientsTag;
    }
/*    void OnCollisionEnter(GameObject other)
    {
        Debug.Log("PARTICLES COLLIDED");
        if (!already_added.Contains(other))
        {
            if (other.gameObject.CompareTag(coffeeIngredientsTag))
            {
                Debug.Log("Bye");
                if (other.name.Contains("Milk"))
                {
                    already_added.Add("Milk");
                    points = points + 25;
                    cof.transform.position = new Vector3(transform.position.x, transform.position.y + 0.015f, transform.position.z);
                    Debug.Log("Milk " + points);
                }
                if (other.name.Contains("Coffee"))
                {
                    already_added.Add("Coffee");
                    points = points + 25;
                    cof.transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
                    Debug.Log("Coffee " + points);

                }
            }
        }
    }*/

}
