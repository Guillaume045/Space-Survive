using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public float seed = 10;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        //float seed = 10;
        Vector2 mouvement = new Vector2(moveX, moveY);

        transform.Translate(mouvement * Time.deltaTime * seed);
    }
}
