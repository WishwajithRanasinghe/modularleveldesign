using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    [SerializeField]
    private Text _timeText;   
    [SerializeField] 

  
    private int _timeCount = 180;
    
    private void Start()
    {
       
        StartCoroutine(TimeRoutines());
    }

  
    private void Update()
    {
        if(_timeCount == 0)
        {
            _timeCount = 0;
            SceneManager.LoadScene("Main Level");

        }
        

        _timeText.text = "Time = " + _timeCount.ToString();
        

        
    }// Update
    
    private IEnumerator TimeRoutines()
    {
        for (int i = 180; i > 0; i--)
        {
            _timeCount --;

            yield return new WaitForSeconds(0.9f);

            
        }
    }
}
