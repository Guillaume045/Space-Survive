using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aleatoirmouvemetn : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        EffectuerMouvement();
    }

    void EffectuerMouvement()
    {
        float moveX = Random.Range(-5f, 5f);
        Vector2 mouvement = new Vector2(moveX, 0);
        transform.Translate(mouvement * Time.deltaTime * speed);
    }
}
