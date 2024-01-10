using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparition : MonoBehaviour
{
    public GameObject objetAParaitre;
    public GameObject secondObjetAParaitre;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            Vector3 positionApparition = transform.position;
            ApparaitreObjet(objetAParaitre, positionApparition);
            ApparaitreObjet(secondObjetAParaitre, positionApparition);
        }
    }

    void ApparaitreObjet(GameObject objet, Vector3 position)
    {
        if (objet != null)
        {
            GameObject nouvelObjet = Instantiate(objet, position, Quaternion.identity);

            // Copiez les propriétés du Rigidbody du premier objet vers le nouvel objet (s'il y en a un)
            Rigidbody premierObjetRigidbody = objet.GetComponent<Rigidbody>();
            Rigidbody nouvelObjetRigidbody = nouvelObjet.GetComponent<Rigidbody>();

            if (premierObjetRigidbody != null && nouvelObjetRigidbody != null)
            {
                nouvelObjetRigidbody.velocity = premierObjetRigidbody.velocity;
                nouvelObjetRigidbody.angularVelocity = premierObjetRigidbody.angularVelocity;
                // Copiez d'autres propriétés du Rigidbody au besoin
            }
        }
        else
        {
            Debug.LogError("Objet à faire apparaître non assigné !");
        }
    }
}
