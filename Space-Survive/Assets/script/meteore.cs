using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteore : MonoBehaviour
{
    public GameObject objetAParaitre; // L'objet que vous souhaitez faire appara�tre
    private Vector3 positionDepart;

    void Start()
    {
        // Enregistrez la position de d�part
        positionDepart = transform.position;

        // Appelez la m�thode ApparaitreObjet apr�s un d�lai al�atoire
        float delaiAleatoire = Random.Range(0.5f, 2f);
        Invoke("ApparaitreObjet", delaiAleatoire);
    }

    void ApparaitreObjet()
    {
        // Faites appara�tre un nouvel objet � la position de d�part
        Instantiate(objetAParaitre, positionDepart, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // V�rifie si l'objet en collision a un certain tag (vous pouvez modifier le tag selon vos besoins)
        if (collision.gameObject.CompareTag("ObjetDetruit"))
        {
            // D�truit cet objet
            Debug.Log("Collision d�tect�e avec : " + collision.gameObject.name);
            Destroy(gameObject);

        }
    }
}