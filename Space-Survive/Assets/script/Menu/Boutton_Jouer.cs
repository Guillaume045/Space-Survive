using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boutton_Jouer : MonoBehaviour
{
    // Le nom de la sc�ne vers laquelle vous voulez changer
    public string nomDeLaScene;
    public Button votreBouton;

    void Start()
    {
        votreBouton.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Debug.Log("Le bouton a �t� cliqu�");
        SceneManager.LoadScene(0);
        Debug.Log("Vous aller en jeu");
    }
}