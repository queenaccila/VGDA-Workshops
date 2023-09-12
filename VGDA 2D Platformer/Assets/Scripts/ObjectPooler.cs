using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public List<AddToPoints> objectsToPool;

    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            EnableObject();
        }
    }


    void EnableObject()
    {
        if(count < objectsToPool.Count)
        {
            objectsToPool[count].gameObject.SetActive(true);
            count++;

           
        }
        else
        {
            count--;
            DisableObject();
        }
    }

    void DisableObject()
    {
        objectsToPool[count].gameObject.SetActive(false);
        count--;
    }
}
