using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Camera cameraPrincipale;
    float marge = 0.1f; // Marge pour �viter que l'objet ne reste � la limite

    void Start()
    {
        cameraPrincipale = Camera.main;
    }

    void Update()
    {
        RestreindreDansChamp();
    }

    void RestreindreDansChamp()
    {
        Vector3 positionViewport = cameraPrincipale.WorldToViewportPoint(transform.position);

        // Ajuster la position en fonction des limites
        positionViewport.x = Mathf.Clamp01(positionViewport.x);
        positionViewport.y = Mathf.Clamp01(positionViewport.y);

        // R�affecter la position � l'objet
        transform.position = cameraPrincipale.ViewportToWorldPoint(positionViewport);
    }
}
