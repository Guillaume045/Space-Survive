using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public float seed = 10;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 mouvement = new Vector2(moveX, moveY);

        transform.Translate(mouvement * Time.deltaTime * seed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Vérifiez si la collision implique un objet avec un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetCollision"))
        {
            // Écrivez un message dans la console Unity
            Debug.Log("Collision avec l'objet. Message affiché dans le terminal.");

            // Désactivez tous les objets avec le script mouvement attaché
            DesactiverTousLesObjetsMouvement();
        }

        // Ajoutez le code de GestionCollision
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
    }

    // Fonction pour désactiver tous les objets avec le script mouvement attaché
    private void DesactiverTousLesObjetsMouvement()
    {
        // Récupérez tous les objets avec le script mouvement attaché dans la scène
        mouvement[] objets = FindObjectsOfType<mouvement>();

        // Parcourez chaque objet et désactivez-le
        foreach (mouvement objet in objets)
        {
            objet.gameObject.SetActive(false);
        }
    }
}
