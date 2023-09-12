using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ReadLevel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI sceneText;

    // Start is called before the first frame update
    void Start()
    {
        sceneText.text = SceneManager.GetActiveScene().name;
    }

}
