using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Play()
    {
       
        SceneManager.LoadScene("Main");
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void retry1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void retry2()
    {
        SceneManager.LoadScene("Bedroom");
    }

    public void GoCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
