using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boutton_Jouer : MonoBehaviour
{
    // Le nom de la sc�ne vers laquelle vous voulez changer
    public string nomDeLaScene;

    // Mettez � jour est appel�e une fois par frame
    void Update()
    {
        // V�rifie si le bouton que vous voulez utiliser est enfonc� (vous pouvez changer "Fire1" � la touche que vous pr�f�rez)
        if (Input.GetButtonDown("Fire1"))
        {
            // Charge la nouvelle sc�ne
            SceneManager.LoadScene(0);
        }
    }
}