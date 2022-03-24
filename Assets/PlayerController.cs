using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] float torque;
    SurfaceEffector2D surfaceEffector;
    [SerializeField] float speedUp = 16f;
    [SerializeField] float normalSpeed = 13f;
    bool canMove = true; 

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>(); 
    }
    private void Update()
    {
      
      if(canMove)
        {
   RotatePlayer();
      
            SpeedUp(); 
        }
            
    }
    public void DisableControl()
    {
        canMove = false; 
    }
    void RotatePlayer()
    {  
        if( Input.GetKey( KeyCode.D))
        rb.AddTorque(-torque);
        else if ( Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torque); 
        }
    }
    void SpeedUp()
    {
        if( Input.GetKey(KeyCode.W))
        {
            // speed up 
            surfaceEffector.speed = speedUp; 
        }
        else
        {
            surfaceEffector.speed = normalSpeed; 
        }
    }


}