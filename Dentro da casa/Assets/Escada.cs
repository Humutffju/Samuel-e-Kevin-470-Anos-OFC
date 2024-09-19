using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    // Coordenadas para onde o objeto será teleportado
    public Vector3 (7.749,2.001,-5.414);

    void OnCollisionEnter(Collision collision)
    {
        // Verifica se o objeto colidido tem a tag "Teleport"
        if (collision.gameObject.CompareTag("Teleport"))
        {
            // Teleporta o objeto para a posição alvo
            transform.position = (7.749, 2.001, -5.414);
        }
    }
}