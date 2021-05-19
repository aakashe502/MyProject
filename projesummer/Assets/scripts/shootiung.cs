using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootiung : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gb;
    public GameObject bullet;
    public float bulletspeed ;
    //public GameObject reference;
    Vector2 lookdirection;
    float lookangle;
    public float offset;
    Vector3 tomove;
    GameObject bul;
    void Start()
    {
        //gb = GameObject.Find("mainplayer");
      //  bulletspeed = 9;
    }

    // Update is called once per frame
    void Update()
    {
        /* lookdirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
         lookangle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg;
         reference.transform.rotation = Quaternion.Euler(0, 0, lookangle);
         if (gb == null)
             return;

         if (Input.GetMouseButtonDown(0))
         {
             Debug.Log("working");
             Vector3 mousePos = Input.mousePosition;
             Vector2 dire =( mousePos - reference.transform.position);
             Debug.Log("direction= " + dire);
             GameObject bul = Instantiate(bullet) as GameObject;
             bul.transform.position = reference.transform.position;
             bul.transform.rotation = Quaternion.Euler(0.0f ,0.0f, lookangle);
             bul.GetComponent<Rigidbody2D>().velocity =dire* bulletspeed*Time.deltaTime;
         }*/

        
       // if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
        //{
           // transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunangle));
       // }
       // else
         //  transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunangle));
        if (Input.GetMouseButtonDown(0))
        {
           //Vector3 diff= Camera.main.WorldToScreenPoint(Input.mousePosition);
             bul= Instantiate(bullet,gb.transform.position,gb.transform.rotation) as GameObject;
            Vector3  difference= Camera.main.ScreenToWorldPoint(Input.mousePosition)-bul.transform.position;
            float rot = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            //  bul.transform.rotation = Quaternion.Euler(0f, 0f, rot + offse);
            //  bul.transform.position = transform.position;
            //Vector3 dir =gb.transform.position- transform.position; //new Vector2(mousepos.x, mousepos.y);
            //   bul.transform.rotation = Quaternion.Euler(0.0f, 0.0f, lookangle);
           
//movebullet mov = new movebullet();
           // Debug.Log("difference= " + difference);
            tomove = difference;
            //mov.trans = difference;
            movebullet moveit = bul.GetComponent<movebullet>();
            //moveit.trans = difference;
            moveit.setdif(difference);
            
          
          // bul.GetComponent<Rigidbody2D>().AddForce(difference * bulletspeed);
        }

    }
    private void FixedUpdate()
    {
        if (bul != null && tomove != null)
        {
           // bul.GetComponent<Rigidbody2D>().velocity = (new Vector2(tomove.x, tomove.y)) * bulletspeed;
        }
        //
    }
}
