using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Appelé lorsqu'il y a une collision avec un autre objet
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifie si l'objet en collision a un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetDetruit"))
        {
            // Détruit cet objet
            Destroy(gameObject);
        }
    }
}