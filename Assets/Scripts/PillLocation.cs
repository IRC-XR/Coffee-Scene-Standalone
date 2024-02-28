using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillLocation : MonoBehaviour
{

    //https://www.youtube.com/watch?v=IbiwNnOv5So
    //https://answers.unity.com/questions/292745/how-do-i-create-instatiate-an-array-of-gameobjects.html
    public GameObject[] pill = new GameObject[12];


    // Start is called before the first frame update
    public void StartPills()
    {
        //transform.position = new Vector3(0.3036035f, 0.7888f, -0.3003334f);

        //transform.position = new Vector3(Random.Range(0.2582702f, 0.665f), 0.7888f, Random.Range(-0.3003334f, -0.008333355f));
        //Instantiate(pill, randomSpawn, Quaternion.identity);

        for (int x = 0; x < pill.Length; x++)
        {
            //bool Placed = false;
            //int Count = 0;
            //while (!Placed)
            //{
            //    PositionToPlace.x = Random.Range(0.2582702f, 0.665f);
            //    PositionToPlace.y = 0.7888f;
            //    PositionToPlace.z = Random.Range(-0.3003334f, -0.008333355f);
            //}
            //pill[x].transform.position = PositionToPlace;
            //Instantiate(pill[x], randomSpawn, Quaternion.identity);
            //pill[x].SetActive(true);

            pill[x].transform.position = new Vector3(Random.Range(0.2582702f, 0.665f), 0.7888f, Random.Range(-0.3003334f, -0.008333355f));
            pill[x].SetActive(true);
            Instantiate(pill[x], pill[x].transform.position, Quaternion.identity);
            Debug.Log("postition of " + pill[x] + " is: " + pill[x].transform.position);
        }

    }



}
