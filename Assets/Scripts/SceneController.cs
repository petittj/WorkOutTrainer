using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void Gym()
    {
        SceneManager.LoadScene("Gym");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Exit");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
