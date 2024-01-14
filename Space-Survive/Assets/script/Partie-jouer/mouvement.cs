using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilotageObjet : MonoBehaviour
{
    public float vitesseAvant = 6f;
    public float vitesseRotation = 160f;

    void Update()
    {
        float inputAvant = Input.GetAxis("Vertical");
        float inputRotation = Input.GetAxis("Horizontal");
        RotateAroundCenter(Vector3.forward, -inputRotation * vitesseRotation * Time.deltaTime);
        transform.Translate(new Vector3(inputRotation, inputAvant, 0f) * vitesseAvant * Time.deltaTime);
    }

    void RotateAroundCenter(Vector3 axis, float angle)
    {
        Vector3 pivot = transform.position;
        Quaternion rotation = Quaternion.AngleAxis(angle, axis);
        Vector3 point = transform.position;

        transform.Translate(pivot - point, Space.World);
        transform.rotation *= rotation;
        transform.Translate(point - pivot, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("asteroid"))
        {
            Debug.Log("Collision avec : " + other.gameObject.name);
            SceneManager.LoadScene(2);
        }
    }
    /*
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Objet sort du trigger : " + other.gameObject.name);
    }
    */
}
