using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aleatoirmouvemetn : MonoBehaviour
{
    public float speed = 50;

    void Start()
    {
        EffectuerMouvement();
    }

    void Update()
    {
    }

    void EffectuerMouvement()
    {
        float moveX = Random.Range(-10f, 10f);
        Vector2 mouvement = new Vector2(moveX, 0);
        transform.Translate(mouvement * Time.deltaTime * speed);
    }
}
