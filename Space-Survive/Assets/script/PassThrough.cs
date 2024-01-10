using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThrough : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Vérifiez si l'objet rencontré est sur la couche "Blocker"
        if (other.gameObject.layer == LayerMask.NameToLayer("Blocker"))
        {
            Debug.Log("Collision avec un objet Blocker. Ne peut pas passer.");
        }
    }
}
