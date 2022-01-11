using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollsion : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            
            //rb.isKinematic = true;
            rb.gravityScale = 0;
        }
    }
    
}
