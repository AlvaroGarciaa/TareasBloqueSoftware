/* Alvaro Garcia A01781511
04/Marzo/2022
 Modification from the class code to win points or loose points, to update score and
 to terminate the game */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoints2 : MonoBehaviour
{
    [SerializeField] int points =0;
    public Text textElement;


    //Win points if the player gets to the objetive
   


    //Loose points if the player tocuhes a spaceship
    void OnTriggerEnter2D(Collider2D col)
    {
        // Destroy(col.gameObject);
        // points += 5;
        if(col.gameObject.tag == "Spaceship")
            points--;  
           
        
        if (col.gameObject.tag == "wall top")
            points++;
            
            
    }
//update score


    //if player is touches by an enemy, he looses. If he escapes, he wins
    void Update()

    {   
        if(points <0)
        {
            textElement.text = points.ToString() + " Points, You Loose!";
            //stop game if looses
            Time.timeScale = 0;
            
        }
            
            
        
        if(points > 0)
        {   
            //stop game if wins
            textElement.text = points.ToString() + " Point, You Win!";
            Time.timeScale = 0;
        }
            
        //Stop the game if you win or loose
        
        
    }
}