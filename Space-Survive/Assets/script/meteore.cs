using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteore : MonoBehaviour
{
    public GameObject objetAParaitre;
    private Vector3 positionDepart;

    void Start()
    {
        positionDepart = transform.position;
        float delaiAleatoire = Random.Range(0.3f, 1f);
        Invoke("ApparaitreObjet", delaiAleatoire);
    }

    void ApparaitreObjet()
    {
        Debug.Log("Objet à instancier : " + objetAParaitre);

        Quaternion rotationAleatoire = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
        Instantiate(objetAParaitre, positionDepart, rotationAleatoire);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
