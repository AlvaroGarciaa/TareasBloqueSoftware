/*code from the class wrote by the professor to move the spaceships in a wave motion */ 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Move an object horizontally in a wave pattern

public class WaveMove : MonoBehaviour
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
        transform.Translate(move *Time.deltaTime);
        // pos.x = pos.x + Mathf.Cos(angle) * amplitude;
        // transform.position = pos;
        // angle+= delta;
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        move = -move;
    }
}
