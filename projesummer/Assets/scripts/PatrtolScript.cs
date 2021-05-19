using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrtolScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    //public Transform movespots;
    Vector2 spawn;
   // private Transform randomspot;

     float waittime;
    public float startwaittime;
    public float minx, miny;
    public float maxx, maxy;
    void Start()
    {
        waittime = startwaittime;
        // movespots.position = new Vector2();
        spawn = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
    }

    // Update is called once per frame
    void Update()
    {
      transform.position=  Vector2.MoveTowards(transform.position, spawn, speed * Time.deltaTime);
       // Vector2.MoveTowards(transform.position, 0, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, spawn) < 0.2f)
        {
            if (waittime <= 0)
            {
              //  movespots.position = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
                spawn = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
                waittime = startwaittime;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
    }
}
