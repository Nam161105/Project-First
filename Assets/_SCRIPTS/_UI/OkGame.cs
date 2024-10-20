using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OkGame : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Game");
    }
}
