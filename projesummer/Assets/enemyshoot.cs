using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    // Start is called before the first frame update
   
    public  float waituptotime;
    public float fisrttime;
    public GameObject bullet;
    public float bulletspeed;
   
   

    void Start()
    {
      
        waituptotime = fisrttime;
    }

    // Update is called once per frame
    void Update()
    {


        if (waituptotime <= 0)
        {
          
          
            GameObject g = GameObject.FindGameObjectWithTag("playermainpos");

            if (g != null)
            {
                GameObject bul = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
                Debug.Log("instantiated= " + bul.transform);


                Vector2 trii = (g.transform.position - transform.position);


                Debug.DrawLine(transform.position, g.transform.position);


                waituptotime = fisrttime;
            }

           
        }
        else
        {
            waituptotime -= Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
       /* if (bul != null && trii != null)
        {
           // bul.GetComponent<Rigidbody2D>().velocity = new Vector2(trii.x,trii.y);
        }*/
    }
}
