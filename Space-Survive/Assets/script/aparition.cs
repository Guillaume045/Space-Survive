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

            // Copiez les propri�t�s du Rigidbody du premier objet vers le nouvel objet (s'il y en a un)
            Rigidbody premierObjetRigidbody = objet.GetComponent<Rigidbody>();
            Rigidbody nouvelObjetRigidbody = nouvelObjet.GetComponent<Rigidbody>();

            if (premierObjetRigidbody != null && nouvelObjetRigidbody != null)
            {
                nouvelObjetRigidbody.velocity = premierObjetRigidbody.velocity;
                nouvelObjetRigidbody.angularVelocity = premierObjetRigidbody.angularVelocity;
                // Copiez d'autres propri�t�s du Rigidbody au besoin
            }
        }
        else
        {
            Debug.LogError("Objet � faire appara�tre non assign� !");
        }
    }
}
