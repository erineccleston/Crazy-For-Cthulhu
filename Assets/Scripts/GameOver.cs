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

            //tell animator game over
            anim.SetTrigger("GameOverSane");

            //incrememt restart timer
            restartTimer += Time.deltaTime;

            //if reaches restart delay
            if(restartTimer >= restartDelay)
            {
                //reload current level
<<<<<<< HEAD
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
=======
<<<<<<< HEAD
               // SceneManager.LoadScene(GameOverSane);
=======
                SceneManager.LoadScene(Scene);
>>>>>>> a77cfc6b21ce5d7adc52c606a2fd638644cf5018
>>>>>>> 1249d051d8f5a4d5065408021022a29fa86fbea9
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
<<<<<<< HEAD
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
=======
<<<<<<< HEAD
              //  SceneManager.LoadScene(GameOverInsane);
=======
                SceneManager.LoadScene(Scene);
>>>>>>> a77cfc6b21ce5d7adc52c606a2fd638644cf5018
>>>>>>> 1249d051d8f5a4d5065408021022a29fa86fbea9
            }
        }
    }
}
