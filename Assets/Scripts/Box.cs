using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private string tagToAccept;
    private int numberOfCorrectPillsReceived = 0;
    private GameObject colorblindnessPortionManager;
    List<Collider> collided = new List<Collider>();

    // Start is called before the first frame update
    void Start()
    {
        colorblindnessPortionManager = GameObject.Find("Colorblindness Portion Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!collided.Contains(other))
        {
            collided.Add(other);
            if (other.gameObject.CompareTag(tagToAccept))
            {
                numberOfCorrectPillsReceived++;
            }
            if (other.name.Contains("Pill"))
            {
                colorblindnessPortionManager.GetComponent<ColorblindnessPortionManager>().decrementPillCount();
            }
        }
    }

    public int getNumberOfCorrectPillsReceived()
    {
        return numberOfCorrectPillsReceived;
    }
}
