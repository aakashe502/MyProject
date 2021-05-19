using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Vector3 offset;
    public float currenthealth = 10f;
    public float maxhealth = 10f;
    public Image imagefill;
    public GameObject exit;

   
    //public GameObject enemy;

    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        // txt = GameObject.Find("score").GetComponent<TMPro>();
        //tm = GameObject.Find("score").GetComponent<TMPro>();
        

        //  offset = new Vector3(2, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.position + offset);
        float fillvalue = currenthealth / maxhealth;
        slider.value = fillvalue;
        if (slider.value < slider.minValue)
        {
            imagefill.enabled = false;
        }
        if (slider.value != slider.minValue && !imagefill.enabled)
        {
            imagefill.enabled = true;
        }
        if (fillvalue < slider.maxValue / 3)
        {
            imagefill.color = Color.red;
        }
        if (currenthealth == 0)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            exit.SetActive(true);
            Time.timeScale = 0;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemybullet")
        {
            currenthealth--;
            Destroy(collision.gameObject);
        }
    }


}
