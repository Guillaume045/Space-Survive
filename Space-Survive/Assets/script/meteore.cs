using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float asteroidSpeed = 5f; // Déclarer la vitesse de l'astéroïde

    private Vector2 randomDirection;

    private void Start()
    {
        // Définir une direction aléatoire lors de la création de l'astéroïde
        float randomDirectionX = Random.Range(-1f, 1f);
        float randomDirectionY = Random.Range(-1f, 1f);
        randomDirection = new Vector2(randomDirectionX, randomDirectionY).normalized;
    }

    private void Update()
    {
        // Déplacer l'astéroïde dans sa direction
        transform.Translate(randomDirection * asteroidSpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        // Détruire l'astéroïde s'il sort de l'écran
        Destroy(gameObject);
    }
}
