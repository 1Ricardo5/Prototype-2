using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    public float forwardInput;
    public float zRange = 10;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // keep the player in bounds
      
      if (transform.position.x < -xRange){
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }
      
      if (transform.position.x > xRange)
      {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
      
      if (transform.position.z < -zRange){
        transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
      }
      
      if (transform.position.z > zRange)
      {
        transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
      }
    
      
      
      horizontalInput = Input.GetAxis("Horizontal");  
      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

      forwardInput = Input.GetAxis("Vertical");  
      transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
    
    
       
       if (Input.GetKeyDown(KeyCode.Space))
       {
         // Launch a projectile from the player 
         Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       
       }


    
    
    
    }

}
