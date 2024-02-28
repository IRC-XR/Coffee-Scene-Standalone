using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMovement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=OBnCd1bzCcw
    public GameObject liquidMesh;

    private int sloshSpeed = 60;
    private int rotateSpeed = 15;

    private int difference = 25;

    void Update()
    {

        liquidMesh.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.Self);
    }
}
