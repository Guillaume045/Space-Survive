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
        Debug.Log("Le bouton a �t� cliqu�"); 
        Application.Quit();
        Debug.Log("Vous avez quitt� le jeu");
    }
    /* permet de quitt� le jeux mais que dans unity
    void TaskOnClick()
    {
        Debug.Log("Le bouton a �t� cliqu�");

#if UNITY_EDITOR
    // Application.Quit() ne fonctionne pas dans l'�diteur donc
    // si nous sommes dans l'�diteur, arr�tez de jouer le jeu
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

        Debug.Log("Vous avez quitt� le jeu");
    }
    */
}