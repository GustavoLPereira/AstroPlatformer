using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Scene");
    }

    public void SairOver()
    {
        Debug.Log("Sair");
        Application.Quit();
    }
}
