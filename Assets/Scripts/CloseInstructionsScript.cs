using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CloseInstructionsScript : MonoBehaviour
{
    public TMP_Text instructions;



    public void closeInstructions()
    {
        instructions.enabled = false;
    }
}
