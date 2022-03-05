/*Alvaro Garcia A01781511
modified code from the class that enables the enemies to move to a different
direction in a wave motion*/ 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Move an object horizontally in a wave pattern

public class WaveMoveLeft : MonoBehaviour
{
  
    // Update is called once per frame
    [SerializeField] Vector3 move;
    // //con funciones matemáticas
    // [SerializeField]  Vector3 start;
    // [SerializeField]  float amplitude;
    // Vector3 pos;
    // float angle = 0.0f;
    
    
    // void Start()
    // {
    //     start = transform.position;
    // }
    void Update()

    {   
        // pos = start;
        transform.Translate(-move *Time.deltaTime);
        // pos.x = pos.x + Mathf.Cos(angle) * amplitude;
        // transform.position = pos;
        // angle+= delta;
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        move = -move;
    }
}
