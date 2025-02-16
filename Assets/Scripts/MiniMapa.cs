using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapa : MonoBehaviour
{
    public Transform player;

    private void LateUpdate() //se suele usar para la actualizacion de la camera
    {
        Vector3 newPosition = player.position;

        newPosition.y = transform.position.y;

        transform.position = newPosition;
    }
}
