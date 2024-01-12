using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteore : MonoBehaviour
{
    public GameObject objetAParaitre; // L'objet que vous souhaitez faire apparaître
    private Vector3 positionDepart;

    void Start()
    {
        // Enregistrez la position de départ
        positionDepart = transform.position;

        // Appelez la méthode ApparaitreObjet après un délai aléatoire
        float delaiAleatoire = Random.Range(0.5f, 2f);
        Invoke("ApparaitreObjet", delaiAleatoire);
    }

    void ApparaitreObjet()
    {
        // Faites apparaître un nouvel objet à la position de départ
        Instantiate(objetAParaitre, positionDepart, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Vérifie si l'objet en collision a un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetDetruit"))
        {
            // Détruit cet objet
            Debug.Log("Collision détectée avec : " + collision.gameObject.name);
            Destroy(gameObject);

        }
    }
}