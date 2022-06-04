using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nav : MonoBehaviour
{
    // level 1
    public void playGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void playAgain()
    {
        SceneManager.LoadScene("Level1");
    }

}