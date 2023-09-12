using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToPoints : MonoBehaviour
{
    //reference to Sprite component
    public SpriteRenderer sprite;


    ///-///////////////////////////////////////////////////////////
    /// When player touches this object, AddToPoints()
    public void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.LogFormat("colliding with: {0}", collision.name);
        if(collision.gameObject.tag == "Player")
        {
            //Singleton reference
            UIManager.instance.AddPoints();

            //we can alter this code to play audio when the player picks it up :))
            Destroy(gameObject);
        }
        
    }
}
