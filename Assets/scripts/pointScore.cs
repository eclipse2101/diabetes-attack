using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointScore : MonoBehaviour
{
  public bool badItem; 
  public int goodScore = 1;
  public int badScore = -1; 

    
    void OnTriggerEnter(Collider other)
    {
        if(badItem == true)
        {
           playerController pc = other.GetComponent<playerController>();
           pc.score += badScore;
           Debug.Log(pc.score);
        }
        else
        {
            playerController pc = other.GetComponent<playerController>(); 
            pc.score += goodScore;
            Debug.Log(pc.score); 
        }
    }
}
