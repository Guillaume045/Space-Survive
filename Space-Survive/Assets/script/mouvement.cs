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
        // V�rifiez si la collision implique un objet avec un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetCollision"))
        {
            // �crivez un message dans la console Unity
            Debug.Log("Collision avec l'objet. Message affich� dans le terminal.");

            // D�sactivez tous les objets avec le script mouvement attach�
            DesactiverTousLesObjetsMouvement();
        }

        // Ajoutez le code de GestionCollision
        Debug.Log("Collision d�tect�e avec : " + collision.gameObject.name);
    }

    // Fonction pour d�sactiver tous les objets avec le script mouvement attach�
    private void DesactiverTousLesObjetsMouvement()
    {
        // R�cup�rez tous les objets avec le script mouvement attach� dans la sc�ne
        mouvement[] objets = FindObjectsOfType<mouvement>();

        // Parcourez chaque objet et d�sactivez-le
        foreach (mouvement objet in objets)
        {
            objet.gameObject.SetActive(false);
        }
    }
}
