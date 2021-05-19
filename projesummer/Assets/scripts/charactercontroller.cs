using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    float movespeed = 10;
    private Rigidbody2D rigidbody;
     float jumpforce = 6;
    bool canjump = true;
    void Start()
    {
        rigidbody = GetComponent < Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime*movespeed;
        if (Input.GetButtonDown("Jump")&&canjump==true)
        {
            rigidbody.AddForce(new Vector2(0, jumpforce),ForceMode2D.Impulse);


        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if(collision.gameObject.tag== "platform")
        canjump = false;  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    { if(collision.gameObject.tag== "platform")
        {
            canjump = true;
        }
        
    }
}
