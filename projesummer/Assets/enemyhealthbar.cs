using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class enemyhealthbar : MonoBehaviour
{
    // Start is called before the first frame update
    /* public float hitpoint;
     public float maxhealth=5;
     public HealthBarBehaviour health;
     void Start()
     {
         hitpoint = maxhealth;
         health.sethealth(hitpoint, maxhealth);
     }
     public void decresehealth()
     {
         hitpoint--;
       //  health.sethealth(hitpoint, maxhealth);

     }

     // Update is called once per frame
     void Update()
     {

     }
     private void OnTriggerEnter2D(Collider2D collision)
     {
         Debug.Log(collision.gameObject.name);
     }*/
    public Slider slider;
    public Vector3 offset;
    public float health1 = 5f;
    public float maxhealth = 5f;
    public Image imagefill;


    TextMeshProUGUI test;
    //public GameObject enemy;

    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        // txt = GameObject.Find("score").GetComponent<TMPro>();
        //tm = GameObject.Find("score").GetComponent<TMPro>();
        //test = GameObject.Find("score").GetComponent<TextMeshProUGUI>();
        
        //  offset = new Vector3(2, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.position + offset);
        float fillvalue = health1 / maxhealth;
        slider.value = fillvalue;
        if (slider.value < slider.minValue)
        {
            imagefill.enabled = true;
        }
        if (slider.value != slider.minValue && !imagefill.enabled)
        {
            imagefill.enabled = true;
        }
        if (fillvalue < slider.maxValue / 3)
        {
            imagefill.color = Color.red;
        }
        if (health1 == 0)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            score.scor += 1;
          
            

        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gm = GameObject.Find(collision.gameObject.name);
        if (collision.gameObject.tag == "bulletprefab")
        {
            health1=health1-1;
            Destroy(gm);
           
          
        }
    }
  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject gm = GameObject.Find(collision.gameObject.name);
        if (collision.gameObject.tag == "bulletprefab")
        {
            health1 = health1 - 1;
            Destroy(gm);
            PatrtolScript p = new PatrtolScript();
            //  Destroy(p.movespots);
        }
    }*/
}
