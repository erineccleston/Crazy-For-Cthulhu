using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public float restartDelay = 10;      //Restart level

    Animator anim;
    float restartTimer;

    void Awake()
    {
        //reference
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //When sanity reaches below 0
        if (sanity_bar.Sanity <= 0)
        {

            //tell animator game over
            anim.SetTrigger("GameOverSane");

            //incrememt restart timer
            restartTimer += Time.deltaTime;

            //if reaches restart delay
            if (restartTimer >= restartDelay)
            {
                //reload current level
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
            }
        }
        if (sanity_bar.sanity >= 100)
        {

            //tell animator game over
            anim.SetTrigger("GameOverInsane");

            //incrememt restart timer
            restartTimer += Time.deltaTime;

            //if reaches restart delay
            if (restartTimer >= restartDelay)
            {
                //reload current level
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
            }
        }
    }
}