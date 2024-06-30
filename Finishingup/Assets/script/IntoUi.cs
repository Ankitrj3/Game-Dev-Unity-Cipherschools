using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoUi : MonoBehaviour
{
    public GameObject instructionPannel;

    public void ToggleInstructionPannel(string toggle)
    {
        if (toggle == "false")
        {
            instructionPannel.SetActive(false);
        }
        else if (toggle == "true")
        {
            instructionPannel.SetActive(true);
        }
    }

    public void ChangeCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int nextIndex = currentScene.buildIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            Debug.LogWarning("This is the last scene in the build settings.");
            // Optionally, handle what happens when there are no more scenes.
        }
    }
}
