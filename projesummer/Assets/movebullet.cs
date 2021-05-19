using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebullet : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 direction = new Vector2();
    public float firespeed;
    public Vector3 trans;
    bool canrun = false;
    void Start()
    {
        
    }
    public void setdif(Vector3 diff)
    {
      
        trans = diff;

        canrun = true;
        //GetComponent<Rigidbody2D>().velocity = (new Vector2(trans.x, trans.y)) ;*/
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (trans != null)
        {
           
        }
           
    }
    void Update()
    {
        if (trans.y < 2f || trans.y < 0.5f)
        {
            if (canrun)
            {

                GetComponent<Rigidbody2D>().velocity = (new Vector2(trans.x, trans.y))*firespeed;
            }
        }
        else
        {
            if (canrun)
            {

                GetComponent<Rigidbody2D>().velocity = (new Vector2(trans.x, trans.y));
            }

        }


    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Destroy(gameObject);
    }
}
