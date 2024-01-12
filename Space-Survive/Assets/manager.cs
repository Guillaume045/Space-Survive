using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject asteroidPrefab; // Faites glisser votre prefab d'astéroïde ici
    public float spawnInterval = 2f;

    private void Start()
    {
        // Commencez à générer des astéroïdes à intervalles réguliers
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }

    private void SpawnAsteroid()
    {
        // Générer un astéroïde à une position aléatoire
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(-5f, 5f);

        Vector2 randomPosition = new Vector2(randomX, randomY);

        Instantiate(asteroidPrefab, randomPosition, Quaternion.identity);
    }
}
