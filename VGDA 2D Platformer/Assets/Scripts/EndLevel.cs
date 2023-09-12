using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


///-///////////////////////////////////////////////////////////
///This little enum gives us the dropdown menu on the Component in the Inspector window 
public enum Scenes
{
    LEVEL1 = 0,
    LEVEL2 = 1,
    LEVEL3 = 2,
}

///-///////////////////////////////////////////////////////////
///
public class EndLevel : MonoBehaviour
{
    [Tooltip("To reference more scenes, you need to edit this code to include them")]
    public Scenes scene;

    ///-///////////////////////////////////////////////////////////
    ///
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Tell our Singleton to begine changing scene
        SceneTransition.Instance.StartSceneTransition((int)scene);

        Debug.LogFormat("sending level info");
    }
}
