using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterSound : MonoBehaviour
{
    PlyarerMovement player;
    AudioSource audio;
    [SerializeField] public float time = 120;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        player = GameObject.Find("player").GetComponent<PlyarerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (player.walking == false)
        //{
            playerStands();
        //}
    }

    void playerStands()
    {
        time -= Time.deltaTime;
        if (time <= 0f)
        {
            timeEnded();
        }
    }
    
    void timeEnded()
    {
        SceneManager.LoadScene(2);
    }

}
