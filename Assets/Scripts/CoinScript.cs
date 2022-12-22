using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 10f;
    [SerializeField]
    private Vector3 _rotate;
    private void Start()
    {
        
    }

    
    private void Update()
    {

       //this.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,transform.localEulerAngles.z + _rotationSpeed);
       this.transform.Rotate(_rotate * _rotationSpeed * Time.deltaTime);
    }// Update
}