using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    
    public float restartDelay = 5;      //Restart level

    Animator anim;
    float restartTimer;

    void Awake()
    {
        //reference
        anim = GetComponent<Animator>();
    }
    
	// Update is called once per frame
	void Update () {
		//When sanity reaches below 0
        if(sanity_bar.sanity <= 0)
        {
            SceneManager.LoadScene(string GameOverSane, LoadSceneMode mode);

            //tell animator game over
            anim.SetTrigger("Game Over");

            //incrememt restart timer
            restartTimer += Time.deltaTime;

            //if reaches restart delay
            if(restartTimer >= restartDelay)
            {
                //reload current level
                SceneManager.LoadScene(Scene);
            }
        }
        if (sanity_bar.sanity >= 100)
        {
            //load insane game over scene
            SceneManager.LoadScene(string GameOverInsane, LoadSceneMode mode);

            //tell animator game over
            anim.SetTrigger("Game Over");

            //incrememt restart timer
            restartTimer += Time.deltaTime;

            //if reaches restart delay
            if (restartTimer >= restartDelay)
            {
                //reload current level
                SceneManager.LoadScene(Scene);
            }
        }
    }
}
