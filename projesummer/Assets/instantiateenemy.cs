using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateenemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float randx;
    public Vector2 wheretospawn;
    public float spawnate = 10f;
    public float nextspawn = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextspawn)
        {
            nextspawn = Time.time + spawnate;
            randx = Random.Range(-9.37f, 9.02f);
            float randy = Random.Range(-1f, 4.26f);
            wheretospawn = new Vector2(randx, randy);
            GameObject gm = Instantiate(enemy, wheretospawn, Quaternion.identity);

        }
    }


   
}
