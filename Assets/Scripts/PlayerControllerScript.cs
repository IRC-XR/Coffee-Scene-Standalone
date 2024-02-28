using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{

    //https://www.youtube.com/watch?v=EmjBonbATS0

    [SerializeField] Transform playerReset;
    [SerializeField] GameObject player;
    [SerializeField] Camera playerHead;

    public void resetPosition()
    {
        var rotationY = playerHead.transform.rotation.eulerAngles.y - playerReset.rotation.eulerAngles.y;
        player.transform.Rotate(0, rotationY, 0);


        var dist = playerReset.position - playerHead.transform.position;

        player.transform.position = player.transform.position + dist;

    }
}
