using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;


    //Awake() happens sooner than Start()
    private void Awake()
    {
        instance = this;
    }


    public TextMeshProUGUI pointsText;

    private int points;



    public void AddPoints()
    {
        points++;

        DisplayPoints();

    }


    public void DisplayPoints()
    {
        pointsText.text = points.ToString();
    }

}
