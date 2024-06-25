using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoryGot5 : MonoBehaviour
{
    public Collider2D playerCollider;
    public Collider2D memoryCollider;
    public bool gotem;
  



    private void Start()
    {
        playerCollider = GameObject.Find("player").GetComponent<Collider2D>();
        memoryCollider = GetComponent<Collider2D>();
        gameObject.SetActive(true);
        gotem = false;
    


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            itemGet();
        }
    }

    private void itemGet()
    {

        if (playerCollider.IsTouching(memoryCollider))
        {
            gotem = true;
            SceneManager.LoadScene(3);
            gameObject.SetActive(false);
            

        }
        

    }
}
