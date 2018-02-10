using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
<<<<<<< HEAD

    public float sanity;                  //Reference player sanity
=======
    
>>>>>>> a77cfc6b21ce5d7adc52c606a2fd638644cf5018
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
<<<<<<< HEAD
               // SceneManager.LoadScene(GameOverSane);
=======
                SceneManager.LoadScene(Scene);
>>>>>>> a77cfc6b21ce5d7adc52c606a2fd638644cf5018
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
<<<<<<< HEAD
              //  SceneManager.LoadScene(GameOverInsane);
=======
                SceneManager.LoadScene(Scene);
>>>>>>> a77cfc6b21ce5d7adc52c606a2fd638644cf5018
            }
        }
    }
}
