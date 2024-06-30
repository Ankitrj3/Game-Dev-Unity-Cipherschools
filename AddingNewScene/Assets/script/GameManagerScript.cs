//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManagerScript : MonoBehaviour
//{
//    // Start is called before the first frame update
//    public static GameManagerScript instance;
//    public GameObject winPannel;
//    public GameObject losePannel;
//    public GameObject restartButton;
//    public void Awake()
//    {
//        if(instance == null)
//        {
//            instance = this;

//        }
//    }
//    public void GameOverScreen(bool hasWon)
//    {
//        if (hasWon) winPannel.SetActive(true);
//        else losePannel.SetActive(true);
//        restartButton.SetActive(true);
//    }
//    public void RestartGame()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // Singleton instance
    public static GameManagerScript instance;

    // UI Elements
    public GameObject winPannel;
    public GameObject losePannel;
    public GameObject restartButton;

    // Awake is called before the first frame update
    void Awake()
    {
        // Ensure only one instance of GameManagerScript exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Optional: Keep this GameManager across scenes
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Method to show the appropriate game over screen
    public void GameOverScreen(bool hasWon)
    {
        if (hasWon)
        {
            winPannel.SetActive(true);
        }
        else
        {
            losePannel.SetActive(true);
        }
        restartButton.SetActive(true);
    }

    // Method to restart the game
    public void RestartGame()
    {
        // Optionally hide the panels
        winPannel.SetActive(false);
        losePannel.SetActive(false);
        restartButton.SetActive(false);

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
