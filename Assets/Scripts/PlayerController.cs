using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f; 
    public float xrange = 10;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //the if statements keep track of bound of player along x-axis
        if(transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange,transform.position.y, transform.position.z);
        }
        if(transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange,transform.position.y, transform.position.z);
        }

        //takes input from user regarding x direction
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile
            Instantiate(projectilePrefab, transform.position,projectilePrefab.transform.rotation);
        }
    }
}
