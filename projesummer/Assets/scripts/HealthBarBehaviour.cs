using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Color high, low;
    public Vector3 offset;
    void Start()
    {
        
        
    }
    public void sethealth(float health,float maxhealth)
    {
       // slider.
        //slider.value = health;
        //slider.maxValue = maxhealth;
        //slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
    }
    // Update is called once per frame
    void Update()
    {
        //slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }
}
