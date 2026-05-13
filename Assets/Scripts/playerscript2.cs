using UnityEngine;

public class Playersscript2 : MonoBehaviour
{
    public Rigidbody2D RB;

    public float Speed = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0,0);

        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
        }
     
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
        }
        
        RB.linearVelocity = vel;

        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = 2;
        }
        else if (Input.GetKey(KeyCode.CapsLock))
        {
            Speed = 10;
        }
        else
        {
            Speed = 5;
        }
       
    }

   

}