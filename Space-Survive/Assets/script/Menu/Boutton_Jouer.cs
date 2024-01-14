using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boutton_Jouer : MonoBehaviour
{
    public Button votreBouton;

    void Start()
    {
        votreBouton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Debug.Log("Le bouton a été cliqué");
        SceneManager.LoadScene(0);
        Debug.Log("Vous aller en jeu");
    }
}