using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public float bottomBound = 1; 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomBound)
        {
           Destroy(gameObject); // destorys prefabs
        }
    }
}
