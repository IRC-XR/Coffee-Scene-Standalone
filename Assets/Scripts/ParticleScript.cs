using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParticleScript : MonoBehaviour
{

    private int points = 0;
    [SerializeField] private string coffeeIngredientsTag;
    List<Collider> collided = new List<Collider>();
    ArrayList already_added = new ArrayList();
    public TMP_Text score;
    public GameObject cof;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleTrigger()
    {
        Debug.Log("PARTICLES COLLIDED");
        ParticleSystem ps = GetComponent<ParticleSystem>();
        if (!already_added.Contains(ps.gameObject))
        {
            if (ps.gameObject.CompareTag(coffeeIngredientsTag))
            {
                Debug.Log("Bye");
                if (ps.gameObject.name.Contains("Milk"))
                {
                    already_added.Add("Milk");
                    points = points + 25;
                    cof.transform.position = new Vector3(transform.position.x, transform.position.y + 0.015f, transform.position.z);
                    Debug.Log("Milk " + points);
                }
                if (ps.gameObject.name.Contains("Coffee"))
                {
                    already_added.Add("Coffee");
                    points = points + 25;
                    cof.transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
                    Debug.Log("Coffee " + points);

                }
            }
        }
    }
}
