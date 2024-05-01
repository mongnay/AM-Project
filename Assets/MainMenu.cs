using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Simulation()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Explore()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Credit()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
