using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparitionSurCollision : MonoBehaviour
{
    // Fonction appelée lorsque cet objet entre en collision avec un autre objet
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifiez si la collision implique un objet avec un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetCollision"))
        {
            // Faites disparaître cet objet en le désactivant
            gameObject.SetActive(false);

            // Vous pouvez également le détruire avec la ligne suivante, mais cela dépend de vos besoins
            // Destroy(gameObject);
        }
    }
}
