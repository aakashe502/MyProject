using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitdialog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadlevel()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void exitgame()
    {
        Application.Quit();
    }
}
