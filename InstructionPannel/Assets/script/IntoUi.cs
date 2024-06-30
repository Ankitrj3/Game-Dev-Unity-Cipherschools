using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoUi : MonoBehaviour
{
    public GameObject instructionPannel;
    public void ToggleInstructionPannel(string toggle)
    {
        if(toggle == "false")
        {
            instructionPannel.SetActive(false);
        }
        else if(toggle == "true")
        {
            instructionPannel.SetActive(true);
        }
    }
}
