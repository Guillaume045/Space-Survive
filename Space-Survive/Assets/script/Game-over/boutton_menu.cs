using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boutton_menu : MonoBehaviour
{
    public Button votreBouton;

    void Start()
    {
        votreBouton.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(1);
        }
    }

    void TaskOnClick()
    {
        //Debug.Log("Le bouton a été cliqué");
        SceneManager.LoadScene(1);
        Debug.Log("Vous allez au menu");
    }
}