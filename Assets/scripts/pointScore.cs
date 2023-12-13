using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointScore : MonoBehaviour
{
  public bool badItem; 
  public int goodScore = 1;
  public int badScore = -1; 
  ScoreDisplay scoreDisplay;


  void Awake()
  {
    scoreDisplay = GameObject.Find("Canvas").GetComponent<ScoreDisplay>();
  }

 
    void OnTriggerEnter(Collider other)
    {
        
        if(badItem == true)
        {
           playerController pc = other.GetComponent<playerController>();
           pc.score += badScore;
           scoreDisplay.DisplayScore(pc.score.ToString());
           Destroy(gameObject);
           Debug.Log(pc.score);
          
        }
        else
        {
            playerController pc = other.GetComponent<playerController>(); 
            pc.score += goodScore;
            scoreDisplay.DisplayScore(pc.score.ToString());
             Destroy(gameObject);
            Debug.Log(pc.score);
            
        }
    }
}
