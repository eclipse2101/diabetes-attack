using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
   public float vInput; 
   public float hInput; 
   public float speed = 6; 
   public CharacterController  player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal"); 
        vInput = Input.GetAxisRaw("Vertical");
       
        Vector3 direction = new Vector3(hInput, 0f, vInput).normalized;
        player.Move(direction.normalized * speed * Time.deltaTime);
    }
}
