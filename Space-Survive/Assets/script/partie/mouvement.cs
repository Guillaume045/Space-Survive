using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotageObjet : MonoBehaviour
{
    public float vitesseAvant = 6f;
    public float vitesseRotation = 160f;

    void Update()
    {
        // Obtenez les entrées des touches Z, S, Q et D
        float inputAvant = Input.GetAxis("Vertical");
        float inputRotation = Input.GetAxis("Horizontal");

        // Rotation autour du centre de l'objet
        RotateAroundCenter(Vector3.forward, -inputRotation * vitesseRotation * Time.deltaTime);

        // Déplacement avant/arrière sur les axes X et Y
        transform.Translate(new Vector3(inputRotation, inputAvant, 0f) * vitesseAvant * Time.deltaTime);
    }

    void RotateAroundCenter(Vector3 axis, float angle)
    {
        Vector3 pivot = transform.position; // Utiliser la position actuelle de l'objet comme pivot
        Quaternion rotation = Quaternion.AngleAxis(angle, axis);
        Vector3 point = transform.position;

        // Déplacer l'objet vers le pivot, effectuer la rotation, puis revenir à la position initiale
        transform.Translate(pivot - point, Space.World);
        transform.rotation *= rotation;
        transform.Translate(point - pivot, Space.World);
    }

    // Fonction appelée lorsqu'il y a une collision
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision avec : " + collision.gameObject.name);
    }
}
