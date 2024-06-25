using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoMenu : MonoBehaviour
{
    public static bool photoMenuUp = false;

    public GameObject photoMenuUI;
    PlyarerMovement player;


  
    void Start()
    {
        photoMenuUI.SetActive(false);
        player = GameObject.Find("player").GetComponent<PlyarerMovement>();


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pullDown();
        }
    }
    public void pullUp()
    {
        player.walking = true;
        photoMenuUI.SetActive(true);
        photoMenuUp = true;
        
    }

    void pullDown()
    {
        player.walking = false;
        photoMenuUI.SetActive(false);
        photoMenuUp = false;
        
       

    }
}

