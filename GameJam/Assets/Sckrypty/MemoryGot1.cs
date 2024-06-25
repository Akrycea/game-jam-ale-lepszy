using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGot1 : MonoBehaviour
{
    public Collider2D playerCollider;
    public Collider2D memoryCollider;
    public bool gotem;
    photoMenu menu;

   

    private void Start()
    {
        playerCollider = GameObject.Find("player").GetComponent<Collider2D>();
        memoryCollider = GetComponent<Collider2D>();
        gameObject.SetActive(true);
        gotem = false;
        menu = GameObject.Find("PhotoMenu").GetComponent<photoMenu>();


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            gotem = true;
            itemGet();
            
        }
    }

    private void itemGet()
    {

        if (playerCollider.IsTouching(memoryCollider))
        {
            gotem = true;
            menu.pullUp();
            gameObject.SetActive(false);
            

        }
        

    }
}
