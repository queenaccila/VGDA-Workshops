using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemExample : MonoBehaviour
{

    public static EventSystemExample instance;

    //Awake() happens sooner than Start()
    private void Awake()
    {
        instance = this;
    }

    //My trigger
    public event Action onEventSystemNeededEnter;

    //Once trigger is called
    public void EventSystemNeededEnter()
    {
        //if we have subscribers, let them know something happened
        if (onEventSystemNeededEnter != null)
        {
            onEventSystemNeededEnter();
        }
    }

    public event Action onEventSystemNeededExit;
    public void EventSystemNeededExit()
    {
        //if we have subscribers, let them know something happened
        if (onEventSystemNeededExit != null)
        {
            onEventSystemNeededExit();
        }
    }
}
