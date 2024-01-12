using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boutton_Quitter : MonoBehaviour
{
    public Button votreBouton;

    void Start()
    {
        votreBouton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Le bouton a été cliqué"); 
        Application.Quit();
        Debug.Log("Vous avez quitté le jeu");
    }
    /* permet de quitté le jeux mais que dans unity
    void TaskOnClick()
    {
        Debug.Log("Le bouton a été cliqué");

#if UNITY_EDITOR
    // Application.Quit() ne fonctionne pas dans l'éditeur donc
    // si nous sommes dans l'éditeur, arrêtez de jouer le jeu
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

        Debug.Log("Vous avez quitté le jeu");
    }
    */
}