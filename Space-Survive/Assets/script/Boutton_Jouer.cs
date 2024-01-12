using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boutton_Jouer : MonoBehaviour
{
    // Le nom de la scène vers laquelle vous voulez changer
    public string nomDeLaScene;

    // Mettez à jour est appelée une fois par frame
    void Update()
    {
        // Vérifie si le bouton que vous voulez utiliser est enfoncé (vous pouvez changer "Fire1" à la touche que vous préférez)
        if (Input.GetButtonDown("Fire1"))
        {
            // Charge la nouvelle scène
            SceneManager.LoadScene(0);
        }
    }
}