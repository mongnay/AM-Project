using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Simulation : MonoBehaviour
{
    public void Pause()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
}