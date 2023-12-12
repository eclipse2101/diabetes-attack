using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointScore : MonoBehaviour
{
  public bool badItem; 
  public int goodScore = 1;
  public int badScore = -1; 
  ScoreDisplay scoreDisplay;
   private AudioSource playerAudio;

   public AudioClip BadSound; 
   public AudioClip GoodSound;

  void Awake()
  {
    scoreDisplay = GameObject.Find("Canvas").GetComponent<ScoreDisplay>();
  }

   void Start()
    {
      playerAudio = GetComponent<AudioSource>();
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
           playerAudio.PlayOneShot(BadSound, 1.0f);
        }
        else
        {
            playerController pc = other.GetComponent<playerController>(); 
            pc.score += goodScore;
            scoreDisplay.DisplayScore(pc.score.ToString());
             Destroy(gameObject);
            Debug.Log(pc.score);
            playerAudio.PlayOneShot(GoodSound, 1.0f); 
        }
    }
}
