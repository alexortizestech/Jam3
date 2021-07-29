using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public CharacterController cc;
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        cc.destiny = cc.current;
        cc.enabled = false;
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {

        cc.destiny = cc.current;
        cc.enabled = true;
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
