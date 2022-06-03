using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    float topBound = 30.0f;
    public float lowerBound = -10.0f;
    // public GameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        Destroy(gameObject);
        else if(transform.position.z<lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!"); 
        }
    }
}
