using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public static SceneTransition Instance;
    [SerializeField]
    Animator animator;

    private int nextScene;

    ///-///////////////////////////////////////////////////////////
    ///
    private void Awake()
    {
        Instance = this;
        nextScene = SceneManager.GetActiveScene().buildIndex;
    }

   
    ///-///////////////////////////////////////////////////////////
    ///
    public void StartSceneTransition(int scene)
    {
        nextScene = scene;
        animator.Play("SceneEnd");
       
    }

    ///-///////////////////////////////////////////////////////////
    ///
    public void GoToNextLevel()
    {
        SceneManager.LoadSceneAsync(nextScene);
    }

    ///-///////////////////////////////////////////////////////////
    ///
    public void RestartLevel()
    {
        StartSceneTransition(nextScene);
    }
}
