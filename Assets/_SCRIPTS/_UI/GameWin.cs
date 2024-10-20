using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    protected void LoadMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
