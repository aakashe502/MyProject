using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public  Text myscore;
    public static int scor;
    private void Start()
    {
        scor= 0;
        myscore.text = "0";
    }
    private void Update()
    {
        myscore.text = scor.ToString();
    }
}
