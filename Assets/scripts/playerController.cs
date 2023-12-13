using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
   public float vInput; 
   public float hInput; 
   public float speed = 6; 
   public CharacterController  player;
   public int score;
   private AudioSource playerAudio;
   public AudioClip BadSound; 
   public AudioClip GoodSound;


  
   
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
     
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal"); 
        vInput = Input.GetAxisRaw("Vertical");
       
        Vector3 direction = new Vector3(hInput, 0f, vInput).normalized;
        player.Move(direction.normalized * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("good item"))
       {
          Debug.Log("yippe");
          playerAudio.PlayOneShot(GoodSound, 1.0f);
       }
       
       else if (other.gameObject.CompareTag("boom"))
       {
         Debug.Log("aw man");
         playerAudio.PlayOneShot(BadSound, 1.0f); 
       }
    }
    
}
