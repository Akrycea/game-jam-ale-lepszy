using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterSound : MonoBehaviour
{
    PlyarerMovement player;
    AudioSource audio;
    [Range(0, 120)]
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
        if (player.walking == false)
        {
            playerStands();
        }
        if (player.walking == true)
        {
            playerWalks();
        }
        audioVolume();
    }

    void playerStands()
    {
        time -= Time.deltaTime;
        if (time <= 0f)
        {
            timeEnded();
        }
    }

    void playerWalks()
    {
        time += Time.deltaTime;
        
    }
    
    void timeEnded()
    {
        SceneManager.LoadScene(2);
    }

    void audioVolume()
    {
        if (time > 100)
        {
            audio.volume = 0f;
        }
        if (time <= 100) {
            audio.volume = 0.1f;
        }
        if (time <= 80)
        {
            audio.volume = 0.3f;
        }
        if (time <= 50)
        {
            audio.volume = 0.5f;
        }
        if (time <= 20)
        {
            audio.volume = 0.7f;
        }
        if (time <= 10)
        {
            audio.volume = 1f;
        }
    }
}
