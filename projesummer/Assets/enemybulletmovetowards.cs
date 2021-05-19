using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulletmovetowards : MonoBehaviour
{
    // Start is called before the first frame update
    Transform gs;
    public float speed;
    Vector2 difft;
    void Start()
    {
        if (GameObject.Find("mainplayer") != null)
        {
            gs = GameObject.Find("mainplayer").transform;

            difft = gs.position - gameObject.transform.position;

        }




    }

    // Update is called once per frame
    void Update()
    {
        if(gs!=null)
        GetComponent<Rigidbody2D>().velocity = (new Vector2(difft.x, difft.y))*speed;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {

        }
        else
        Destroy(gameObject);
    }
}
