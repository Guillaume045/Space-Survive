using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparitionSurCollision : MonoBehaviour
{
    // Fonction appel�e lorsque cet objet entre en collision avec un autre objet
    private void OnCollisionEnter(Collision collision)
    {
        // V�rifiez si la collision implique un objet avec un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetCollision"))
        {
            // Faites dispara�tre cet objet en le d�sactivant
            gameObject.SetActive(false);

            // Vous pouvez �galement le d�truire avec la ligne suivante, mais cela d�pend de vos besoins
            // Destroy(gameObject);
        }
    }
}
