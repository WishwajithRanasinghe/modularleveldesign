using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("Main Level");
    }
    public void Exit()
    {
    
        Debug.Log("Exit");
        
    }
}
