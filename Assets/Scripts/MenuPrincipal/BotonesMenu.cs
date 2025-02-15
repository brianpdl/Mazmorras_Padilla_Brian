using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void StartLevel(string Level)
    {
        SceneManager.LoadScene(Level);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Game.");
    }
}
