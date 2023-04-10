using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime =  2f;


    public void PlayGame(){
      
        Debug.Log("Play!");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(LoadLevel(1));

    }

    IEnumerator LoadLevel(int sceneIndex) {
        
        // //Play animation
       // transition.SetTrigger("Start");
            
        //  //Wait transitionTime Seconds
        yield return new WaitForSeconds(transitionTime);

        //load Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneIndex);
    }

    public void QuitGame(){
        Debug.Log("Quit!");
        Application.Quit();

    }
}
